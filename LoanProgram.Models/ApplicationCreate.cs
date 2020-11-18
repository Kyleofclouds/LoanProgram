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
        [Required]
        [Display(Name = "Applicant ID")]
        public int ApplicantId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Keep the number of characters 200 or fewer.")]
        public string Description { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [Display(Name = "Move-in Date")]
        public DateTime MoveInDate { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "Preferred Consultant")]
        public int PreferredConsultant { get; set; }
    }
}
