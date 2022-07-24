namespace FMISModuleAPI.Entities
{
    public class BudgetEstimate
    {
        public int BudgetMainCodeId { get; set; }
        public int BudgetMainCode { get; set; }
        public string BudgetMainHead { get; set; }
        public int budgetsubCodeId { get; set; }
        public int budgetSubCode { get; set; }
        public string budgetSubHead { get; set; }
        public string finYEar { get; set; }
        public int budgetId { get; set; }
        public float Amount { get; set; }
        public float revisedAmount { get; set; }
        public int isRevised { get; set; }
        public string RevisedDate { get; set; }
    }
}