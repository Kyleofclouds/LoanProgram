using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicationListItem
    {
        public int Id { get; set; }
        [Display(Name = "Applicant ID")]
        public int ApplicantId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }
        [Display(Name = "Move-in Date")]
        public DateTime MoveInDate { get; set; }
        [Display(Name = "Date of Application")]
        public DateTime ApplicationDate { get; set; }
        [Display(Name = "Residency Length")]
        public double ResidencyLength { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Preferred Consultant")]
        public int PreferredConsultant { get; set; }
    }
}
