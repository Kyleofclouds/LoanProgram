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
    public class ConsultantService
    {
        private readonly Guid _userId;
        public ConsultantService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateConsultant(ConsultantCreate model)
        {
            var entity =
                new Consultant()
                {
                    CreatedBy = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Specialization = model.Specialization,
                    HireDate = model.HireDate
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Consultants.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ConsultantListItem> GetConsultants()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Consultants
                        .Where(e => e.CreatedBy == _userId)
                        .Select(
                            e =>
                                new ConsultantListItem
                                {
                                    Id = e.Id,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    Specialization = e.Specialization,
                                    IsCurrentEmployee = e.IsCurrentEmployee,
                                    HireDate = e.HireDate,
                                    TimeWith = e.TimeWith
                                }
                        );

                return query.ToArray();
            }
        }
        public ConsultantDetail GetConsultantById (int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Consultants
                        .Single(e => e.Id == id && e.CreatedBy == _userId);
                return
                    new ConsultantDetail
                    {
                        Id = entity.Id,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Specialization = entity.Specialization,
                        IsCurrentEmployee = entity.IsCurrentEmployee,
                        HireDate = entity.HireDate
                    };
            }
        }
        public bool UpdateConsultant(ConsultantDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Consultants
                        .Single(e => e.Id == model.Id && e.CreatedBy == _userId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Specialization = model.Specialization;
                entity.IsCurrentEmployee = model.IsCurrentEmployee;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteConsultant(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Consultants
                        .Single(e => e.Id == noteId && e.CreatedBy == _userId);

                ctx.Consultants.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
