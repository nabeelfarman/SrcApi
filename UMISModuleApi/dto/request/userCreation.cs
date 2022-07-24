using System.Text.Json.Serialization;


namespace UMISModuleAPI.Entities
{
    public class UserCreation
    {
        public string name { get; set; }
        public string loginname { get; set; }
        public string hashpassword { get; set; }
        public string spType { get; set; }
        public int newUserId { get; set; }
        public int loginID { get; set; }
        public int roleID { get; set; }
    }
}