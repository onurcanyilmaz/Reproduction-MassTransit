using System.Threading.Tasks;
using Abp.Application.Services;
using Reproduction.Sessions.Dto;

namespace Reproduction.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
