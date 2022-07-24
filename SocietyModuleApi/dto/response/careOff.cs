namespace SocietyModuleAPI.Entities
{
    public class CareOff
    {
        public int inPersonCareOfId { get; set; }
        public int inPersonId { get; set; }
        public string careOfName { get; set; }
        public string careOfSDWOfName { get; set; }
        public string careOfCNIC { get; set; }
        public string careOfphoneNo1 { get; set; }
        public string careOfmobileNo1 { get; set; }
        public string careOfEmail { get; set; }
        public string careOfpresentAddress { get; set; }
        public string careOfpresentAddressCityId { get; set; }
        public string careOfpermanentAddress { get; set; }
        public string careOfpermanentAddressCityId { get; set; }
        public string careOfpicture { get; set; }
        public string careOffingerPrint1 { get; set; }
        public int isDeleted { get; set; }
        public int memberProfileId { get; set; }
    }
}