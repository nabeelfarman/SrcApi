namespace InventoryModuleAPI.Entities
{
    public class AssetCreation
    {
        public int newAssetId { get; set; }
        public int memberProfileId { get; set; }
        public int assetCatId { get; set; }
        public string assetLocation { get; set; }
        public string assetDescription { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string serialNo { get; set; }
        public string chasisNo { get; set; }
        public string enGineNo { get; set; }
        public float costAmount { get; set; }
        public string purchaseDate { get; set; }
        public int isUseable { get; set; }
        public int isServiceable { get; set; }
        public int Iscondemned { get; set; }
        public int ismIssing { get; set; }
        public string assetCondition { get; set; }
        public string eDoc1 { get; set; }
        public string EdocExtension { get; set; }
        public string generation { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string driveType1 { get; set; }
        public string HD1 { get; set; }
        public string driveType2 { get; set; }
        public string HD2 { get; set; }
        public string spType { get; set; }
        public int userid { get; set; }
        public int assetNo { get; set; }
        public int qty { get; set; }
        public string Remarks { get; set; }
    }
}