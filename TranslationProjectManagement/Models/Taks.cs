
namespace TranslationProjectManagement.Models
{
    public class Taks
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }

        // Navigation property
        public Project Project { get; set; }
    }
}
