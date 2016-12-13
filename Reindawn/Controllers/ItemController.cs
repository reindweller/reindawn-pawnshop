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
    public class ItemController : AbstractEntryController<Item, ItemViewModel>
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        readonly IEntityService<Item> _itemService = new ItemService(UnitOfWork);

        protected override Item AssignViewModelToEntity(ItemViewModel viewModel)
        {
            var model = viewModel.Convert<ItemViewModel, Item>();
            return model;
        }

        protected override ItemViewModel AssignEntityToViewModel(Item entity)
        {
            var viewModel = entity.Convert<Item, ItemViewModel>();
            viewModel.Branch = entity.Branch.Name;
            if (viewModel.ItemType == ItemTypeEnum.Jewellery)
            {
                viewModel.Details = string.Format("Wgt:{0} Type:{1} Carat:{2}",
                    viewModel.Weight, viewModel.JewelryType, viewModel.Carat
                    );
            }
            else if (viewModel.ItemType == ItemTypeEnum.Gadget)
            {
                viewModel.Details = string.Format("Brand:{0} Model:{1} SN:{2}",
                    viewModel.Brand, viewModel.Model, viewModel.SerialNo
                    );
            }

            return viewModel;
        }

        protected override ItemViewModel SetViewModelData(ItemViewModel viewModel)
        {
            
            //branch select list items
            BranchService branchService = new BranchService(UnitOfWork);
            viewModel.BranchSelectListItems = branchService.GetAll().ToList().Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.Id.ToString()
            }).ToList();

            return viewModel;
        }


        protected override IEntityService<Item> GetService()
        {
            return _itemService;
        }

        protected override ItemViewModel SetViewModelFromParent(Guid? id, ItemViewModel viewModel)
        {
            return viewModel;
        }
    }
}