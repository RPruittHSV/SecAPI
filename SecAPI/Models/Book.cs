﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecAPI.Models
{
    using System.Collections.Generic;
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}