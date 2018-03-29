using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLib
{
    public  class Parser<T>
    {
        private static IParse<T> _parseStrategie ;

        private Parser()
        {
            
        }

        private static Parser<T> _instance=new Parser<T>();

        private static List<T> persons = new List<T>();

        public   List<T> Parse(string file)
        {
            if(file.Contains(".csv"))
                _parseStrategie=new CsvParserPerson(file) as IParse<T>;
            else if (file.Contains(".xml"))
                _parseStrategie = new XmlParserPerson(file) as IParse<T>;


            return _parseStrategie.Parse();
        }


        public static Parser<T> Instance()
        {
            return _instance;
        }

       
    }
}