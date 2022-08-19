using Abp.Application.Services;
using Reproduction.MultiTenancy.Dto;

namespace Reproduction.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

