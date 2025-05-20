using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Views;
namespace Controllers
{
    public class ProductController
    { 
            public List<Product> loadProduct() => ProductView.inputProductList();
            public void ShowProductList(List<Product> list) => ProductView.ShowProductList(list);       
    }
}
