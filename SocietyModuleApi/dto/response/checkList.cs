namespace SocietyModuleAPI.Entities
{
    public class CheckList
    {
        public int checklistId { get; set; }
        public string checkListType { get; set; }
        public string checkListTitle { get; set; }
        public bool isFileRequired { get; set; }
        public bool isExempted { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
        public int designation_Id { get; set; }
        public string designationName { get; set; }
    }
}