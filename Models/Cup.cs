using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcCups.Models
{
    public class Cup 
    {
        public int Id { get; set; }
        public string TitleName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string Shape { get; set; }

        public string Size { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }

        public string Review { get; set; }
    }
}
