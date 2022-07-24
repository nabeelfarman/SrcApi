namespace FMISModuleAPI.Entities
{
    public class BankChartOfAccount
    {
        public int coaID { get; set; }
        public string SubGroup { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string Description { get; set; }
        public int levelAvailable { get; set; }
    }
}