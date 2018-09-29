using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class WebContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

    }

    public class DbInicialaizer : DropCreateDatabaseAlways<WebContext>
    {
        protected override void Seed(WebContext context)
        {
            context.Books.Add(new Book { Id = 12, Name = "Л.Тостой" });
            context.Books.Add(new Book { Id = 12, Name = "А.Пушкин" });

            base.Seed(context);
        }
    }
}