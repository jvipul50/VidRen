using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidRen2.Models;

namespace VidRen2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}