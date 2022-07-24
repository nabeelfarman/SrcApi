namespace SocietyModuleAPI.Entities
{
    public class ProcessCheckList
    {
        public int processedChecklistId { get; set; }
        public int checkListId { get; set; }
        public int referenceUserID { get; set; }
        public int isChecked { get; set; }
        public int isFileRequired { get; set; }
        public string checkListType { get; set; }
        public string checkListTitle { get; set; }
        public string fileEdoc { get; set; }
        public int isExempted { get; set; }
        public string checkListRemarks { get; set; }
        public int referenceDesignation_id { get; set; }
        public int TransferId { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
    }
}