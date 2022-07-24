namespace SocietyModuleAPI.Entities
{
    public class AllBank
    {
        public int bankId { get; set; }
        public int coaId { get; set; }
        public string titleofAccount { get; set; }
        public string accountNo { get; set; }
        public string branchCode { get; set; }
        public string openingDate { get; set; }
        public string nameofBank { get; set; }
        public string bankAddress { get; set; }
        public float openingBalance { get; set; }
        public int isDeleted { get; set; }
        public int isActivated { get; set; }
    }
}