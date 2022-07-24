namespace CMISModuleAPI.Entities
{
    public class PartnerCreation
    {
        public int partnerID { get; set; }
        public string partnerTitle { get; set; }
        public int companyid { get; set; }
        public int designationID { get; set; }
        public string CNICNo { get; set; }
        public string partnerAddress { get; set; }
        public int cityId { get; set; }
        public string partnerPhoneNo { get; set; }
        public string partnerCellNo { get; set; }
        public string partnerEmail { get; set; }
        public int countryid { get; set; }
        public string spType { get; set; }
        public int userID { get; set; }
    }
}