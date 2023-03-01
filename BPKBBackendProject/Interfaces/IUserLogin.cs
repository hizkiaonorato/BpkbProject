using BPKBBackendProject.Models.Login;

namespace BPKBBackendProject.Interfaces
{
    public interface IUserLogin
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        void Register(RegisterRequest model);
    }
}
