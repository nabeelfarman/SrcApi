namespace SocietyModuleAPI.Entities
{
    public class PaymentPlanDetailCreation
    {
        public int paymentPlanId { get; set; }
        public int installmentId { get; set; }
        public int paymentNatureId { get; set; }
        public int newPaymentplanDetailID { get; set; }
        public string duedate { get; set; }
        public float amount { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}