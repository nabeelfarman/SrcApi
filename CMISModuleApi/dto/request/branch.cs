namespace CMISModuleAPI.Entities
{
    public class Branch
    {
        public int branchId { get; set; }
        public int companyId { get; set; }
        public int cityId { get; set; }
        public string companyName { get; set; }
        public string cityName { get; set; }
        public string companyDisplayName { get; set; }
        public string branchDescription { get; set; }
        public int active { get; set; }
    }
}