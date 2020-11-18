using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicantEdit
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        [Display(Name = "Marriage Status")]
        [RegularExpression("Married|married|Single|single|Divorced|divorced", ErrorMessage = "Please enter Single, Married, or Divorced")]
        public string MarriageStatus { get; set; }
        [Display(Name = "Head of Household")]
        public bool HeadOfHousehold { get; set; }
        [Display(Name = "Size of Household")]
        [Range(1, 15, ErrorMessage = "Please enter a number between 1 & 15. If you have more than 15 members in your household, you pose too great a risk for a loan.")]
        public int SizeOfHousehold { get; set; }
    }
}
