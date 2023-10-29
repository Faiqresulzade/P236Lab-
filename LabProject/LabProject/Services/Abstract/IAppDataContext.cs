using LabProject.Models;

namespace LabProject.Services.Abstract
{
    public interface IAppDataContext
    {
        List<Student> Students { get; }
        List<Teacher> Teachers { get; }

    }
}
