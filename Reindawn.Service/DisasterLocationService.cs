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
    public class DisasterLocationService : AbstractEntityService<DisasterLocation>
    {
        public DisasterLocationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<DisasterLocation, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<DisasterLocation, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<DisasterLocation> OrderBy(IQueryable<DisasterLocation> arg)
        {
            return arg.OrderByDescending(o => o.DatePosted);
        }

    }
}
