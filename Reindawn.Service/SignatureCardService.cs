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

    public class SignatureCardService : AbstractEntityService<SignatureCard>
    {
        public SignatureCardService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<SignatureCard, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<SignatureCard, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<SignatureCard> OrderBy(IQueryable<SignatureCard> arg)
        {
            return arg.OrderByDescending(o => o.Date);
        }

    }


}
