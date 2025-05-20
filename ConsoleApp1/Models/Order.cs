using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
        {
            public Client client { get; set; }
            public List<Product> productList { get; set; } = new List<Product>();

            public double CalculateTotal() => productList.Sum(p => p.Price);
            public double CalculateTotalIVA() => productList.Sum(p => p.FinalPrice());
        }
    
}