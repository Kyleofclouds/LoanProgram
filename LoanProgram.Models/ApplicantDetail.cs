using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicantDetail
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required(ErrorMessage ="Please enter an age")]
        public int Age { get; set; }
        public string Address { get; set; }
        [Display(Name = "Marriage Status")]
        [Required(ErrorMessage = "Please enter Single, Married, or Divorced")]
        [RegularExpression("Married|married|Single|single|Divorced|divorced", ErrorMessage = "Please enter Single, Married, or Divorced")]
        public string MarriageStatus { get; set; }
        [Display(Name = "Head of Household")]
        public bool IsHeadOfHousehold { get; set; }
        [Display(Name = "Head of Household")]
        public string HeadOfHousehold { get { return IsHeadOfHousehold ? "Yes" : "No"; } }
        [Display(Name = "Size of Household")]
        [Range(1, 15, ErrorMessage = "Please enter a number between 1 & 15. If you have more than 15 members in your household, you pose too great a risk for a loan.")]
        public int SizeOfHousehold { get; set; }
        public string Photo { get; set; }
        public string AlternateText { get; } = "No Photo Selected";
    }
}
