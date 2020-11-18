using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Data.Entities
{
    //public enum Status { Single, Married, Divorced }
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        public Guid CreatedBy { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required]
        [Range(18, 125, ErrorMessage ="You are either too young or too old to apply for a loan.")]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string MarriageStatus { get; set; }
        [Required]
        public bool HeadOfHousehold { get; set; }
        [Required]
        [Range(1,15,ErrorMessage ="Please enter a number between 1 & 15. If you have more than 15 members in your household, you pose too great a risk for a loan.")]
        public int SizeOfHousehold { get; set; }
    }
}
