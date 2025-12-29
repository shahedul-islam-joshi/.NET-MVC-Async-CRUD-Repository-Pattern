using Microsoft.EntityFrameworkCore;
using test_apps_3.Data;
using test_apps_3.Models.DomainModel;

namespace test_apps_3.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppsDbContext _appsDbContext;

        public StudentRepo(AppsDbContext appsDbContext)
        {
            this._appsDbContext = appsDbContext;
        }
        public async Task<StudentClass> AddAsync(StudentClass studentClass)
        {
            await _appsDbContext._StudentsTable.AddAsync(studentClass);
            await _appsDbContext.SaveChangesAsync();
            return studentClass;
        }

        public async Task<StudentClass?> DeleteAsync(int id)
        {
            var existingStudent = await _appsDbContext._StudentsTable.FindAsync(id);
            if (existingStudent != null)
            {
                _appsDbContext._StudentsTable.Remove(existingStudent);
                await _appsDbContext.SaveChangesAsync();
                return existingStudent;
            }
            return null;
        }

        public async Task<IEnumerable<StudentClass>> GetAllAsync()
        {
            return await _appsDbContext._StudentsTable.ToListAsync();
        }

        public async Task<StudentClass?> GetAsync(int id)
        {
            return await _appsDbContext._StudentsTable.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StudentClass?> UpdateAsync(StudentClass studentClass)
        {
            var _existingStudent = await _appsDbContext._StudentsTable.FindAsync(studentClass.Id);
            if (_existingStudent != null)
            {
                _existingStudent.Id = studentClass.Id;
                _existingStudent.Name = studentClass.Name;
                _existingStudent.Email = studentClass.Email;
                _existingStudent.session = studentClass.session;
                _existingStudent.Address = studentClass.Address;
                _existingStudent.Gender = studentClass.Gender;
                _existingStudent.Date = studentClass.Date;
                _existingStudent.ProfilePicture = studentClass.ProfilePicture;

                await _appsDbContext.SaveChangesAsync();
                return _existingStudent;
            }
            ;
            return null;
        }
    }
}