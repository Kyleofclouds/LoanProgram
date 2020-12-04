using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ConsultantCreate
    {
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        public string LastName { get; set; }
        //public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required]
        [RegularExpression("Personal|personal|Home|home|Auto|auto|Business|business", ErrorMessage = "Please enter Personal, Home, Auto, or Business")]
        public string Specialization { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
