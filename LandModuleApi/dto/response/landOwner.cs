namespace LandModuleAPI.Entities
{
    public class LandOwner
    {
        public int memberProfileId { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string applicationDate { get; set; }
        public string phoneNo1 { get; set; }
        public int isDeleted { get; set; }

    }
}