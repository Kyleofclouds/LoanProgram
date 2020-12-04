using LoanProgram.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanProgram.Models
{
    public class ApplicantDropdownView
    {
        public IEnumerable<Applicant> ApplicantList { get; set; }
        public string SelectedApplicant { get; set; }
    }
}