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
    public class PawnTicketService : AbstractEntityService<PawnTicket>
    {
        public PawnTicketService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<PawnTicket, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<PawnTicket, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<PawnTicket> OrderBy(IQueryable<PawnTicket> arg)
        {
            return arg.OrderByDescending(o => o.DateLoanGranted);
        }

    }
}
