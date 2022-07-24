namespace SocietyModuleAPI.Entities
{
    public class TransferInboxCreation
    {
        public int transferId { get; set; }
        public int userid { get; set; }
        public int receivedUserId { get; set; }
        public int createdBy { get; set; }
        public int newTransferProcessId { get; set; }
        public string spType { get; set; }
    }
}