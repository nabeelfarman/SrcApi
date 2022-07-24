namespace SocietyModuleAPI.Entities
{
    public class PaymentNature
    {
        public int paymentNatureID { get; set; }
        public int coaID { get; set; }
        public string paymentNatureTitle { get; set; }
        public int isDeleted { get; set; }

    }
}