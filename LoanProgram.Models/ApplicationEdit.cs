using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicationEdit
    {
        public int Id { get; set; }
        [Display(Name = "Applicant Id")]
        [Required(ErrorMessage = "Please Select an Applicant")]
        public int ApplicantId { get; set; }
        public string Type { get; set; }
        [MaxLength(200, ErrorMessage = "Keep the number of characters 200 or fewer.")]
        public string Description { get; set; }
        public string Occupation { get; set; }
        public double Salary { get; set; }
        [Display(Name = "Move-in Date")]
        [DataType(DataType.Date)]
        public DateTime MoveInDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Preferred Consultant")]
        [Required(ErrorMessage = "Please Select a Consultant")]
        public int PreferredConsultant { get; set; }
        public List<Applicant> Applicants { get; set; }
        public Applicant Applicant { get; set; }
        public List<Consultant> Consultants { get; set; }
        public Consultant Consultant { get; set; }
    }
}
