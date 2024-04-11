using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObjects;

namespace Service.AuthenticationService;
public interface IAuthenticationService
{
    Task<bool> ValidateUser(AuthorizeDto authorizeDto);
    Task<ICollection<string>> GetRoles();
    Task<string> CreateToken();
    Task<IdentityResult> RegisterUser(AuthorizeDto userForRegistration);
    Task<ICollection<string>> GetRolesByUserEmail(string email);
}