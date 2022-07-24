namespace FMISModuleAPI.Entities
{
    public class TaxSection
    {
        public int taxId { get; set; }
        public string taxNature { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string taxSection { get; set; }
        public int taxCoaId { get; set; }
        public string taxDescription { get; set; }
        public string EffectFrom { get; set; }
        public float FilerTaxRate { get; set; }
        public float NonFilerRate { get; set; }
        public int IRISCode { get; set; }
    }
}