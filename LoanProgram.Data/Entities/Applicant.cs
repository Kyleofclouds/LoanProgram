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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Client")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MarriageStatus { get; set; }
        public bool IsHeadOfHousehold { get; set; }
        public int SizeOfHousehold { get; set; }
    }
}
