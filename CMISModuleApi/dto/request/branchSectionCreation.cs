namespace CMISModuleAPI.Entities
{
    public class BranchSectionCreation
    {
        public int newbranchSectionId { get; set; }
        public int branchId { get; set; }
        public int SectionId { get; set; }
        public string sectionPhoneNo1 { get; set; }
        public string sectionPhoneNo2 { get; set; }
        public string sectionEmail1 { get; set; }
        public string sectionEmail2 { get; set; }
        public string spType { get; set; }
        public int userId { get; set; }
        public int active { get; set; }
    }
}