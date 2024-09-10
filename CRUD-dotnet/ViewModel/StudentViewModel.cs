using CRUDdotnet.Models;
namespace CRUDdotnet.ViewModel
{
    public class StudentViewModel
    {
        public List<Student> Students { get; set; }
        public List<Department> Departmets { get; set; }
        public Student std { get; set; }
        public Department dept { get; set; }

    }
}
