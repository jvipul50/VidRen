﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidRen2.Dtos
{
    public class NewRentalDto
    {
        public  int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}