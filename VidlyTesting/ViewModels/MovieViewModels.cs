using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTesting.Models;

namespace VidlyTesting.ViewModels
{
    public class MovieViewModels
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}