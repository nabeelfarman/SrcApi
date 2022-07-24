namespace CMISModuleAPI.Entities
{
    public class Section
    {
        public int sectionId { get; set; }
        public int departmentId { get; set; }
        public string sectionTitle { get; set; }
        public string departmentName { get; set; }
        public int active { get; set; }
    }
}