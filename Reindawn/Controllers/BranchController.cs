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
    public class BranchController : AbstractEntryController<Branch, BranchViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<Branch> _branchService = new BranchService(UnitOfWork);
        protected override Branch AssignViewModelToEntity(BranchViewModel viewModel)
        {
            var model = viewModel.Convert<BranchViewModel, Branch>();
            return model;
        }

        protected override BranchViewModel AssignEntityToViewModel(Branch entity)
        {
            var viewModel = entity.Convert<Branch, BranchViewModel>();
            //var middleInitial = viewModel.MiddleName == null ? "" : viewModel.MiddleName.Substring(0, 1) + ".";
            //viewModel.FullName = string.Format("{0}, {1} {2}", viewModel.LastName, viewModel.FirstName,
            //    middleInitial);
            return viewModel;
        }

        protected override IEntityService<Branch> GetService()
        {
            return _branchService;
        }

        protected override BranchViewModel SetViewModelFromParent(Guid? id, BranchViewModel viewModel)
        {
            //if (id == null)
            //{
            //    return viewModel;
            //}
            //SignatureCardService signatureCardService = new SignatureCardService(UnitOfWork);
            //var signatureCard = signatureCardService.Find((Guid)id);
            //if (signatureCard == null)
            //{
            //    throw new Exception("signature card is not valid");
            //}

            //var middleInitial = signatureCard.MiddleName == null ? "" : signatureCard.MiddleName.Substring(0, 1) + ".";
            //viewModel.SignatureCardId = (Guid)id;
            //viewModel.FullName = string.Format("{0}, {1} {2}", signatureCard.LastName, signatureCard.FirstName,
            //    middleInitial);
            return viewModel;
        }
    }
}