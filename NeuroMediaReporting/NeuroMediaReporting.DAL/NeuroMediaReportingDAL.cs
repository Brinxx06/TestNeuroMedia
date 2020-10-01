using NeuroMediaReporting.DAL.Entities;
using SoftCircuits.CsvParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace NeuroMediaReporting.DAL
{
    public class NeuroMediaReportingDAL
    {
       public IEnumerable<SessionReportDAO> SearchSessionReports(string dirPath, string mask)
        {
            List<SessionReportDAO> sessionReports = new List<SessionReportDAO>();

            foreach (var filePath in GetFileList(dirPath, mask))
            {
                GetAllReportFromFile(filePath);
            }

            return null;
        }

        public IEnumerable<SessionReportDAO> GetAllReportFromFile(string filePath)
        {
            List<SessionReportDAO> sessionReports = new List<SessionReportDAO>();
            using (CsvReader<SessionReportDAO> reader = new CsvReader<SessionReportDAO>(filePath))
            {
                // Read header and use to determine column order
                reader.ReadHeaders(false);
                // Read data
                while (reader.Read(out SessionReportDAO sessionReportDAO))
                    sessionReports.Add(sessionReportDAO);
            }

            return sessionReports;
        }

        public IEnumerable<string> GetFileList(string dirPath, string mask)
        {
            var allFilesPaths = Directory.GetFiles(dirPath);

            return allFilesPaths.Where(fp => FitsMask(Path.GetFileName(fp), mask));
        }

        private bool FitsMask(string sFileName, string sFileMask)
        {
            Regex mask = new Regex(sFileMask.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
            return mask.IsMatch(sFileName);
        }
    }
}
