using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Reindawn.Domain.Models;
using Reindawn.Repository;

namespace Reindawn.Service
{
    public class AppraisersSlipService : AbstractEntityService<AppraisersSlip>
    {
        public AppraisersSlipService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<AppraisersSlip, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<AppraisersSlip, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<AppraisersSlip> OrderBy(IQueryable<AppraisersSlip> arg)
        {
            return arg.OrderByDescending(o => o.Date);
        }

    }
}
