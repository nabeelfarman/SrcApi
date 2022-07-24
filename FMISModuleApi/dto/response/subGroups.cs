namespace FMISModuleAPI.Entities
{
    public class SubGroups
    {
        public int SubGroupID { get; set; }
        public int MainGroupID { get; set; }
        public string SubGroup { get; set; }
        public int FSID { get; set; }
        public int COATypeID { get; set; }
        public int Note { get; set; }
        public string MainGroup { get; set; }
        public string COAType { get; set; }
        public string FS { get; set; }
        public int isDeleted { get; set; }
    }
}