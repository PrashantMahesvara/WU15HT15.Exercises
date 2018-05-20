using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Polling.Web.API
{
    public class CustomerController : ApiController
    {
        private static readonly IEnumerable<string> Customers = new string[]
        {
            "Pingvin",
            "Panda",
            "Katt",
            "Hund",
            "Marsvin",
            "Leguan",
            "Fladdermus",
            "Bumbelin",
            "Humla",
            "Kiwi",
            "Quokka",
            "Myrkotte",
            "Igelkott"
        };

        public IEnumerable<string> Get()
        {
            var listOfRandomCustomers = new string[4];
            var randomizer = new Random();

            for (int index = 0; index < 4; index++)
            {
                var randomNumber = randomizer.Next(0, 12);
                var randomCustomer = Customers.ElementAt(randomNumber);

                listOfRandomCustomers[index] = randomCustomer;
            }
            return listOfRandomCustomers;
        }
    }
}
