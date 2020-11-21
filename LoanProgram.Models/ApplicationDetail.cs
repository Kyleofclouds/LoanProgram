using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicationDetail
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the ID of the Client for this Application")]
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        [Required]
        [RegularExpression("Home|home|Auto|auto|Business|business|Personal|personal",ErrorMessage ="Enter Home, Auto, Business, or Personal")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Enter a breif description of the loan")]
        [MaxLength(200, ErrorMessage = "Keep the number of characters 200 or fewer.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter the title of your occupation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "Enter your average yearly salary")]
        public double Salary { get; set; }
        [Required(ErrorMessage = "Enter the move-in date of your current residence")]
        [Display(Name = "Move-in Date")]
        [DataType(DataType.Date)]
        public DateTime MoveInDate { get; set; }
        [Display(Name = "Application Date")]
        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }
        [Display(Name = "Length of Residency")]
        public double ResidencyLength { get; set; }
        [Required(ErrorMessage ="Enter a phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Enter an Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Contact { get; set; }
        public int PreferredConsultant { get; set; }
        [Display(Name = "Preferred Consultant")]
        public Consultant Consultant { get; set; }
    }
}
