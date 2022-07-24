namespace FMISModuleAPI.Entities
{
    public class BankAccountCheqBook
    {
        public int bankId { get; set; }
        public string titleofAccount { get; set; }
        public int bankChequeId { get; set; }
        public string startChequeNo1 { get; set; }
        public string endChequeNo1 { get; set; }
        public string chequeIssueDate { get; set; }
        public int isDeleted { get; set; }
    }
}