using BPKBBackendProject.Models.Bpkb;

namespace BPKBBackendProject.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateToken(ms_user user);
        public int? ValidateToken(string token);
    }
}
