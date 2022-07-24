namespace SocietyModuleAPI.Entities
{
    public class Transfer
    {
        public int transferId { get; set; }
        public int plotFileId { get; set; }
        public int referenceUserId { get; set; }
        public string date { get; set; }
        public string applicant { get; set; }
        public int createdBy { get; set; }
        public int isModified { get; set; }
        public string fileNo { get; set; }
        public string plotNatureTitle { get; set; }
        public string plotTypeTitle { get; set; }
        public string Unit { get; set; }
        public string plotSize { get; set; }
        public string plotCategoryTitle { get; set; }
        public int isCompleted { get; set; }
        public int isDeleted { get; set; }
    }
}