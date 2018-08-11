using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4Repositories.Web.ViewModel.Products;

namespace T4Repositories.Web.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new ProductViewModel();

            return View(viewModel);
        }

        public ActionResult Create2()
        {
            var viewModel = new ProductViewModel();

            return View(viewModel);
        }
    }
}