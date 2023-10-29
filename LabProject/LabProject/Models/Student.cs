namespace LabProject.Models
{
    public class Student:BaseHuman
    {
        public Professions Profession { get; set; }
        public int TeacherID { get; set; }
    }

    public enum Professions
    {
        Programming,
        Game,
        Design,
    }
}
