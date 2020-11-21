using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ConsultantEdit
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter A First Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please Enter A Last Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [RegularExpression("Home|home|Auto|auto|Business|business|Personal|personal", ErrorMessage = "Please enter Personal, Home, Auto, or Business")]
        public string Specialization { get; set; }
        [Display(Name = "Current Employee")]
        public bool IsCurrentEmployee { get; set; }
    }
}
