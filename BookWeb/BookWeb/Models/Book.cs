using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishTime { get; set; }
        public decimal Price { get; set; }
        [ConcurrencyCheck, MaxLength(50)]
        public string Test { get; set; }

    }



}