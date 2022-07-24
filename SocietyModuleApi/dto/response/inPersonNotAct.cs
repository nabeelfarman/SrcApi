namespace SocietyModuleAPI.Entities
{
    public class InPersonNotAct
    {
        public int inPersonID { get; set; }
        public int memberProfileId { get; set; }
        public int plotFileId { get; set; }
        public string inPersonDate { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string designation { get; set; }
        public string BPS { get; set; }
        public string memberCNIC { get; set; }
        public string memberDOB { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddressCityID { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddressCityId { get; set; }
        public string memberPicture { get; set; }
        public string fingerPrint1 { get; set; }
        public string fingerPrint2 { get; set; }
        public string createdBy { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
        public string fileNo { get; set; }
        public string plotTypeTitle { get; set; }
        public string unit { get; set; }
        public string plotSize { get; set; }
        public string plotCategoryTitle { get; set; }
        public string plotNatureTitle { get; set; }
        public int transferId { get; set; }
        public string memberMode { get; set; }
    }
}