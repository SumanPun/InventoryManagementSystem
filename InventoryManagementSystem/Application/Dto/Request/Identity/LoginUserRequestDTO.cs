using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Request.Identity
{
    public class LoginUserRequestDTO
    {
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[0-9])(?=.*[#?!@$ %^&*-]).{8,}$",ErrorMessage ="Your Password is not strong")]
        [MinLength(8), MaxLength(100)]
        public string Password { get; set; }
    }
}
