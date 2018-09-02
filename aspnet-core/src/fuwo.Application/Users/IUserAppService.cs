using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fuwo.Roles.Dto;
using fuwo.Users.Dto;

namespace fuwo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
