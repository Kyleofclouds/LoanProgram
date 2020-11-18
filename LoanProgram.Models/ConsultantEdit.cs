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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [RegularExpression("Home|home|Auto|auto|Business|business|Personal|personal", ErrorMessage = "Please enter Personal, Home, Auto, or Business")]
        public string Specialization { get; set; }
        [Display(Name = "Is Current Employee")]
        public bool IsCurrentEmployee { get; set; }
    }
}
