using LabProject.Models;
using LabProject.Services.Abstract;

namespace LabProject.Services.Concrete
{
    public class AppDataContext : IAppDataContext
    {
        private readonly List<Student> _students;
        public List<Student> Students { get; }


        private readonly List<Teacher> _teachers;
        public List<Teacher> Teachers {get; }

        public AppDataContext()
        {
            _students = new List<Student>()
            {
                new Student{Name="Nicat",Surname="Azizov",Profession=Professions.Programming,Id=1,TeacherID=1},
                new Student{Name="Elnur",Surname="Qafarzada",Profession=Professions.Programming,Id=2,TeacherID=2},
                new Student{Name="Zahra",Surname="Rzazada",Profession=Professions.Design,Id=3,TeacherID=2},
                new Student{Name="Elcan",Surname="Shalanov",Profession=Professions.Game,Id=4, TeacherID = 3},
            };
            _teachers = new List<Teacher>()
            {
                new Teacher{Name="Javid",Surname="Asadov",Id=1},
                new Teacher{Name="Huseyn",Surname="Ashurlu",Id=2},
                new Teacher{Name="Hamid",Surname="Mammadov",Id=3},
            };

            Students = _students;
            Teachers = _teachers;
        }
    }
}
