using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLib
{
    public  class ParserPerson
    {
        private static IParse _parseStrategie ;

        private ParserPerson()
        {
            
        }

        private static ParserPerson _instance=new ParserPerson();

        private static List<Person> persons = new List<Person>();

        public   List<Person> Parse(string file)
        {
           
            if(file.Contains(".csv"))
                _parseStrategie=new CsvParser(file);
            else if (file.Contains(".xml"))
                _parseStrategie = new XmlParser(file);


            return _parseStrategie.Parse();
        }


        public static ParserPerson Instance()
        {
            return _instance;
        }

       
    }
}