using System;

namespace SocietyModuleAPI.Entities
{
    public class MemberProfileCreation
    {
        public Nullable<int> acqTypeId { get; set; }
        public Nullable<int> plotFileId { get; set; }
        public Nullable<int> newMemberProfileId { get; set; }
        public Nullable<int> paymentPlanID { get; set; }
        public string memberName { get; set; }
        public string memberType { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string Designation { get; set; }
        public Nullable<int> BPS { get; set; }
        public string memberDOB { get; set; }
        public string phoneNo1 { get; set; }
        public string phoneNo2 { get; set; }
        public string mobileNo1 { get; set; }
        public string mobileNo2 { get; set; }
        public string Email { get; set; }
        public string presendAddress { get; set; }
        public Nullable<int> presentAddresscityId { get; set; }
        public string permanentAddress { get; set; }
        public Nullable<int> permanentAddresscityId { get; set; }
        public string memberRemarks { get; set; }
        public string applicationDate { get; set; }
        public string memberShipDate { get; set; }
        public string memberShipNo { get; set; }
        public Nullable<int> Userid { get; set; }
        public string SpType { get; set; }
        public string memberPicturePath { get; set; }
        public string memberPicture { get; set; }
        public string memberPictureExtension { get; set; }
        public string applicationEDocPath { get; set; }
        public string applicationEDoc { get; set; }
        public string applicationEdocExtenstion { get; set; }
        public string nextofKin { get; set; }
    }
}