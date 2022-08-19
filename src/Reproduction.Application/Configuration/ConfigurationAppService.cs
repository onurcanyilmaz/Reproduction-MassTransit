using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Reproduction.Configuration.Dto;

namespace Reproduction.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReproductionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
