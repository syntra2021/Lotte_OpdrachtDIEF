using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> products { get; set; }
    }
}
