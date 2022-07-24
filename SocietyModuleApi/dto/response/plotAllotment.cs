namespace SocietyModuleAPI.Entities
{
    public class PlotAllotment
    {
        public int plotId { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public string plotNo { get; set; }
        public string streetNo { get; set; }
        public string block { get; set; }
        public string subBlock { get; set; }
        public string plotDescription { get; set; }
        public string plotNatureTitle { get; set; }
        public string plotTypeTitle { get; set; }
        public string plotCategoryTitle { get; set; }
        public string plotNatureDescription { get; set; }
        public string plotTypeDescription { get; set; }
        public string unit { get; set; }
        public string plotSize { get; set; }
        public int isdeleted { get; set; }
    }
}