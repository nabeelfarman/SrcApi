namespace SocietyModuleAPI.Entities
{
    public class ChartofAccount
    {
        public string AccountCode { get; set; }
        public int coaID { get; set; }
        public string AccountTitle { get; set; }
        public int levelAvailable { get; set; }
        public int formemberReceipt { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
    }
}