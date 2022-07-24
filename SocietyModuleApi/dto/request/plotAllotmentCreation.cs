namespace SocietyModuleAPI.Entities
{
    public class PlotAllotmentCreation
    {
        public int newplotID { get; set; }
        public int plotFileId { get; set; }
        public string streetNo { get; set; }
        public string plotNo { get; set; }
        public string block { get; set; }
        public string spType { get; set; }
        public int userId { get; set; }
    }
}