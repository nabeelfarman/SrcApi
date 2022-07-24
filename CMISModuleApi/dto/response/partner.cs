namespace CMISModuleAPI.Entities
{
    public class Partner
    {
        public int partnerId { get; set; }
        public string partnerTitle { get; set; }
        public int companyId { get; set; }
        public int designationId { get; set; }
        public string cnicNo { get; set; }
        public string partnerAddress { get; set; }
        public int cityId { get; set; }
        public string partnerCellNo { get; set; }
        public string partnerEmail { get; set; }
        public int countryId { get; set; }
        public int isDeleted { get; set; }
    }
}