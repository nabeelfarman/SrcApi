namespace SocietyModuleAPI.Entities
{
    public class PlotPayment
    {
        public int paymentNatureId { get; set; }
        public int coaID { get; set; }
        public string paymentNatureTitle { get; set; }
        public string description { get; set; }
        public int isDeleted { get; set; }
    }
}