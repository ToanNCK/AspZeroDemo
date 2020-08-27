namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.HostDashboard
{
    public class HostDashboardViewModel
    {
        public int ReportOnLoadDayCount { get; set; } 

        public HostDashboardViewModel(int reportOnLoadDayCount)
        {
            ReportOnLoadDayCount = reportOnLoadDayCount;
        }
    }
}