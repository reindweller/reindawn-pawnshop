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
    public class ItemService : AbstractEntityService<Item>
    {
        public ItemService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Item, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Item, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Item> OrderBy(IQueryable<Item> arg)
        {
            return arg.OrderByDescending(o => o.Code);
        }

    }
}
