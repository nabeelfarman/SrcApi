namespace FMISModuleAPI.Entities
{
    public class Vouchers
    {
        public int temptrnDetailId { get; set; }
        public int coaId { get; set; }
        public int partyId { get; set; }
        public float debit { get; set; }
        public float credit { get; set; }
        public int userId { get; set; }
        public int taxID { get; set; }
        public int bUdgetSubCodeid { get; set; }
        public string createdDateTime { get; set; }
        public string remarks { get; set; }
        public string accountCode { get; set; }
        public string accountTitle { get; set; }
    }
}