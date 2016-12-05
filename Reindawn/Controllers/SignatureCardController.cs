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
    public class SignatureCardController : AbstractEntryController<SignatureCard, SignatureCardViewModel>
    {

        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<SignatureCard> _signatureCardService = new SignatureCardService(UnitOfWork);
        
        protected override SignatureCard AssignViewModelToEntity(SignatureCardViewModel viewModel)
        {
            var model = viewModel.Convert<SignatureCardViewModel, SignatureCard>();
            model.FirstName = model.FirstName.ToUpper();
            model.MiddleName = model.MiddleName.ToUpper();
            model.LastName = model.LastName.ToUpper();
            return model;
        }

        protected override SignatureCardViewModel AssignEntityToViewModel(SignatureCard entity)
        {
            var viewModel = entity.Convert<SignatureCard, SignatureCardViewModel>();
            var middleInitial = viewModel.MiddleName == null ? "" : viewModel.MiddleName.Substring(0, 1) + ".";
            viewModel.FullName = string.Format("{0}, {1} {2}", viewModel.LastName, viewModel.FirstName,
                middleInitial);
            return viewModel;
        }

        protected override IEntityService<SignatureCard> GetService()
        {
            return _signatureCardService;
        }

        protected override SignatureCardViewModel SetViewModelData(SignatureCardViewModel viewModel)
        {
            viewModel.Date = DateTime.Now;
            //viewModel.PrefixeSelectListItems =
            //    Enum.GetValues(typeof (NamePrefixEnum)).Cast<NamePrefixEnum>().Select(v => new SelectListItem
            //    {
            //        Text = v.ToString(),
            //        Value = ((int) v).ToString()
            //    }).ToList();


            return viewModel;
        }

        protected override SignatureCardViewModel SetViewModelFromParent(Guid? id, SignatureCardViewModel viewModel)
        {
            return viewModel;
        }
    }
}