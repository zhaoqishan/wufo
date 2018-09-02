using System.Threading.Tasks;
using fuwo.Configuration.Dto;

namespace fuwo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
