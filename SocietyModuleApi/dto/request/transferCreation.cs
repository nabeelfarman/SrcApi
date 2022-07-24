namespace SocietyModuleAPI.Entities
{
    public class TransferCreation
    {
        public int newTransferID { get; set; }
        public int referenceDesignationid { get; set; }
        public int refernceUserid { get; set; }
        public int isCompleted { get; set; }
        public string date { get; set; }
        public int plotFileId { get; set; }
        public int userId { get; set; }
        public string spType { get; set; }
    }
}