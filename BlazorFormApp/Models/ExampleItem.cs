using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFormApp.Models
{
    public class ExampleItem
    {
        [Required(ErrorMessage = "Name is requied")]
        [StringLength(20, ErrorMessage = "Please type less than 20 characters.")]
        public string Name { get; set; }
    }
}
