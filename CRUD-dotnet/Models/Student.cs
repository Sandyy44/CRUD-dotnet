using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDdotnet.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="Name Must Not Exceed 20 Characters.")]
        [MinLength(2, ErrorMessage = "Name Must Be More Than One Character.")]
        [Display(Name="Student Name")]
        public string Name { get; set; }
        [Required]
        [Range(18, 50,ErrorMessage ="Age Must Be Between 18 and 50 Years Old.")]
        [Display(Name = "Student Age")]
        public int Age { get; set; }
        [Required]
        [Range(1,3, ErrorMessage = "Department Id Must Be Between 1 and 3.")]
        [ForeignKey("Department")]
        [Display(Name = "Department Id")]
        public virtual int DepartmentId { get; set; }
        public virtual Department? Dept { get; set; }

        public static implicit operator List<object>(Student? v)
        {
            throw new NotImplementedException();
        }
    }
}
