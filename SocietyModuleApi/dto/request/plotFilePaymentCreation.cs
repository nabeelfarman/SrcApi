namespace SocietyModuleAPI.Entities
{
    public class PlotFilePaymentCreation
    {
        public int bankTransferId { get; set; }
        public string collectionBrCode { get; set; }
        public string collectionBranch { get; set; }
        public int plotFileId { get; set; }
        public int coaId { get; set; }
        public int memberProfileId { get; set; }
        public string memberName { get; set; }
        public string memberCNIC { get; set; }
        public string phoneNo1 { get; set; }
        public string receiptDate { get; set; }
        public int depositSlipNo { get; set; }
        public float amount { get; set; }
        public string referenceNo { get; set; }
        public int bankId { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
        public int newPLotFilePaymentId { get; set; }
        public int trnTypeId { get; set; }
        public string json { get; set; }
    }
}