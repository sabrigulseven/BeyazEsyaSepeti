using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Models
{
    public class UserProductContainer
    {
        public User user { get; set; }
        public List<Product> productList{ get; set; }
    }
}
