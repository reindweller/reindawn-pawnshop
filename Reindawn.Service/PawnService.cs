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

    public class PawnService : AbstractEntityService<Pawn>
    {
        public PawnService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Pawn, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Pawn, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Pawn> OrderBy(IQueryable<Pawn> arg)
        {
            return arg.OrderByDescending(o => o.DatePosted);
        }

    }
}
