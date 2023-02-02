namespace Session_19.Models
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int YearsOfExperience { get; set; }

        public List<Project> projects { get; set; }


        // def ctor 
        public Developer() { }

    }
}
