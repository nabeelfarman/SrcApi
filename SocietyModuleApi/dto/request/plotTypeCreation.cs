namespace SocietyModuleAPI.Entities
{
    public class PlotTypeCreation
    {
        public int NewplotTypeId { get; set; }
        public string plotTypeTitle { get; set; }
        public string plotTypeDescription { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}