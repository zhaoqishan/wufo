using System.Threading.Tasks;
using Abp.Application.Services;
using fuwo.Sessions.Dto;

namespace fuwo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
