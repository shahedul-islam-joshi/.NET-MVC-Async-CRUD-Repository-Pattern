using System.Collections;
using test_apps_3.Models.DomainModel;

namespace test_apps_3.Repository
{
    public interface IStudentRepo
    {
        Task<IEnumerable<StudentClass>> GetAllAsync();
        Task<StudentClass?>GetAsync(int id);
        Task<StudentClass>AddAsync(StudentClass studentClass); 
        Task<StudentClass>UpdateAsync(StudentClass studentClass);
        Task<StudentClass>DeleteAsync(int id);
    }
}
