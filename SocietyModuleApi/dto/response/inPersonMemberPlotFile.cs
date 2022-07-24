namespace SocietyModuleAPI.Entities
{
    public class InPersonMemberPlotFile
    {
        public int plotFileId { get; set; }
        public string fileNo { get; set; }
        public int transferId { get; set; }
        public int isDeleted { get; set; }
        public int isCompleted { get; set; }
    }
}