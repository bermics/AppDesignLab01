using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GadgetHub.Domain.Abstract;
using GadgetHub.Domain.Entities;


namespace GadgetHub.WebUI.Controllers
{
    public class GadgetController : Controller
    {
        private readonly IGadgetRepository repository;

        public GadgetController(IGadgetRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Gadgets);
        }
    }
}