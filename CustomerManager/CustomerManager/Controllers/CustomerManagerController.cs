using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManager.Controllers
{
    public class CustomerManagerController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer();
            customer.Name = "HaiNX";
            customer.Age = 35;

            List<Customer> Lcustomer = new List<Customer>();

            Lcustomer.Add( new Customer
            {
                Name = "Ngoc",
                Age = 19

            });

            Lcustomer.Add(new Customer
            {
                Name = "Van",
                Age = 20

            });

            //return View();
            return View(Lcustomer) ;
        }

        public IActionResult Detail(string strName)
        {
            Customer customer = new Customer { Name = strName };

            return View(customer);
        }

        public IActionResult Hello()
        {
            return View();
        }

        
    }
}