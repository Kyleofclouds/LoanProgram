using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicantListItem
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int Age { get; set; }
        public string Address { get; set; }
        [Display(Name="Marriage Status")]
        public string MarriageStatus { get; set; }
        public bool IsHeadOfHousehold { get; set; }
        [Display(Name = "Head of Household")]
        public string HeadOfHousehold { get { return IsHeadOfHousehold ? "Yes":"No"; } }
        [Display(Name = "Size of Household")]
        public int SizeOfHousehold { get; set; }
    }
}
