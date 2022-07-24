namespace FMISModuleAPI.Entities
{
    public class UnpaidTransaction
    {
        public int trnTypeId { get; set; }
        public int trnId { get; set; }
        public string trnDate { get; set; }
        public string trnDescription { get; set; }
        public string chequeNo { get; set; }
        public string ChequeDate { get; set; }
        public int bankId { get; set; }
        public float Amount { get; set; }
        public string Beneficiary { get; set; }
        public string trnType { get; set; }
        public string titleofAccount { get; set; }
        public string PartyName { get; set; }
        public string VoucherNo { get; set; }
        public int isSupervised { get; set; }
        public int isDeleted { get; set; }
    }
}