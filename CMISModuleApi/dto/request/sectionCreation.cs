namespace CMISModuleAPI.Entities
{
    public class SectionCreation
    {
        public int newsectionId { get; set; }
        public int departmentId { get; set; }
        public string sectionTitle { get; set; }
        public int active { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}