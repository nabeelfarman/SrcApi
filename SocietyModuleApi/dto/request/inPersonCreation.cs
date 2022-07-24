namespace SocietyModuleAPI.Entities
{
    public class InPersonCreation
    {
        public int newInpersonId { get; set; }
        public int memberProfileId { get; set; }
        public int plotFileId { get; set; }
        public int? transferId { get; set; }
        public string memberType { get; set; }
        public string memberMode { get; set; }
        public string memberName { get; set; }
        public string inpersonDate { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string Designation { get; set; }
        public int? BPS { get; set; }
        public string memberDOB { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string Email { get; set; }
        public string presentAddress { get; set; }
        public int? presentAddresscityId { get; set; }
        public string permanentAddress { get; set; }
        public int? permanentAddresscityId { get; set; }
        public string memberRemarks { get; set; }
        public string memberPicturePath { get; set; }
        public string memberPicture { get; set; }
        public string memberPictureExtension { get; set; }
        public string fingerPrint1 { get; set; }
        public string fingerPrint2 { get; set; }
        public int? newinPersonCareofId { get; set; }
        public int? userid { get; set; }
        public string spType { get; set; }
    }
}