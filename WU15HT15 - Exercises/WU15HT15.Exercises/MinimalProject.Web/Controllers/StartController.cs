using MinimalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinimalProject.Web.Controllers
{
    public class StartController : Controller
    {
        // GET: Start
        public ActionResult Index()
        {
            ViewBag.Heading = "Välkommen till Apelsinen";

            var customerList = new List<Customer>();
            var customer = new Customer();
            customer.Name = "Old Mac's";
            customer.PhoneNumber = "070 6103361";
            customer.Notes = "Bra butik i Värnamo, framför Rose Garden";
            customer.PhotoPath = "/images/bigcustomer1.png";
            customer.Id = 1;
            customerList.Add(customer);

            customer = new Customer();
            customer.Name = "MQ";
            customer.PhoneNumber = "070 6103362";
            customer.Notes = "Bra butik i Värnamo, vid Hot el Scandic";
            customer.PhotoPath = "/images/bigcustomer2.png";
            customer.Id = 2;
            customerList.Add(customer);

            customer = new Customer();
            customer.Name = "Dressman";
            customer.PhoneNumber = "070 6103363";
            customer.Notes = "Bra butik i Värnamo, på hörnet av ingenstans";
            customer.PhotoPath = "/images/bigcustomer3.png";
            customer.Id = 3;
            customerList.Add(customer);

            //ViewBag.Customers = customerList;

            return View(customerList);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomerFromRepository(id);
            //var customer = new Customer();

            return View(customer);
        }

        private Customer GetCustomerFromRepository(int id)
        {
            var customer = new Customer();
            customer.Name = "Poke";
            customer.PhoneNumber = "070-6103361";
            customer.Notes = "Poke";
            customer.PhotoPath = "/images/bigbumble.png";
            customer.Id = id;

            return customer;
        }
    }
}