namespace CMISModuleAPI.Entities
{
    public class CompanyCreation
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string displayName { get; set; }
        public string shortName { get; set; }
        public int companyTypeid { get; set; }
        public string registrationDate { get; set; }
        public string registrationNo { get; set; }
        public string ntn { get; set; }
        public string strn { get; set; }
        public string registrationDoc { get; set; }
        public string path { get; set; }
        public string address { get; set; }
        public string phoneno1 { get; set; }
        public int cityID { get; set; }
        public string cellno1 { get; set; }
        public string email1 { get; set; }
        public string spType { get; set; }
        public int userID { get; set; }
    }
}