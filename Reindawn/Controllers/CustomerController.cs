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
    public class CustomerController : AbstractEntryController<Customer, CustomerViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<Customer> _customerService = new CustomerService(UnitOfWork);
        protected override Customer AssignViewModelToEntity(CustomerViewModel viewModel)
        {
            var model = viewModel.Convert<CustomerViewModel, Customer>();
            return model;
        }

        protected override CustomerViewModel AssignEntityToViewModel(Customer entity)
        {
            var viewModel = entity.Convert<Customer, CustomerViewModel>();
            var middleInitial = viewModel.MiddleName == null ? "" : viewModel.MiddleName.Substring(0, 1) + ".";
            viewModel.FullName = string.Format("{0}, {1} {2}", viewModel.LastName, viewModel.FirstName,
                middleInitial);
            return viewModel;
        }

        protected override IEntityService<Customer> GetService()
        {
            return _customerService;
        }

        protected override CustomerViewModel SetViewModelFromParent(Guid? id, CustomerViewModel viewModel)
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