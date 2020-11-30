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
        [Required(ErrorMessage ="Please Enter A First Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter A Last Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please Limit Your Characters to Letters Only")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please Enter An Age")]
        [Range(18, 125, ErrorMessage = "You are either too young or too old to apply for a loan.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter An Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Marriage Status")]
        [RegularExpression("Married|married|Single|single|Divorced|divorced", ErrorMessage = "Please enter Single, Married, or Divorced")]
        public string MarriageStatus { get; set; }
        [Display(Name = "Head of Household")]
        public bool IsHeadOfHousehold { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Please enter a number between 1 & 15. If you have more than 15 members in your household, you pose too great a risk for a loan.")]
        [Display(Name = "Size of Household")]
        public int SizeOfHousehold { get; set; }
        //public ImageSource Photo { get; set; }
        //public string AlternateText { get; } = "No Photo selected";
    }
}
