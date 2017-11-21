using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerStore.BLL;

namespace ComputerStore.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsManager _productsManager;

        public ProductsController(IProductsManager productsManager)
        {
            this._productsManager = productsManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var products = _productsManager.GetComputers();

            // implicit convert to VM list
            List<Models.ComputerVM> model = products.Select<Entities.Computer, Models.ComputerVM>(x => x).ToList();

            return View(model);
        }
    }
}