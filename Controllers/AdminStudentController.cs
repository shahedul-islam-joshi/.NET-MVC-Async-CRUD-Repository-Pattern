using Microsoft.AspNetCore.Mvc;
using test_apps_3.Data;
using test_apps_3.Models.DomainModel;
using test_apps_3.Models.ViewModel;

namespace test_apps_3.Controllers
{
    public class AdminStudentController : Controller
    {
        private readonly AppsDbContext _appsDbContext;

        public AdminStudentController(AppsDbContext appsDbContext)
        {
            this._appsDbContext = appsDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddStudentRequest addStudentRequest)
        {
            var studentAdd = new StudentClass
            {
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
                session = addStudentRequest.session
            };
            _appsDbContext._StudentsTable.Add(studentAdd);
            _appsDbContext.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var studentList = _appsDbContext._StudentsTable.ToList();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var studentEdit = _appsDbContext._StudentsTable.FirstOrDefault(x=>x.Id==id);
            if (studentEdit != null)
            {
                var editStudentRequest = new EditStudentRequest
                {
                    Id = studentEdit.Id,
                    Name = studentEdit.Name,
                    Email = studentEdit.Email,
                    session = studentEdit.session
                };
                return View(editStudentRequest);
            }
            return View(null);
        }

        [HttpPost]
        public IActionResult Edit(EditStudentRequest editStudentRequest)
        {
            var _studentEdit = new StudentClass
            {
                Id = editStudentRequest.Id,
                Name = editStudentRequest.Name,
                Email = editStudentRequest.Email,
                session = editStudentRequest.session
            };
            var existingStudent = _appsDbContext._StudentsTable.Find(editStudentRequest.Id);
            if (existingStudent != null)
            {
                {
                    existingStudent.Name = editStudentRequest.Name;
                    existingStudent.Email = editStudentRequest.Email;
                    existingStudent.session = editStudentRequest.session;
                }
                _appsDbContext.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var studentDelete = _appsDbContext._StudentsTable.Find(id);
            if (studentDelete != null)
            {
                _appsDbContext._StudentsTable.Remove(studentDelete);
                _appsDbContext.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
