using NeuroMediaReporting.DAL;
using System;

namespace NeuroMediaReporting.BLL
{
    public class NeuroMediaReportingBLL
    {
        public void GetAllReports()
        {
            NeuroMediaReportingDAL dal = new NeuroMediaReportingDAL();
            dal.SearchSessionReports(@"C:\NeuroMediaTest\Logs", "*.log.*");
        }

    }
}
