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
    public class PawnController : AbstractEntryController<Pawn, PawnViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<Pawn> _pawnService = new PawnService(UnitOfWork);

        public ActionResult SignatureCard()
        {
            return View();
        }

        public ActionResult AppraiserSlip()
        {
            return View();
        }

        public ActionResult PawnTicket()
        {
            return View();
        }


        protected override Pawn AssignViewModelToEntity(PawnViewModel viewModel)
        {
            var model = viewModel.Convert<PawnViewModel, Pawn>();
            return model;
        }

        protected override PawnViewModel AssignEntityToViewModel(Pawn entity)
        {
            var viewModel = entity.Convert<Pawn, PawnViewModel>();
            return viewModel;
        }

        protected override IEntityService<Pawn> GetService()
        {
            return _pawnService;
        }

        protected override PawnViewModel SetViewModelData(PawnViewModel viewModel)
        {
            viewModel.SignatureCard = new SignatureCardViewModel();
            viewModel.AppraisersSlip = new AppraisersSlipViewModel();
            viewModel.PawnTicket = new PawnTicketViewModel();
            return viewModel;
        }

        protected override PawnViewModel SetViewModelFromParent(Guid? id, PawnViewModel viewModel)
        {
            return viewModel;
        }
    }
}