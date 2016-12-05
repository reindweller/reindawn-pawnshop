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