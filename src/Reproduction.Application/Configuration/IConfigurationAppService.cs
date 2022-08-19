using System.Threading.Tasks;
using Reproduction.Configuration.Dto;

namespace Reproduction.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
