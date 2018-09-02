using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fuwo.Authorization;

namespace fuwo
{
    [DependsOn(
        typeof(fuwoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class fuwoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<fuwoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(fuwoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
