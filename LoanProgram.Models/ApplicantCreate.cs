using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicantCreate
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(18, 125, ErrorMessage = "You are either too young or too old to apply for a loan.")]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Marriage Status")]
        [RegularExpression("Married|married|Single|single|Divorced|divorced", ErrorMessage = "Please enter Single, Married, or Divorced")]
        public string MarriageStatus { get; set; }
        [Required]
        [Display(Name = "Head of Household")]
        public bool HeadOfHousehold { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Please enter a number between 1 & 15. If you have more than 15 members in your household, you pose too great a risk for a loan.")]
        [Display(Name = "Size of Household")]
        public int SizeOfHousehold { get; set; }
    }
}
