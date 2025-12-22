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
            var studentAdd = new Student
            {
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
                session = addStudentRequest.session
            };
            _appsDbContext._Students.Add(studentAdd);
            _appsDbContext.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var studentList = _appsDbContext._Students.ToList();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var studentEdit = _appsDbContext._Students.FirstOrDefault(x=>x.Id==id);
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
            var _studentEdit = new Student
            {
                Id = editStudentRequest.Id,
                Name = editStudentRequest.Name,
                Email = editStudentRequest.Email,
                session = editStudentRequest.session
            };
            var existingStudent = _appsDbContext._Students.Find(editStudentRequest.Id);
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
            var studentDelete = _appsDbContext._Students.Find(id);
            if (studentDelete != null)
            {
                _appsDbContext._Students.Remove(studentDelete);
                _appsDbContext.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
