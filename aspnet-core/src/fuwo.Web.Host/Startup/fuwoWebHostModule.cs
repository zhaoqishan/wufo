using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fuwo.Configuration;

namespace fuwo.Web.Host.Startup
{
    [DependsOn(
       typeof(fuwoWebCoreModule))]
    public class fuwoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public fuwoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(fuwoWebHostModule).GetAssembly());
        }
    }
}
