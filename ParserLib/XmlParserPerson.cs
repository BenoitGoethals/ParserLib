using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParserLib
{
    public sealed class XmlParserPerson : IParse<Person>
    {
        private string _file;

        public XmlParserPerson(string file)
        {
            this._file = file;
        }

        public List<Person> Parse()
        {
            XElement xelements = XElement.Load(_file);
            int highst = 0;
          
            List<Person> ret =
                xelements.Elements("Person")
                    .Select(q => new Person()
                    {
                       // Id = 
                         Name = (string)q.Element("Name"),
                         City = (string)q.Element("City"),
                         Email = (string)q.Element("Email"),
                         Phone = (string)q.Element("Phone"),
                         Street = (string)q.Element("Street"),
                         Zip = (string)q.Element("Postal"),
                         Date = ((string)q.Element("Date")).ToDateTime("dd/MM/yy")


                         
                    }).ToList();
            Debug.WriteLine(ret.Count);
            return ret;
        }
    }
}
