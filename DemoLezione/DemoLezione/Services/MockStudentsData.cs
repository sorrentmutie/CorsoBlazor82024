using DemoLezione1.Core;
using DemoLezione1.Core.Interfaces;

namespace DemoLezione.Client.Services;

public class MockStudentsData : IStudentsData
{
    public async Task<List<Student>?> GetStudents()
    {
        await Task.Delay(5000);
        return new List<Student>() { 
         new Student { Id = 1, Name = "Mario Rossi", Email = "mario.rossi@gmail.com" },
         new Student { Id = 2, Name = "Luca Bianchi", Email = "luca.bianchi@gmail.com"}
        };
    }
}
