namespace FMISModuleAPI.Entities
{
    public class BankAccountCheqBookCheqNo
    {
        public int bankChequeDetailId { get; set; }
        public string chequeNo1 { get; set; }
        public int bankChequeId { get; set; }
        public int bankId { get; set; }
        public string titleofAccount { get; set; }
        public float Amount { get; set; }
        public string chequeDate { get; set; }
        public int postStatus { get; set; }
    }
}