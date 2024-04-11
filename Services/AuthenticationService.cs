using AutoMapper;
using Contracts;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Service.AuthenticationService;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Service.AuthenticationService
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private User? _User;
        public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> UserManager,
                                     RoleManager<IdentityRole> RoleManager, IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = UserManager;
            _configuration = configuration;
            _roleManager = RoleManager;
        }

     
        
        public async Task<ICollection<string>> GetRoles()
        {

            var result = await _roleManager.Roles.Select(x => x.Name).ToListAsync();
            return result;
        }

        public async Task<ICollection<string>> GetRolesByUserEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.GetRolesAsync(user);
            return result;
        }

        public async Task<bool> ValidateUser(AuthorizeDto authorizeDto)
        {
            _User = await _userManager.FindByEmailAsync(authorizeDto.Email);
            var result = (_User != null && await _userManager.CheckPasswordAsync(_User, authorizeDto.Password));
            if (!result)
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong Username or password.");

            return result;
        }
        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes("Мой_секретный_ключ_для_шифрования");
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, _User.Email)
                };

            var roles = await _userManager.GetRolesAsync(_User);

            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
                (issuer: jwtSettings["validIssuer"],
                 audience: jwtSettings["validAudience"],
                 claims: claims,
                 expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                 signingCredentials: signingCredentials);

            return tokenOptions;
        }

        public async Task<IdentityResult> RegisterUser(AuthorizeDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded && userForRegistration.Roles is not null)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
          
            
            return result;
        }
    }
}