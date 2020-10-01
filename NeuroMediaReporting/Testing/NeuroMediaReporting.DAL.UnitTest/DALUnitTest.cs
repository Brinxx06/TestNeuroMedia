using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuroMediaReporting.DAL.Entities;
using SoftCircuits.CsvParser;
using System.Collections.Generic;
using System.IO;

namespace NeuroMediaReporting.DAL.UnitTest
{
    [TestClass]
    public class DALUnitTest
    {
        [TestMethod]
        public void ReadFile_Test()
        {
            List<SessionReportDAO> people = new List<SessionReportDAO>();
            using (CsvReader<SessionReportDAO> reader = new CsvReader<SessionReportDAO>(@"access.log"))
            {
                // Read header and use to determine column order
                reader.ReadHeaders(false);
                // Read data
                while (reader.Read(out SessionReportDAO person))
                    people.Add(person);
            }
        }
    }
}
