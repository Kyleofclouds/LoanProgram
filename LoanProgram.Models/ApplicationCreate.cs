using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicationCreate
    {
        [Required(ErrorMessage = "Plese enter an Id")]
        [Display(Name = "Applicant ID")]
        public int ApplicantId { get; set; }
        [Required]
        [RegularExpression("Personal|personal|Home|home|Auto|auto|Business|business", ErrorMessage = "Please enter Personal, Home, Auto, or Business")]
        public string Type { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Keep the number of characters 200 or fewer.")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please Enter Your Occupation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage ="Please Enter Your Yearly Salary")]
        public double Salary { get; set; }
        [Required]
        [Display(Name = "Move-in Date")]
        [DataType(DataType.Date)]
        public DateTime MoveInDate { get; set; }
        [Required(ErrorMessage ="Enter Your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Enter Your Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter Your Preferred Contact Method")]
        [RegularExpression("Phone|phone|Email|email",ErrorMessage = "Please enter \"Phone\" or \"Email\"")]
        public string Contact { get; set; }
        [Required(ErrorMessage ="Please Select a Consultant")]
        [Display(Name = "Preferred Consultant")]
        public int PreferredConsultant { get; set; }
    }
}
