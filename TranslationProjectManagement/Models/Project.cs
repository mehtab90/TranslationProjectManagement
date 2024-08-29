﻿    namespace TranslationProjectManagement.Models
    {
        public class Project
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

            // Navigation property
            public ICollection<Taks> Tasks { get; set; }
        }
    }

