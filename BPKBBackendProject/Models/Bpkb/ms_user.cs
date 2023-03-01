using System.Text.Json.Serialization;

namespace BPKBBackendProject.Models.Bpkb
{
    public class ms_user
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
    }
}
