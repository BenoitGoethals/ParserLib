using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLib
{
    public  class Parser
    {
        private IParse _parseStrategie ;



        private  List<Person> persons = new List<Person>();

        public  List<Person> Parse(string file)
        {
           
            if(file.Contains(".csv"))
                _parseStrategie=new CsvParser(file);
            else if (file.Contains(".xml"))
                _parseStrategie = new XmlParser(file);


            return _parseStrategie.Parse();
        }


       

       
    }
}