using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Book
    {
        public int id { get; set; }

        [Required]
        public string Name  { get; set; }

        [Required]
        public string  Author { get; set; }

        [Required]
        public int Price { get; set; }

    }
}
