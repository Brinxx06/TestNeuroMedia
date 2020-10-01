using SoftCircuits.CsvParser;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuroMediaReporting.DAL.Entities
{
    /// <summary>
    /// Represents a tuple of Session report in the log files
    /// </summary>
    public class SessionReportDAO
    {
        [ColumnMap(Index = 0)]
        public string IPAddress { get; set; }
        
        [ColumnMap(Index = 1)]
        public string EndDate { get; set; }
        
        [ColumnMap(Index = 2)]
        public string URL { get; set; }

        [ColumnMap(Index = 3)]
        public string HTTPCode { get; set; }
        
        [ColumnMap(Index = 4)]
        public string TransferedBytes { get; set; }

        [ColumnMap(Index = 6)]
        public string UserAgent { get; set; }
        /// <summary>
        /// Duration in seconds
        /// </summary>
        [ColumnMap(Index = 7)]
        public int Duration { get; set; }

    }
}
