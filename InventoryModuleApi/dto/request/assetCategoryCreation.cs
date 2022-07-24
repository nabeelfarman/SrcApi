namespace InventoryModuleAPI.Entities
{
    public class AssetCategoryCreation
    {
        public int newAssetCatID { get; set; }
        public int accountsCatID { get; set; }
        public string assetCatCode { get; set; }
        public string assetCatDescription { get; set; }
        public int depreciationRuleId { get; set; }
        public float BaseRate { get; set; }
        public string edoc { get; set; }
        public string eDocExtension { get; set; }
        public string spType { get; set; }
        public int userid { get; set; }

    }
}