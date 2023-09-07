using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablePrac31
{
    class ParentProduct { }
    class Product : ParentProduct, IComparable, IDisposable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            //return this.Price.CompareTo((obj as Product).Price);
            return this.Name.CompareTo((obj as Product).Name);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose() 메서드를 호출합니다.");
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
    internal class Program { 
        static void Main(string[] args)
        {
            using (Product product = new Product())
            {
                Console.WriteLine("Dispose 메서드 호출 전");
            }
            Console.WriteLine("Dispose 메서드 호출 후");

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
