using System.Text.Json.Serialization;


namespace UMISModuleAPI.Entities
{
    public class User
    {
        public int userLoginId { get; set; }
        public int roleId { get; set; }
        public string fullName { get; set; }
        public string loginName { get; set; }
        public string password { get; set; }
        public string spType { get; set; }
    }
}