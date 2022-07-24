namespace CMISModuleAPI.Entities
{
    public class BranchCreation
    {
        public int branchId { get; set; }
        public int cityId { get; set; }
        public int companyId { get; set; }
        public string branchDescription { get; set; }
        public string branchAddress { get; set; }
        public string spType { get; set; }
        public int userId { get; set; }
        public int active { get; set; }
    }
}