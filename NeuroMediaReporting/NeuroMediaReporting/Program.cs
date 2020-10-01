using NeuroMediaReporting.BLL;
using System;

namespace NeuroMediaReporting
{
    class Program
    {
        static void Main(string[] args)
        {
            NeuroMediaReportingBLL bll = new NeuroMediaReportingBLL();
            bll.GetAllReports();
        }
    }
}
