using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Models
{
    public class ConsultantDetail
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Specialization { get; set; }
        [Display(Name = "Is Current Employee")]
        public bool IsCurrentEmployee { get; set; }
        [Display(Name = "Current Employee")]
        public string CurrentEmployee { get { return IsCurrentEmployee ? "Yes" : "No"; } }
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [Display(Name = "Time With Company")]
        public double TimeWith
        {
            get
            {
                TimeSpan time = DateTime.Now-HireDate;
                double years = Math.Floor(time.TotalDays / 365);
                return years;
            }
        }
    }
}
