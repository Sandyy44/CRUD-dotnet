using Microsoft.AspNetCore.Mvc;
using CRUDdotnet.Models;
using CRUDdotnet.ViewModel;

namespace CRUDdotnet.Controllers
{
    public class StudentController : Controller
    {
        public StudentContext stdContext = new StudentContext();
        public StudentViewModel studentViewModel = new StudentViewModel();
        public IActionResult GetAllData ()
        {
            List<Student> students = stdContext.Students.ToList();
            studentViewModel.Students=students;
            studentViewModel.Departmets= stdContext.Departments.ToList();


            return View("AllStudents", studentViewModel);
        }
        public IActionResult ShowById(int id)
        {
            Student student = stdContext.Students.FirstOrDefault(x => x.Id == id);
            studentViewModel.std = student;
            studentViewModel.Departmets = stdContext.Departments.ToList();


            return View("StudentCard", studentViewModel);
        }

        public IActionResult DeleteById(int id)
        {
            Student student = stdContext.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                stdContext.Students.Remove(student);
                stdContext.SaveChanges();
                return RedirectToAction("GetAllData");
            }
            else
            {
                return View("Error");

            }
        }
        public IActionResult UpdateById(int id)
        {
            Student student = stdContext.Students.FirstOrDefault(x => x.Id == id);
           


            return View("UpdateForm", student);
        }
        public IActionResult Update(Student student)
        {
                Student? s = stdContext.Students.FirstOrDefault(x => x.Id == student.Id);
                s.Name = student.Name;
                s.Age = student.Age;
                s.DepartmentId = student.DepartmentId;
                stdContext.SaveChanges();
                return RedirectToAction("GetAllData");
            
        }
        public IActionResult Add()
        {
                return View("AddData");

        }
		public IActionResult AddData(Student student)
		{
            
                stdContext.Students.Add(student);
                stdContext.SaveChanges();
                return RedirectToAction("GetAllData");

            
           
		}


	}
}
