using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Data.Entities
{
    public enum LoanType { Personal, Home, Auto, Business }
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public LoanType Type { get; set; }
        [Required]
        public string ApplicantFullName { get; set; }
        [ForeignKey(nameof(ApplicantFullName))]
        public virtual Applicant Applicant { get; set; }
        [Required]
        public string ConsultantFullName { get; set; }
        [ForeignKey(nameof(ConsultantFullName))]
        public virtual Consultant Consultant { get; set; }
        [Required]
        public double Amount { get; set; }
    }
}
