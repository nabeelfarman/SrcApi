namespace FMISModuleAPI.Entities
{
    public class ExternalParties
    {
        public int memberProfileId { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string organization { get; set; }
        public string memberCNIC { get; set; }
        public int presentAddresscityId { get; set; }
        public string memberRemarks { get; set; }
        public int inPersonId { get; set; }
        public string taxCategory { get; set; }
        public string filerNonfilerStatus { get; set; }
        public string NTN { get; set; }
        public string ResidentStatus { get; set; }
        public string presentAddress { get; set; }
        public string applicationDate { get; set; }
        public string phoneNo1 { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public int isActivated { get; set; }
        public int IsDeleted { get; set; }
    }
}