using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTesting.Models;

namespace VidlyTesting.ViewModels
{
    public class CustomerViewModels
    {
        public Customer Customer { get; set; }
        public List<Movie> Movies { get; set; }
    }
}