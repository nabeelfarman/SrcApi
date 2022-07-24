namespace LandModuleAPI.Entities
{
    public class LandOwnerCreation
    {
        public int newMemberProfileID { get; set; }
        public string membername { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string mObileNO1 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddressCityID { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddressCityID { get; set; }
        public string memberRemarks { get; set; }
        public string applicationDate { get; set; }
        public string spType { get; set; }
        public int userID { get; set; }

    }
}