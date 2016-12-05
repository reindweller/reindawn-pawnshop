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
    public class CustomerService : AbstractEntityService<Customer>
    {
        public CustomerService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Customer, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Customer, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Customer> OrderBy(IQueryable<Customer> arg)
        {
            return arg.OrderByDescending(o => o.LastName).ThenBy(o=>o.FirstName);
        }

    }
}
