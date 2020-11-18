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
        [Display(Name = "Applicant Id")]
        public int ApplicantId { get; set; }
        public string Type { get; set; }
        [MaxLength(200, ErrorMessage = "Keep the number of characters 200 or fewer.")]
        public string Description { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }
        [Display(Name = "Move-in Date")]
        public DateTime MoveInDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Preferred Consultant")]
        public int PreferredConsultant { get; set; }
    }
}
