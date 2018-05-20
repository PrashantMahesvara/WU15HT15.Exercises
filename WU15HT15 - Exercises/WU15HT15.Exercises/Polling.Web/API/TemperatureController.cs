using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Polling.Web.API
{
    public class TemperatureController : ApiController
    {
        public int Get()
        {
            var randomizer = new Random();
            var randomNumber = randomizer.Next(1, 10) * 1000;

            Thread.Sleep(randomNumber);

            return randomNumber;
        }
    }
}
