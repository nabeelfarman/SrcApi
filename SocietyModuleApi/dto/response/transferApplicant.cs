namespace SocietyModuleAPI.Entities
{
    public class TransferApplicant
    {
        public int transferDetailID { get; set; }
        public int transferID { get; set; }
        public int memberProfileID_Buyer { get; set; }
        public string date { get; set; }
        public int plotFileId { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string Designation { get; set; }
        public int BPS { get; set; }
        public string memberCNIC { get; set; }
        public string memberDOB { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string membershipNo { get; set; }
        public int isDeleted { get; set; }
        public int inPersonId { get; set; }
        public int createdBy { get; set; }
    }
}