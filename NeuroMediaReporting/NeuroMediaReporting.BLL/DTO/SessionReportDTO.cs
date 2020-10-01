using System;
using System.Collections.Generic;
using System.Text;

namespace NeuroMediaReporting.BLL.DTO
{
    public class SessionReportDTO
    {
        public string IPAddress { get; set; }
        public DateTime EndDate { get; set; }
        public string URL { get; set; }

        public string HTTPCode { get; set; }

        public string TransferedBytes { get; set; }
        public string UserAgent { get; set; }
        /// <summary>
        /// Duration in seconds
        /// </summary>
        public int Duration { get; set; }
    }
}
