using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinimalProject.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public string PhotoPath { get; set; }
    }
}