namespace DemoLezione1.Core.Interfaces;

public interface IStudentsData
{
    Task<List<Student>?> GetStudents();
}
