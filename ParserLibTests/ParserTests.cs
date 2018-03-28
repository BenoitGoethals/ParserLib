using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib;

namespace ParserLibTests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        public void ParseCsvTest()
        {
            var persons= new Parser().Parse("c:/temp/dataMar-28-2018.csv");
            foreach (var pers  in persons)
            {
                Assert.IsNotNull(pers.Name);
            }
            Assert.AreEqual(100,persons.Count);
            Debug.WriteLine(persons.Count);
        }

        [TestMethod()]
        public void ParseXmlTest()
        {
            var persons = new Parser().Parse("c:/temp/dataMar-28-2018.xml");
            foreach (var pers in persons)
            {
                Assert.IsNotNull(pers.Name);
            }
            Assert.AreEqual(100, persons.Count);
            Debug.WriteLine(persons.Count);
        }

    }
}