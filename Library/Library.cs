using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        public Product[] Products;
        public string Name; 

        public Product[] AddProduct(Product product)
        {
            Product[] newProd = new Product[Products.Length + 1];
            for (int i = 0; i < Products.Length; i++)
            {
                newProd[i] = Products[i];
            }
            newProd[newProd.Length - 1] = product;
            Products = newProd;
            return Products;
        }

        public Product[] GetProductsByPrice(double minPrice, double maxPrice)
        {
            Product[] Filtered = new Product[Products.Length];
            int index = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].Price >= minPrice && Products[i].Price <= maxPrice)
                {
                    Filtered[index++] = Products[i];
                }
            }
            return Filtered;
        }
        public Product[] GetProductsByName(string name)
        {
            Product[] Filtered = new Product[Products.Length];
            int index = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Filtered[index++] = Products[i];
                }
            }
            return Filtered;
        }


        public Library(string name)
        {
            Name = name;
            Products = new Product[0];
        }

    }
    
}
