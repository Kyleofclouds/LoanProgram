using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicationDetail
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }
        [Display(Name = "Move-in Date")]
        public DateTime MoveInDate { get; set; }
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }
        [Display(Name = "Length of Residency")]
        public double ResidencyLength { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Contact { get; set; }
        public int PreferredConsultant { get; set; }
        [Display(Name = "Preferred Consultant")]
        public Consultant Consultant { get; set; }
    }
}
