namespace SocietyModuleAPI.Entities
{
    public class TransferMemberInProcess
    {
        public string fileNo { get; set; }
        public int memberProfileId { get; set; }
        public int plotFileId { get; set; }
        public int isActivated { get; set; }
        public int isDeleted { get; set; }
        public string mode { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string phoneNo1 { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public string memberDOB { get; set; }
        public int presentAddressCityID { get; set; }
        public int permanentAddressCityID { get; set; }
        public int transferId { get; set; }
        public int iscompleted { get; set; }
        public string status { get; set; }
    }
}