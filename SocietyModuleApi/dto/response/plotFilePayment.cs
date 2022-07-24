namespace SocietyModuleAPI.Entities
{
    public class PlotFilePayment
    {
        public int plotFilePaymentId { get; set; }
        public int plotFileId { get; set; }
        public int bankId { get; set; }
        public int coaId { get; set; }
        public string memberCNIC { get; set; }
        public string memberName { get; set; }
        public string receiptDate { get; set; }
        public string phoneNo1 { get; set; }
        public float amount { get; set; }
        public int trnId { get; set; }
        public string referenceNO { get; set; }
        public int depositSlipNo { get; set; }
        public string collectionBranchCode { get; set; }
        public string collectionBranchName { get; set; }
        public int isDeleted { get; set; }
        public int memberProfileId { get; set; }
        public string fileNo { get; set; }
        public string AccountCode { get; set; }
        public string accountTitle { get; set; }
    }
}