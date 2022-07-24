namespace SocietyModuleAPI.Entities
{
    public class TransferInbox
    {
        public int transferProcessID { get; set; }
        public int transferId { get; set; }
        public int userId { get; set; }
        public string transferDate { get; set; }
        public int receivedUserId { get; set; }
        public string receivedDateTime { get; set; }
        public string outDateTime { get; set; }
        public int seqNo { get; set; }
        public int transferProcessstatus { get; set; }
        public int isDeleted { get; set; }
        public int plotFileId { get; set; }
        public int isCompleted { get; set; }
        public string memberShipNo { get; set; }
    }
}