using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string GetPath()
        {
            return "/images/Products/" + this.Id + ".jpg";

        }

        public string Category { get; set; }

    }
}
