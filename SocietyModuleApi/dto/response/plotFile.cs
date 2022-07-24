namespace SocietyModuleAPI.Entities
{
    public class PlotFile
    {
        public int PlotFileId { get; set; }
        public int plotCategoryId { get; set; }
        public int plotTypeId { get; set; }
        public int plotNatureId { get; set; }
        public int paymentPlanId { get; set; }
        public string fileNo { get; set; }
        public int isDeleted { get; set; }
        public string plotTypeTitle { get; set; }
        public string unit { get; set; }
        public string plotSize { get; set; }
        public string plotNatureTitle { get; set; }
        public string plotCategoryTitle { get; set; }

    }
}