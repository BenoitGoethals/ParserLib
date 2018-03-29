using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLib
{
   public  class  CsvParserPerson : IParse<Person>
   {
        private readonly string _file;

        public CsvParserPerson(string file)
        {
            this._file = file;
        }

        public List<Person> Parse()
        {
            

            var query = from data in GetDataPerLines(_file)
                let splitChr = data.Split("|".ToCharArray())


                select new Person()
                {
                    //Name|Street|City|Postal|Email|Date|Phone
                    
                    Id = 0,
                    Name = splitChr[0],
                    Date = splitChr[5].ToDateTime("dd/MM/yy"), 
                        
                    City = splitChr[3],
                    Email = splitChr[4],
                    Phone = splitChr[6],
                    Street = splitChr[1],
                    Zip = splitChr[0]

                };
            return query.ToList<Person>();
        }



        private static IEnumerable<String> GetDataPerLines(string file)
        {
            FileStream aFile = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            string line;
            sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
            sr.Close();
        }




    }
}
