namespace SocietyModuleAPI.Entities
{
    public class CheckListCreation
    {
        public int newCheckListId { get; set; }
        public int designationId { get; set; }
        public string isExempted { get; set; }
        public string isFileRequired { get; set; }
        public string checkListTitle { get; set; }
        public string checkListType { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}