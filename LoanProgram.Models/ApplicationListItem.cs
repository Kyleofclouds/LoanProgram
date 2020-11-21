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
    public class ApplicationListItem
    {
        public int Id { get; set; }
        [Display(Name = "Applicant ID")]
        /*public int ApplicantId { get; set; }*/
        /*[ForeignKey(nameof(ApplicantId))]*/
        public Applicant Applicant { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public double Salary { get; set; }
        [Display(Name = "Move-in Date")]
        [DataType(DataType.Date)]
        public DateTime MoveInDate { get; set; }
        [Display(Name = "Date of Application")]
        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }
        [Display(Name = "Residency Length")]
        public double ResidencyLength { get { return Math.Floor((ApplicationDate - MoveInDate).TotalDays/365); }}
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Preferred Consultant")]
        public Consultant Consultant { get; set; }
    }
}
