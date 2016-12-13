using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Domain.Models;
using Reindawn.Models;
using Reindawn.Repository;
using Reindawn.Service;
using Reindawn.Utilities.Extensions;

namespace Reindawn.Controllers
{
    public class InterestPayController : AbstractEntryController<InterestPay, InterestPayViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        //readonly IEntityService<InterestPay> _InterestPayService = new InterestPayService(UnitOfWork);
        

        protected override InterestPay AssignViewModelToEntity(InterestPayViewModel viewModel)
        {
            var model = viewModel.Convert<InterestPayViewModel, InterestPay>();
            return model;
        }

        protected override InterestPayViewModel AssignEntityToViewModel(InterestPay entity)
        {
            var viewModel = entity.Convert<InterestPay, InterestPayViewModel>();
            return viewModel;
        }

        protected override IEntityService<InterestPay> GetService()
        {
            return null;
        }

        public override ActionResult Index(Guid? id = null)
        {
            var records = new List<InterestPayViewModel>();
            return View(records);
            
        }

        protected override InterestPayViewModel SetViewModelFromParent(Guid? id, InterestPayViewModel viewModel)
        {
            return viewModel;
        }
    }
}