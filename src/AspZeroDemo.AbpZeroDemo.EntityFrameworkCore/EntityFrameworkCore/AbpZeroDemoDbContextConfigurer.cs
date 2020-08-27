using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AspZeroDemo.AbpZeroDemo.EntityFrameworkCore
{
    public static class AbpZeroDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpZeroDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}