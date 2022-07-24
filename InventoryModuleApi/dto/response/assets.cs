namespace InventoryModuleAPI.Entities
{
    public class Assets
    {
        public int assetId { get; set; }
        public int memberProfileId { get; set; }
        public int assetCatId { get; set; }
        public string memberName { get; set; }
        public string assetLocation { get; set; }
        public string assetDescription { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string engineNo { get; set; }
        public string chasisNo { get; set; }
        public int vehicleID { get; set; }
        public string Tag { get; set; }
        public float costAmount { get; set; }
        public string purchaseDate { get; set; }
        public string assetCondition { get; set; }
        public int isUseable { get; set; }
        public int isServiceAble { get; set; }
        public int isCondemned { get; set; }
        public int isMissing { get; set; }
        public string eDoc1 { get; set; }
        public int isDeleted { get; set; }
        public string generation { get; set; }
        public string processor { get; set; }
        public string ram { get; set; }
        public string driveType1 { get; set; }
        public string HD1 { get; set; }
        public string driveType2 { get; set; }
        public string HD2 { get; set; }
        public string assetCatDescription { get; set; }
        public string assetNo { get; set; }
        public string serialNo { get; set; }
    }
}