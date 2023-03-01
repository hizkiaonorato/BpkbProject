namespace BPKBBackendProject.Models.Login
{
    public class AuthenticateResponse
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string Token { get; set; }
    }
}
