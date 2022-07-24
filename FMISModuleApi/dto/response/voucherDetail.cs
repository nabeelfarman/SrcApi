namespace FMISModuleAPI.Entities
{
    public class VoucherDetail
    {
        public int trnId { get; set; }
        public string voucherNo { get; set; }
        public string accountCode { get; set; }
        public string accountTitle { get; set; }
        public string trnDate { get; set; }
        public string chequeNo { get; set; }
        public string chequeDate { get; set; }
        public string trnDescription { get; set; }
        public float credit { get; set; }
        public float debit { get; set; }
        public string beneficiary { get; set; }
        public string party { get; set; }
        public int trnTypeId { get; set; }
        public string trnType { get; set; }
    }
}