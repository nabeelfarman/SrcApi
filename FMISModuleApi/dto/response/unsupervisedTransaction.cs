namespace FMISModuleAPI.Entities
{
    public class UnsupervisedTransaction
    {
        public int trnTypeId { get; set; }
        public int trnId { get; set; }
        public string trnDate { get; set; }
        public string trnDescription { get; set; }
        public string chequeNo { get; set; }
        public string chequeDate { get; set; }
        public int bankId { get; set; }
        public float amount { get; set; }
        public string beneficiary { get; set; }
        public string trnType { get; set; }
        public string titleofAccount { get; set; }
        public string partyName { get; set; }
        public string voucherNo { get; set; }
        public int isSupervised { get; set; }
        public int isDeleted { get; set; }
    }
}