using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Data.Entities
{
    public class Consultant
    {
        [Key]
        public int Id { get; set; }
        public Guid CreatedBy { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Consultant")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required]
        public string Specialization { get; set; }
        public bool IsCurrentEmployee { get; set; } = true;
        [DataType(DataType.Date)]
        [Required]
        public DateTime HireDate { get; set; }
        public double TimeWith { get
            { 
                TimeSpan time = HireDate - DateTime.Now;
                double years = Math.Floor(time.TotalDays / 365);
                return years;
            } }
    }
}
