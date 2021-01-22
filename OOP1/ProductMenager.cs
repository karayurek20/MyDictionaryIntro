using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductMenager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Eklendi.");
        }
        public void Delete(Product product)
        {
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
        public void List()
        {

        }
    }
}
