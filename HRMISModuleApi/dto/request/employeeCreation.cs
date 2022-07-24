namespace HRMISModuleAPI.Entities
{
    public class EmployeeCreation
    {
        public int newMemberProfileID { get; set; }
        public string memberType { get; set; }
        public string membername { get; set; }
        public int departmentId { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public int designationId { get; set; }
        public string phoneNO1 { get; set; }
        public string mObileNO1 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddressCityID { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddressCityId { get; set; }
        public string memberRemarks { get; set; }
        public string joiningDate { get; set; }
        public string retirementDate { get; set; }
        public string memberDOB { get; set; }
        // public string taxCategory { get; set; }
        // public string residentStatus { get; set; }
        public int isCNICDuplication { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}