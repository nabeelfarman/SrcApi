namespace SocietyModuleAPI.Entities
{
    public class PaymentPlan
    {
        public int paymentPlanID { get; set; }
        public string paymentPlanDate { get; set; }
        public string unit { get; set; }
        public int plotSize { get; set; }
        public string plotCategoryTitle { get; set; }
        public string paymentPlanTitle { get; set; }
        public string paymentPlanDescription { get; set; }
        public string plotNatureTitle { get; set; }
        public int plotNatureID { get; set; }
        public int plotCategoryID { get; set; }
        public int plotTypeID { get; set; }
        public string plotTypeTitle { get; set; }
        public int isDeleted { get; set; }

    }
}