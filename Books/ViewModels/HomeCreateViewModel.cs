using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.ViewModels
{
    public class HomeCreateViewModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name="Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Author")]
        [MaxLength(50)]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Price")]
        [MaxLength(50)]
        public int Price { get; set; }
        

    }
}
