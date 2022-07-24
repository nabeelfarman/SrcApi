namespace SocietyModuleAPI.Entities
{
    public class PlotCategory
    {
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public string plotCategoryTitle { get; set; }
        public string plotSize { get; set; }
        public int isDeleted { get; set; }
        public string Unit { get; set; }
    }
}