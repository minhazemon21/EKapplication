﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EKapp.Models;

namespace EKapp.ViewModels
{
    public class RandomMovieViewModels
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}