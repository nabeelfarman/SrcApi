namespace FMISModuleAPI.Entities
{
    public class BankCreation
    {
        public int coaID { get; set; }
        public int bankTypeID { get; set; }
        public int bankNameID { get; set; }
        public string titleofAccount { get; set; }
        public string description { get; set; }
        public string accountNo { get; set; }
        public string branchCode { get; set; }
        public string branchName { get; set; }
        public string openingDate { get; set; }
        public string bankAddress { get; set; }
        public float openingBalance { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
        public int newBankId { get; set; }
    }
}