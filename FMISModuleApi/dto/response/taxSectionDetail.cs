namespace FMISModuleAPI.Entities
{
    public class TaxSectionDetail
    {
        public int taxDetailId { get; set; }
        public int taxId { get; set; }
        public string PartyType { get; set; }
        public string finYear { get; set; }
        public string effectFrom { get; set; }
        public string effectTo { get; set; }
        public float filerTaxRate { get; set; }
        public float nonFilerRate { get; set; }
        public string irisCode { get; set; }
        public string taxNature { get; set; }
        public string taxSection { get; set; }
        public string taxDescription { get; set; }
        public int isActivated { get; set; }
    }
}