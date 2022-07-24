namespace SocietyModuleAPI.Entities
{
    public class PaymentPlanCreation
    {
        public int newPaymentplanId { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public string paymentPlanTitle { get; set; }
        public string paymentPlanDescription { get; set; }
        public string paymentPlanDate { get; set; }
        public int Userid { get; set; }
        public string spType { get; set; }
    }
}