using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Reproduction.MultiTenancy;

namespace Reproduction.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
