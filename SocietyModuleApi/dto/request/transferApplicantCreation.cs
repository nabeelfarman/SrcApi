namespace SocietyModuleAPI.Entities
{
    public class TransferApplicantCreation
    {
        public int newTransferDetailID { get; set; }
        public int transferId { get; set; }
        public int memberProfileId { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}