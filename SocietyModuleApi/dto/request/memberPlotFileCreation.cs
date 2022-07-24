namespace SocietyModuleAPI.Entities
{
    public class MemberPlotFileCreation
    {
        public int newMemberProfileId { get; set; }
        public int newMemberfileGroupID { get; set; }
        public int paymentPlanId { get; set; }
        public string applicationEDocPath { get; set; }
        public string applicationEDoc { get; set; }
        public string applicationEdocExtenstion { get; set; }
        public string Date { get; set; }
        public int acqTypeID { get; set; }
        public int plotFileId { get; set; }
        public int Userid { get; set; }
        public string spType { get; set; }
    }
}