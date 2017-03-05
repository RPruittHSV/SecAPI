using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecAPI.Core
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class BooksContext:IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }


    }
}