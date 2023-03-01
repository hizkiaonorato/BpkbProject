using System.ComponentModel.DataAnnotations;

namespace BPKBBackendProject.Models.Login
{
    public class AuthenticateRequest
    {
        [Required]
        public string user_name { get; set; }

        [Required]
        public string password { get; set; }
    }
}
