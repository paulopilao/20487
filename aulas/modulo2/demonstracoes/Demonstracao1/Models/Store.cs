using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstracao1.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
