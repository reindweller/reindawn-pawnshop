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

    public class BranchService : AbstractEntityService<Branch>
    {
        public BranchService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Branch, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Branch, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Branch> OrderBy(IQueryable<Branch> arg)
        {
            return arg.OrderByDescending(o => o.Name);
        }

    }
}
