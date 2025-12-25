using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_apps_3.Data;
using test_apps_3.Models.DomainModel;
using test_apps_3.Models.ViewModel;
using test_apps_3.Repository;

namespace test_apps_3.Controllers
{
    public class AdminStudentController : Controller
    {
        private readonly IStudentRepo _studentRepo;

        public AdminStudentController(IStudentRepo studentRepo)
        {
            this._studentRepo = studentRepo;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentRequest addStudentRequest)
        {
            var studentAdd = new StudentClass
            {
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
                session = addStudentRequest.session
            };
            _studentRepo.AddAsync(studentAdd);
            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var studentList = await _studentRepo.GetAllAsync();
            return View(studentList);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var viewForEdit = await _studentRepo.GetAsync(id);
            if (viewForEdit != null)
            {
                var editStudentRequest = new EditStudentRequest
                {
                    Id = viewForEdit.Id,
                    Name = viewForEdit.Name,
                    Email = viewForEdit.Email,
                    session = viewForEdit.session
                };
                return View(editStudentRequest);
            }
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditStudentRequest editStudentRequest)
        {
            var _studentEdit = new StudentClass
            {
                Id = editStudentRequest.Id,
                Name = editStudentRequest.Name,
                Email = editStudentRequest.Email,
                session = editStudentRequest.session
            };
            var updatedStudent = await _studentRepo.UpdateAsync(_studentEdit);
            if (updatedStudent != null)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EditStudentRequest editStudentRequest)
        {
            var deletedstudent = await _studentRepo.DeleteAsync(editStudentRequest.Id);
            if (deletedstudent != null)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }
    }
}
