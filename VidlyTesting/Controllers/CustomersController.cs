using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyTesting.Models;
using VidlyTesting.ViewModels;

namespace VidlyTesting.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer{Id=1, Name="John Wills" },
            new Customer{Id=2, Name="Mary Bro" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek !" };
           
            var viewModel = new MovieViewModels
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(c => c.Id == id);

            var viewModel = new CustomerViewModels()
            {
                Customer = customer
            };

            if (customer == null)
                return HttpNotFound();

            return View(viewModel);
            
        }
    }
}