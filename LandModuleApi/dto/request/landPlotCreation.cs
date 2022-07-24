namespace LandModuleAPI.Entities
{
    public class LandPlotCreation
    {
        public int newplotID { get; set; }
        public int plotCategoryId { get; set; }
        public int plotNatureId { get; set; }
        public int plotTypeId { get; set; }
        public int plotFileId { get; set; }
        public int societyBlockId { get; set; }
        public string streetNo { get; set; }
        public string plotNo { get; set; }
        public string block { get; set; }
        public string subBlock { get; set; }
        public int? isAlloted { get; set; }
        public int? isPossession { get; set; }
        public int? isUnderconstruction { get; set; }
        public int? isStructured { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}