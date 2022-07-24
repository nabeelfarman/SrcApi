namespace FMISModuleAPI.Entities
{
    public class ChartOfAccountCreation
    {
        public int subgroupId { get; set; }
        public int budgetSubcodeId { get; set; }
        public int level1 { get; set; }
        public int level2 { get; set; }
        public int level3 { get; set; }
        public int level4 { get; set; }
        public int level5 { get; set; }
        public string AccountCode { get; set; }
        public string AccounTitle { get; set; }
        public string description { get; set; }
        public int levelavailable { get; set; }
        public int WhichLevel { get; set; }
        public string forMemberReceipt { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
        public int newCoaID { get; set; }
    }
}