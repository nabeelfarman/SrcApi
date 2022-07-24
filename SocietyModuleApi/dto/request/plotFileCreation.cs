namespace SocietyModuleAPI.Entities
{
    public class PlotFileCreation
    {
        public int newPlotFileId { get; set; }
        public int paymentPlanId { get; set; }
        public int plotTypeId { get; set; }
        public int plotNatureId { get; set; }
        public int plotCategoryId { get; set; }
        public string fileNo { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }

    }
}