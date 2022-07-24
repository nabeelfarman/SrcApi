namespace SocietyModuleAPI.Entities
{
    public class PlotCategoryCreation
    {
        public int NewplotCategoryId { get; set; }
        // public int plotNatureId { get; set; }
        public string plotCategoryTitle { get; set; }
        public string Unit { get; set; }
        public int PlotSize { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}