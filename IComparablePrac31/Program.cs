﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablePrac31
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
    internal class Program { 
        static void Main(string[] args)
        {
                List<Product> products = new List<Product>()
                {
                    new Product(){Name="고구마", Price=1500 },
                    new Product(){Name="사과", Price=2400 },
                    new Product(){Name="바나나", Price=1000 },
                    new Product(){Name="배", Price=3000 },
                };
                products.Sort();
                foreach(Product p in products)
                {
                    Console.WriteLine(p);
                }
        }
    }
}
