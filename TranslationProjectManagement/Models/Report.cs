namespace TranslationProjectManagement.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public DateTime GeneratedOn { get; set; }
        public string ReportData { get; set; }

        // Navigation property
        public Project Project { get; set; }
    }
}
