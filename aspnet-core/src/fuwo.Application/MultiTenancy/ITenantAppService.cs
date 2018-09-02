using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fuwo.MultiTenancy.Dto;

namespace fuwo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
