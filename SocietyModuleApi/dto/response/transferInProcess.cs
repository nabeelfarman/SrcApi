namespace SocietyModuleAPI.Entities
{
    public class TransferInProcess
    {
        public string fileNo { get; set; }
        public int transferId { get; set; }
        public int plotFileId { get; set; }
        public int isCompleted { get; set; }
        public int isDeleted { get; set; }
        public int plotSize { get; set; }
        public string Unit { get; set; }
        public string date { get; set; }
        public string plotNatureTitle { get; set; }
        public string plotTypeTitle { get; set; }
        public string plotCategoryTitle { get; set; }
        public string empName { get; set; }
        public string designation { get; set; }
        public int ReferenceUserId { get; set; }
        public string applicant { get; set; }
    }
}