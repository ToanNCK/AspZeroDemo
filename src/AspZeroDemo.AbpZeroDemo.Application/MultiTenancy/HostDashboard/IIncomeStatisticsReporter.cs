using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.HostDashboard.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}