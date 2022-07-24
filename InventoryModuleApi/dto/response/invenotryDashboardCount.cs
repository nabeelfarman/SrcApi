namespace InventoryModuleAPI.Entities
{
    public class InventoryDashboardCount
    {
        public int count { get; set; }
        public int costAmount { get; set; }
        public int assetCatID { get; set; }
        public int accountsCatID { get; set; }
        public int isDeleted { get; set; }
        public int isDisposed { get; set; }
        public string accountsCategory { get; set; }
        public string assetCatDescription { get; set; }
    }
}