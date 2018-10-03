using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Pokupka
    {
        public int PokupkaId { get; set; }
        public string Person { get; set; }
        public string Adress { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}