namespace CRUDdotnet.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student>? Stds { get; set; }

    }
}
