using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AspZeroDemo.AbpZeroDemo.Configuration;
using AspZeroDemo.AbpZeroDemo.Web;

namespace AspZeroDemo.AbpZeroDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpZeroDemoDbContextFactory : IDesignTimeDbContextFactory<AbpZeroDemoDbContext>
    {
        public AbpZeroDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpZeroDemoDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            AbpZeroDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpZeroDemoConsts.ConnectionStringName));

            return new AbpZeroDemoDbContext(builder.Options);
        }
    }
}