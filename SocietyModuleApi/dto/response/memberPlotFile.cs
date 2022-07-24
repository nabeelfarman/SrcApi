namespace SocietyModuleAPI.Entities
{
    public class MemberPlotFile
    {
        public int memberFileId { get; set; }
        public int memberFileGroupId { get; set; }
        public int memberProfileId { get; set; }
        public int membershipNo { get; set; }
        public int paymentPlanID { get; set; }
        public int plotFileId { get; set; }
        public int fileTransferID { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddresscityId { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddresscityId { get; set; }
        public int fileNo { get; set; }
        public int isDeleted { get; set; }
        public string Date { get; set; }
        public string allotmentLetterEDoc { get; set; }
        public int createdBy { get; set; }
        public int acquisitionTypeID { get; set; }
        public int isActivated { get; set; }
        public string memberDOB { get; set; }
    }
}