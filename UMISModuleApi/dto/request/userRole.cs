using System.Text.Json.Serialization;


namespace UMISModuleAPI.Entities
{
    public class UserRole
    {
        public string json { get; set; }
        public int NewRoleID { get; set; }
        public string roleTitle { get; set; }
        public string roleDescription { get; set; }
        public string Userid { get; set; }
        public string spType { get; set; }
    }
}