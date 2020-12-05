using LoanProgram.Data;
using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ApplicantDropDownList
    {
        public string FullName { get; set; }
        public IEnumerable<Applicant> Applicants { get; set; } = new ApplicationDbContext().Applicants;
    }
}
