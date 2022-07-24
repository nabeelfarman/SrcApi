namespace LandModuleAPI.Entities
{
    public class SocietyBlockCreation
    {
        public int newSocietyBlockId { get; set; }
        public string block { get; set; }
        public string description { get; set; }
        public string societyPhaseId { get; set; }
        public string spType { get; set; }
        public int userId { get; set; }
    }
}