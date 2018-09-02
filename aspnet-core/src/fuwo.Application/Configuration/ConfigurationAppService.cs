using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using fuwo.Configuration.Dto;

namespace fuwo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : fuwoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
