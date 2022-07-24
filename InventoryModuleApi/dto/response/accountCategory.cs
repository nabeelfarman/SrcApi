namespace InventoryModuleAPI.Entities
{
    public class AccountCategory
    {
        public int accountsCatID { get; set; }
        public string accountsCatCode { get; set; }
        public string chartofAccount { get; set; }
        public int FATypeID { get; set; }
        public int depreciationRuleID { get; set; }
        public float baseRate { get; set; }
        public string accountsCategory { get; set; }
        public string accountsCategoryDisplay { get; set; }
        public string FAType { get; set; }
        public string depreciationRuleShortName { get; set; }
        public string depreciationRule { get; set; }

    }
}