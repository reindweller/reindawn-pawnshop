using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Models;

namespace Reindawn.Controllers
{
    public class RenewController : Controller
    {
        // GET: Renew
        public ActionResult Index()
        {
            List<RenewViewModel> viewModels = new List<RenewViewModel>
            {
                new RenewViewModel
                {
                    Date = new DateTime(2016, 1, 23),
                    PawnTicketId = Guid.NewGuid(),
                    PawnTicketNo = "PTR001X"
                },
                new RenewViewModel
                {
                    Date = new DateTime(2016, 4, 2),
                    PawnTicketId = Guid.NewGuid(),
                    PawnTicketNo = "PTR002X"
                },
                new RenewViewModel
                {
                    Date = new DateTime(2016, 12, 2),
                    PawnTicketId = Guid.NewGuid(),
                    PawnTicketNo = "PTR003X"
                },
            };
            return View(viewModels);
        }

        public ActionResult Create()
        {
            RenewViewModel viewModel = new RenewViewModel();
            viewModel.Date = DateTime.Now;
            //branch select list items
            //BranchService branchService = new BranchService(UnitOfWork);
            viewModel.PawnTicketsSelectListItems = new List<SelectListItem>
            {
                new SelectListItem { Text = "PT0001", Value = "1" },
                new SelectListItem { Text = "PT0002", Value = "2" },
                new SelectListItem { Text = "PT0003", Value = "3" },
                new SelectListItem { Text = "PT0004", Value = "4" }
            };

            return View(viewModel);
        }
    }
}