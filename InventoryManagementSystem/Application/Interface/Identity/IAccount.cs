using Application.Dto.Request.Identity;
using Application.Dto.Response;
using Application.Dto.Response.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Identity
{
    public interface IAccount
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUserClaimsAsync(CreateUserRequestDTO model);
        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);

    }
}
