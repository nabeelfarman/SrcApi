namespace CMISModuleAPI.Entities
{
    public class BranchSection
    {
        public int branchId { get; set; }
        public int sectionId { get; set; }
        public string sectionTitle { get; set; }
        public string branchDescription { get; set; }
        public string sectionPhoneNo1 { get; set; }
        public string sectionPhoneNo2 { get; set; }
        public string sectionEmail1 { get; set; }
        public string sectionEmail2 { get; set; }
        public int active { get; set; }
    }
}