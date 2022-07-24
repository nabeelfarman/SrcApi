namespace SocietyModuleAPI.Entities
{
    public class PaymentPlanDetail
    {
        public int paymentPlanDetailId { get; set; }
        public float amount { get; set; }
        public string dueDate { get; set; }
        public int paymentNatureID { get; set; }
        public int paymentPlanID { get; set; }
        public int installmentID { get; set; }
        public int coaID { get; set; }
        public string paymentNatureTitle { get; set; }
        public string installmentTitle { get; set; }
        public int isDeleted { get; set; }
        public bool editMode { get; set; }

    }
}