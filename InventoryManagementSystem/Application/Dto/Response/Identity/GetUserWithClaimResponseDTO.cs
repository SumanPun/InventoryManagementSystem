using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Response.Identity
{
    public class GetUserWithClaimResponseDTO : BaseUserClaimDTO
    {
        public string Email { get; set; }
    }
}
