namespace CMISModuleAPI.Entities
{
    public class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string companyDisplayName { get; set; }
        public string companyShortName { get; set; }
        public int companyTypeid { get; set; }
        public string registerationDate { get; set; }
        public string registerationNo { get; set; }
        public string ntn { get; set; }
        public string strn { get; set; }
        public string registerationDoc { get; set; }
        public string address { get; set; }
        public int countryId { get; set; }
        public int cityID { get; set; }
        public string cellno1 { get; set; }
        public string email1 { get; set; }
        public int isDeleted { get; set; }
    }
}