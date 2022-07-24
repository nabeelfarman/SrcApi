namespace SocietyModuleAPI.Entities
{
    public class CareOffCreation
    {
        public int newInpersonCareOfId { get; set; }
        public string memberName { get; set; }
        public string SDWofName { get; set; }
        public string memberCNIC { get; set; }
        public string phoneNo1 { get; set; }
        public string mobileNo1 { get; set; }
        public string email { get; set; }
        public string presentAddress { get; set; }
        public int presentAddresscityId { get; set; }
        public string permanentAddress { get; set; }
        public int permanentAddresscityId { get; set; }
        public string memberPicturePath { get; set; }
        public string memberPicture { get; set; }
        public string memberPictureExtension { get; set; }
        public string attorneyPath { get; set; }
        public string attorney { get; set; }
        public string attorneyExtension { get; set; }
        public string fingerPrint1 { get; set; }
        public int userid { get; set; }
        public string spType { get; set; }
    }
}