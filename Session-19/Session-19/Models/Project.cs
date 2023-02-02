namespace Session_19.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }

        public string ProjectVersion { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ProjectDescription { get; set; } 

        public List<Developer> developers { get; set; }


        public Project() { }
      
    }
}
