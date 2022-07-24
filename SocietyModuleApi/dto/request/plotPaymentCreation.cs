namespace SocietyModuleAPI.Entities
{
    public class PlotPaymentCreation
    {
        public int NewpaymentnatureId { get; set; }
        public int coaID { get; set; }
        public string PaymentnatureTitle { get; set; }
        public string description { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}