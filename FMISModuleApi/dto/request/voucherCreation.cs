namespace FMISModuleAPI.Entities
{
    public class VoucherCreation
    {
        public int newTEmpTrnDEtailID { get; set; }
        public int partyId { get; set; }
        public int beneficiaryId { get; set; }
        public int coaId { get; set; }
        public float debit { get; set; }
        public float credit { get; set; }
        public int taxExemption { get; set; }
        public string trnDate { get; set; }
        public string remarks { get; set; }
        public int taxId { get; set; }
        public float taxRate { get; set; }
        public int userId { get; set; }
        public int trnSame { get; set; }
        public string spType { get; set; }
        public int bankId { get; set; }
        public int trnTypeId { get; set; }
        public string trnDescription { get; set; }
    }
}