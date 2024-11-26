using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return Id+","+Name+","+Price+","+CompanyName;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };


            //Using LINQ query

            //Display all products using LINQ query
            /* var r1 = from p in products
                         select p;
             foreach (Product r in r1)
             {
                 Console.WriteLine(r);
             } */



            //Display products whose price is greater than 1500
            //var r2 = from p in products
            //         where p.Price > 1500
            //         select p;
            //foreach (Product r in r2)
            //{
            //    Console.WriteLine(r);
            //}

            //Display products whose price is in between 10000 to 40000
            //var r3 = from p in products
            //         where p.Price >= 10000 && p.Price <=40000
            //         select p;
            //foreach (Product r in r3)
            //{
            //    Console.WriteLine(r);
            //}

            //Display products of Dell company
            //var r4 = from p in products
            //         where p.CompanyName == "Dell" 
            //         select p;
            //foreach (Product r in r4)
            //{
            //    Console.WriteLine(r);
            //}

            //Display all company laptops
            //var r5 = from p in products
            //         where p.Name == "Laptop"
            //         select p;
            //foreach (Product r in r5)
            //{
            //    Console.WriteLine(r);
            //}


            //Display products whose company name start with ‘M’
            //var r6 = from p in products
            //         where p.CompanyName.StartsWith("M")
            //         select p;
            //foreach (Product r in r6)
            //{
            //    Console.WriteLine(r);
            //}

            //Display all company mouse whose price is less than 1000
            //var r7 = from p in products
            //         where p.Name == "Mouse" && p.Price < 1000
            //         select p;
            //foreach (Product r in r7)
            //{
            //    Console.WriteLine(r);
            //}


            //Display all products descending order by their price
            //var r8 = from p in products
            //         orderby p.Price descending
            //         select p;
            //foreach (Product r in r8)
            //{
            //    Console.WriteLine(r);
            //}

            //Display all products accessing order by their company name
            //var r9 = from p in products
            //         orderby p.CompanyName
            //         select p;
            //foreach (Product r in r9)
            //{
            //    Console.WriteLine(r);
            //}


            //Display all keyboards accessing order by their price
            //var r10 = from p in products
            //         where p.Name == "Keyboard"
            //         orderby p.Price
            //         select p;
            //foreach (Product r in r10)
            //{
            //    Console.WriteLine(r);
            //}


            //Using Lambda Expressions
            //var r11 = products.ToList();
            //foreach (Product r in r11)
            //{
            //    Console.WriteLine(r);
            //}


            //Display all products descending order by their price
            //var r12 = products.OrderByDescending(x=>x.Price).ToList();
            //foreach (Product r in r12)
            //{
            //    Console.WriteLine(r);
            //}

            //Display product whose Id is 5
            //var r13 = products.Where(x=>x.Id==5).FirstOrDefault();
            // Console.WriteLine(r13);

            //Display all products whose price less than 5000
            //var r14 = products.Where(x=>x.Price<5000).ToList();
            //foreach (Product r in r14)
            //{
            //    Console.WriteLine(r);
            //}

            //Display 3 products which have maximum price
            //var r15 = products.OrderByDescending(x=>x.Price).Take(3);
            //foreach (Product r in r15)
            //{
            //    Console.WriteLine(r);
            //}

            //Display 5 products which have minimum price
            var r16 = products.OrderBy(x => x.Price).Take(5);
            foreach (Product r in r16)
            {
                Console.WriteLine(r);
            }

        }


    }
}
