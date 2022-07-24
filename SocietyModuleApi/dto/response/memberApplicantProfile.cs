namespace SocietyModuleAPI.Entities
{
    public class MemberApplicantProfile
    {
        public int memberProfileId { get; set; }
        public int memberFileId { get; set; }
        public int memberFileGroupId { get; set; }
        public int plotfileId { get; set; }
        public string fileNo { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string memberDOB { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddresscityId { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddresscityId { get; set; }
        public string memberRemarks { get; set; }
        public string applicationDate { get; set; }
        public string memberShipDate { get; set; }
        public int isActivated { get; set; }
        public int isDeleted { get; set; }
        public int createdBy { get; set; }
        // public int membershipNo { get; set; }
        public int fileActivated { get; set; }
        public int paymentPlanId { get; set; }
        public string applicationEDoc { get; set; }
        // public string memberPictureDB { get; set; }
        public string memberPicture { get; set; }
        public string Designation { get; set; }
        public string memberType { get; set; }
        public int BPS { get; set; }
    }
}