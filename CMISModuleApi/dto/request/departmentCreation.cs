namespace CMISModuleAPI.Entities
{
    public class DepartmentCreation
    {
        public int newdepartmentId { get; set; }
        public string departmentName { get; set; }
        public string departmentDescription { get; set; }
        public int active { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}