using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Need to know students name")]
        public string Name { get; set; }
        public string StudentId { get; set; }
        [Required(ErrorMessage = "Must provide a University")]
        public string University { get; set; }
        public string Course { get; set; }

    }
}
