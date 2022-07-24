namespace InventoryModuleAPI.Entities
{
    public class AssetCategory
    {
        public int assetCatID { get; set; }
        public int accountsCatID { get; set; }
        public string assetCatCode { get; set; }
        public string accountsCatCode { get; set; }
        public string assetCatDescription { get; set; }
        public int depreciationRuleID { get; set; }
        public string accountsCategory { get; set; }
        public string FAType { get; set; }
        public string DepreciationRuleShortName { get; set; }
        public string DepreciationRule { get; set; }
        public int IsDeleted { get; set; }

    }
}