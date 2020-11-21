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
    public class ApplicantService
    {
        private readonly Guid _userId;

        public ApplicantService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateApplicant(ApplicantCreate model)
        {
            var entity =
                new Applicant()
                {
                    CreatedBy = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age = model.Age,
                    Address = model.Address,
                    MarriageStatus = model.MarriageStatus,
                    IsHeadOfHousehold = model.IsHeadOfHousehold,
                    SizeOfHousehold = model.SizeOfHousehold
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Applicants.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ApplicantListItem> GetApplicants()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Applicants
                        .Where(e => e.CreatedBy == _userId)
                        .Select(
                            e =>
                                new ApplicantListItem
                                {
                                    Id = e.Id,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    Age = e.Age,
                                    Address = e.Address,
                                    MarriageStatus = e.MarriageStatus,
                                    IsHeadOfHousehold = e.IsHeadOfHousehold,
                                    SizeOfHousehold = e.SizeOfHousehold
                                }
                        );

                return query.ToArray();
            }
        }
        public ApplicantDetail GetApplicantById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applicants
                        .Single(e => e.Id == id && e.CreatedBy == _userId);
                return
                    new ApplicantDetail
                    {
                        Id = entity.Id,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Age = entity.Age,
                        Address = entity.Address,
                        MarriageStatus = entity.MarriageStatus,
                        IsHeadOfHousehold = entity.IsHeadOfHousehold,
                        SizeOfHousehold = entity.SizeOfHousehold
                    };
            }
        }
        public bool UpdateApplicant(ApplicantEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applicants
                        .Single(e => e.Id == model.Id && e.CreatedBy == _userId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Age = model.Age;
                entity.Address = model.Address;
                entity.MarriageStatus = model.MarriageStatus;
                entity.IsHeadOfHousehold = model.IsHeadOfHousehold;
                entity.SizeOfHousehold = model.SizeOfHousehold;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteApplicant(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Applicants
                        .Single(e => e.Id == Id && e.CreatedBy == _userId);

                ctx.Applicants.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
