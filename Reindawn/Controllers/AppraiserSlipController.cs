using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Domain.Enumerations;
using Reindawn.Domain.Models;
using Reindawn.Models;
using Reindawn.Repository;
using Reindawn.Service;
using Reindawn.Utilities.Extensions;

namespace Reindawn.Controllers
{
    public class AppraiserSlipController : AbstractEntryController<AppraisersSlip, AppraisersSlipViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<AppraisersSlip> _appraisersSlipService = new AppraisersSlipService(UnitOfWork);

        protected override AppraisersSlip AssignViewModelToEntity(AppraisersSlipViewModel viewModel)
        {
            var model = viewModel.Convert<AppraisersSlipViewModel, AppraisersSlip>();
            return model;
        }

        protected override AppraisersSlipViewModel AssignEntityToViewModel(AppraisersSlip entity)
        {
            var viewModel = entity.Convert<AppraisersSlip, AppraisersSlipViewModel>();
            if (viewModel.ItemType == ItemTypeEnum.Jewellery)
            {
                viewModel.Details = string.Format("Wgt:{0} Qty:{1} Type:{2} Carat:{3}",
                    viewModel.Weight, viewModel.Quantity, viewModel.JewelryType, viewModel.Carat
                    );
            }
            else if (viewModel.ItemType == ItemTypeEnum.Gadget)
            {
                viewModel.Details = string.Format("Brand:{0} Model:{1} Inc:{2} SN:{3}",
                    viewModel.Brand, viewModel.Model, viewModel.Inclusions, viewModel.SerialNo
                    );
            }
            return viewModel;
        }

        protected override IEntityService<AppraisersSlip> GetService()
        {
            return _appraisersSlipService;
        }

        protected override AppraisersSlipViewModel SetViewModelData(AppraisersSlipViewModel viewModel)
        {
            viewModel.Date = DateTime.Now;
            SignatureCardService signatureCardService = new SignatureCardService(UnitOfWork);
            viewModel.SignatureCardsSelect = new List<SignatureCardViewModel>();
            viewModel.SignatureCardsSelect =
                signatureCardService.GetAll().Select(AssignScToScViewModel).ToList();
            return viewModel;
        }

        protected SignatureCardViewModel AssignScToScViewModel(SignatureCard entity)
        {
            var viewModel = entity.Convert<SignatureCard, SignatureCardViewModel>();
            var middleInitial = viewModel.MiddleName == null ? "" : viewModel.MiddleName.Substring(0, 1) + ".";
            viewModel.FullName = string.Format("{0}, {1} {2}", viewModel.LastName, viewModel.FirstName,
                middleInitial);
            return viewModel;
        }


        //var middleInitial = viewModel.MiddleName == null ? "" : viewModel.MiddleName.Substring(0, 1) + ".";
        //viewModel.FullName = string.Format("{0}, {1} {2}", viewModel.LastName, viewModel.FirstName,
        //    middleInitial);
        protected override AppraisersSlipViewModel SetViewModelFromParent(Guid? id, AppraisersSlipViewModel viewModel)
        {
            if (id == null)
            {
                return viewModel;
            }
            SignatureCardService signatureCardService = new SignatureCardService(UnitOfWork);
            var signatureCard = signatureCardService.Find((Guid)id);
            if (signatureCard == null)
            {
                throw new Exception("signature card is not valid");
            }

            var middleInitial = signatureCard.MiddleName == null ? "" : signatureCard.MiddleName.Substring(0, 1) + ".";
            viewModel.SignatureCardId = (Guid)id;
            viewModel.FullName = string.Format("{0}, {1} {2}", signatureCard.LastName, signatureCard.FirstName,
                middleInitial);
            return viewModel;
        }
    }
}