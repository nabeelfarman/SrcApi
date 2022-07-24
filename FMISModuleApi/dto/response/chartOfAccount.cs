namespace FMISModuleAPI.Entities
{
    public class ChartOfAccount
    {
        public int coaID { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string Description { get; set; }
        public int levelAvailable { get; set; }
        public string SubGroup { get; set; }
        public string budgetSubHead { get; set; }
        public int budgetSubCode { get; set; }
        public int budgetSubCodeId { get; set; }
        public int formemberReceipt { get; set; }
        public int Note { get; set; }
        public int SubGroupID { get; set; }
        public string MainGroup { get; set; }
        public int COATypeID { get; set; }
        public string COAType { get; set; }
        public int Level1 { get; set; }
        public int Level2 { get; set; }
        public int Level3 { get; set; }
        public int Level4 { get; set; }
        public int Level5 { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
    }
}