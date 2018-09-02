using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using fuwo.Configuration;
using fuwo.Web;

namespace fuwo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class fuwoDbContextFactory : IDesignTimeDbContextFactory<fuwoDbContext>
    {
        public fuwoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<fuwoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            fuwoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(fuwoConsts.ConnectionStringName));

            return new fuwoDbContext(builder.Options);
        }
    }
}
