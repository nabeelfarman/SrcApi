namespace FMISModuleAPI.Entities
{
    public class ExternalPartiesCreation
    {
        public int newMemberProfileID { get; set; }
        public string memberType { get; set; }
        public string membername { get; set; }
        public string organization { get; set; }
        public string MemberCNIC { get; set; }
        public string NTN { get; set; }
        public string STN { get; set; }
        public string PhoneNO1 { get; set; }
        public string MObileNO1 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddressCityID { get; set; }
        public string memberRemarks { get; set; }
        public string applicationDate { get; set; }
        public string taxCategory { get; set; }
        public string residentStatus { get; set; }
        public int isNTNduplication { get; set; }
        public int isCNICDuplication { get; set; }
        public int UserID { get; set; }
        public string spType { get; set; }
    }
}