namespace SocietyModuleAPI.Entities
{
    public class PlotFilePaymentSummary
    {
        public int plotFileId { get; set; }
        public string accountTitle { get; set; }
        public string dueDate { get; set; }
        public string receiptDate { get; set; }
        public float amount { get; set; }
    }
}