namespace SocietyModuleAPI.Entities
{
    public class ActiveMemberPlotFile
    {
        public int memberFileId { get; set; }
        public int memberProfileId { get; set; }
        public int plotFileId { get; set; }
        public int isActivated { get; set; }
        public string fileNo { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string memberDOB { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string Date { get; set; }
        public string acquisitionTypeTitle { get; set; }
        public string isDeleted { get; set; }
        public string Mode { get; set; }
        public string phoneNo1 { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public string Status { get; set; }
        public int permanentAddressCityID { get; set; }
        public int presentAddressCityID { get; set; }
    }
}