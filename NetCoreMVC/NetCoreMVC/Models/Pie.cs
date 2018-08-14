using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbail { get; set; }
        public bool IsPieOfTheWeek { get; set; }
    }
}
