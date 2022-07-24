namespace FMISModuleAPI.Entities
{
    public class BankAccount
    {
        public int bankId { get; set; }
        public int coaId { get; set; }
        public string titleofAccount { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string accountNo { get; set; }
        public int branchCode { get; set; }
        public string openingDate { get; set; }
        public string BankName { get; set; }
        public string bankAddress { get; set; }
        public float openingBalance { get; set; }
        public int BankTypeId { get; set; }
        public string BankType { get; set; }
        public string branchName { get; set; }
        public int bankNameId { get; set; }
        public string description { get; set; }
        public int isActivated { get; set; }
    }
}