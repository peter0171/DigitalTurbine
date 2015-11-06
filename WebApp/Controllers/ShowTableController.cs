using Common.Enums;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using Common.Helper;
using BLL;

namespace WebApp.Controllers
{
    public class ShowTableController : Controller
    {
        //
        // GET: /ShowTable/

        ShowTableViewModel viewModel;
        PersonManager personManager;

        public ShowTableController()
        {
            viewModel = new ShowTableViewModel();
            personManager = new PersonManager();

            viewModel.PersonList = personManager.GetPersonList();

        }

        public ActionResult Index()
        {
            PersonRace races = new PersonRace();
            ViewData["PersonRaces"] = races.ToSelectList();

            return View(viewModel);
        }

        public PartialViewResult ChangeRace(string linktype)
        {
            IEnumerable<Person> personList;

            if (!string.IsNullOrEmpty(linktype))
            {
                personList = viewModel.PersonList.Where(c => c.Race == linktype.ParseEnum<PersonRace>() && c.Age % 2 == 0).OrderBy(c => c.Age).ToList();
            }
            else
            {
                personList = viewModel.PersonList;
            }

            return PartialView("TablePartial", personList);
        }


    }
}
