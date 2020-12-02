using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        [Display(Name = "Client")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string MarriageStatus { get; set; }
        public bool IsHeadOfHousehold { get; set; }
        [Required]
        public int SizeOfHousehold { get; set; }
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
        public string Apps()
        {
            string list = "";
            foreach (var x in Applications)
            {
                if (x.Applicant.Id == Id)
                {
                    list = string.Join(", ", x.Id.ToString());
                }
            }
            return list;
        }
        //public string ApplicationIds { get { return string.Join(", ", ApplicationList); } }
            /*set {
                foreach (var x in Applications)
                {
                    if (x.Applicant.Id == this.Id)
                    {
                        ApplicationIds = string.Join(", ", x.Id);
                    }
                }
            }
        }*/
    }
}
