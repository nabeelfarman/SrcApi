namespace LandModuleAPI.Entities
{
    public class LandPlot
    {
        public int plotId { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public string plotNo { get; set; }
        public string streetNo { get; set; }
        public string subBlock { get; set; }
        public string PlotDescription { get; set; }
        public string plotNatureTitle { get; set; }
        public string plotTypeTitle { get; set; }
        public string plotTypeDescription { get; set; }
        public string PlotNatureDescription { get; set; }
        public string plotCategoryTitle { get; set; }
        public string Unit { get; set; }
        public float plotSize { get; set; }
        public int isAlloted { get; set; }
        public int isPossession { get; set; }
        public int isUnderConstruction { get; set; }
        public int isStructure { get; set; }
        public string block { get; set; }
        public int Isdeleted { get; set; }
    }
}