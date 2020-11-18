using LoanProgram.Data;
using LoanProgram.Data.Entities;
using LoanProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram.Services
{
    public class ApplicationService
    {
        private readonly Guid _userId;

        public ApplicationService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateApplication(ApplicationCreate model)
        {
            var entity =
                new Application()
                {
                    CreatedBy = _userId,
                    ApplicantId = model.ApplicantId,
                    Type = model.Type,
                    Description = model.Description,
                    Occupation = model.Occupation,
                    Salary = model.Salary,
                    MoveInDate = model.MoveInDate,
                    Phone = model.Phone,
                    Email = model.Email,
                    Contact = model.Contact,
                    PreferredConsultant = model.PreferredConsultant
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Applications.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ApplicationListItem> GetApplications()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Applications
                        .Where(e => e.CreatedBy == _userId)
                        .Select(
                            e =>
                                new ApplicationListItem
                                {
                                    Id = e.Id,
                                    ApplicantId = e.ApplicantId,
                                    Type = e.Type,
                                    Description = e.Description,
                                    Occupation = e.Occupation,
                                    Salary = e.Salary,
                                    MoveInDate = e.MoveInDate,
                                    ApplicationDate = e.ApplicationDate,
                                    ResidencyLength = e.ResidencyLength,
                                    Phone = e.Phone,
                                    Email = e.Email,
                                    Contact = e.Contact,
                                    PreferredConsultant = e.PreferredConsultant
                                }
                        );

                return query.ToArray();
            }
        }
        public ApplicationDetail GetApplicationById (int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applications
                        .Single(e => e.Id == id && e.CreatedBy == _userId);
                return
                    new ApplicationDetail
                    {
                        Id = entity.Id,
                        ApplicantId = entity.ApplicantId,
                        Applicant = entity.Applicant,
                        Type = entity.Type,
                        Description = entity.Description,
                        Occupation = entity.Occupation,
                        Salary = entity.Salary,
                        MoveInDate = entity.MoveInDate,
                        ApplicationDate = entity.ApplicationDate,
                        ResidencyLength = entity.ResidencyLength,
                        Phone = entity.Phone,
                        Email = entity.Email,
                        PreferredConsultant = entity.PreferredConsultant
                    };
            }
        }
        public bool UpdateApplication(ApplicationDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applications
                        .Single(e => e.Id == model.Id && e.CreatedBy == _userId);

                entity.ApplicantId = model.ApplicantId;
                entity.Type = model.Type;
                entity.Description = model.Description;
                entity.Occupation = model.Occupation;
                entity.Salary = model.Salary;
                entity.MoveInDate = model.MoveInDate;
                entity.Phone = model.Phone;
                entity.Email = model.Email;
                entity.Contact = model.Contact;
                entity.PreferredConsultant = model.PreferredConsultant;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteApplication(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applications
                        .Single(e => e.Id == noteId && e.CreatedBy == _userId);

                ctx.Applications.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
