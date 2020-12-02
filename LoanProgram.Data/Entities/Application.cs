using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Data.Entities
{
    //public enum ContactMethod { Phone, Email}
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public Guid CreatedBy { get; set; }
        [Required]
        public int ApplicantId { get; set; }
        [ForeignKey(nameof(ApplicantId))]
        public virtual Applicant Applicant { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public DateTime MoveInDate { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public double ResidencyLength { get
            {
                 return Math.Floor((ApplicationDate - MoveInDate).TotalDays/365);
            } }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public int PreferredConsultant { get; set; }
        [ForeignKey(nameof(PreferredConsultant))]
        public virtual Consultant Consultant { get; set; }
    }
}
