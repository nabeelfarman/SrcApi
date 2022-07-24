namespace HRMISModuleAPI.Entities
{
    public class Employee
    {
        public int memberProfileId { get; set; }
        public string memberType { get; set; }
        public string memberName { get; set; }
        public string organization { get; set; }
        public string memberCNIC { get; set; }
        public int presentAddresscityId { get; set; }
        public string memberRemarks { get; set; }
        public int IsDeleted { get; set; }
        public int isActivated { get; set; }
        public int inPersonId { get; set; }
        public string taxCategory { get; set; }
        public string filerNonfilerStatus { get; set; }
        public string NTN { get; set; }
        public string ResidentStatus { get; set; }
        public string presentAddress { get; set; }
        public string applicationDate { get; set; }
        public string phoneNo1 { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public int designationID { get; set; }
        public int BPS { get; set; }
        public string designationName { get; set; }
        public string SDWofName { get; set; }
        public string memberDOB { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddresscityId { get; set; }
        public string joiningDate { get; set; }
        public string retirementDate { get; set; }
    }
}