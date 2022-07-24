namespace SocietyModuleAPI.Entities
{
    public class ProceedChecklistCreation
    {
        public int newProcessedChecklistId { get; set; }
        public int? checklistid { get; set; }
        public int? transferId { get; set; }
        public int? referenceUserId { get; set; }
        public string checkListRemarks { get; set; }
        public int? isChecked { get; set; }
        public int? isFileRequired { get; set; }
        public int? isExempted { get; set; }
        public int? exempted { get; set; }
        public int? userId { get; set; }
        public string spType { get; set; }
        public string filePath { get; set; }
        public string fileEdoc { get; set; }
        public string fileEdocExtension { get; set; }
    }
}