namespace SocietyModuleAPI.Entities
{
    public class PlotsCreation
    {
        public int NewplotID { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public string streetNo { get; set; }
        public string plotNo { get; set; }
        public string block { get; set; }
        public string SpType { get; set; }
        public int userId { get; set; }
    }
}