using Linqtask.Data;
using Linqtask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Linqtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //1-List all customers' first and last names along with their email addresses.
            //var customers = context.Customers;
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"{customer.FirstName},{customer.LastName},{customer.Email}");
            //}

            // 2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            //var orders = context.Orders.Where(o => o.StaffId == 3);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"{order.OrderId},{order.OrderDate}");
            //}
            // 3 - Get all products that belong to a category named "Mountain Bikes".
            //var products = context.Products.Where(p => p.Category.CategoryName == "Mountain Bikes");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductName},{product.ModelYear}");
            //}
            //4-Count the total number of orders per store.
            //var c = context.Orders.GroupBy(o => o.Store.StoreName).Select(o => new
            //{
            //    o.Key , // دي عايدة علي الستور نيم
            //   total= o.Count()
            //});
            //foreach (var item in c)
            //{
            //    Console.WriteLine($"{item.Key},{item.total}");
            //}
            //5- List all orders that have not been shipped yet (shipped_date is null).
            //var ord = context.Orders.AsQueryable().Where(o => o.ShippedDate == null);
            //foreach (var item in ord)
            //{
            //    Console.WriteLine($"{item.OrderId},{item.OrderStatus},{item.ShippedDate}");
            //}

            //6- Display each customer’s full name and the number of orders they have placed.
            //var customerorders =context.Orders.Include(o=>o.Customer); //join
            //foreach (var item in customerorders)
            //{
            //       Console.WriteLine($"{item.OrderId},{item.Customer.FirstName},{item.Customer.LastName}");

            //}

            // 7 - List all products that have never been ordered(not found in order_items).
            //var product=context.Products.Where(p=> ! p.OrderItems.Any());
            // foreach (var item in product)
            // {

            //     Console.WriteLine($"{item.ProductName}");

            // }
            //8- Display products that have a quantity of less than 5 in any store stock.
            //var quntity = context.Products.Where(P => P.Stocks.Any(S => S.Quantity < 5));
            //foreach (var item in quntity)
            //{
            //    Console.WriteLine($"{item.ProductName}");
            //}

            //9 - Retrieve the first product from the products table.
            //var product = context.Products.FirstOrDefault();

            //    Console.WriteLine($"{product.ProductName},{product.ProductId}");


            ////10 - Retrieve all products from the products table with a certain model year.
            //var products = context.Products.Where(p => p.ModelYear == 2018);
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName}");
            //}

            //11- Display each product with the number of times it was ordered.
            //var orderproduct = context.Products.Select(p => new
            //{
            //    p.ProductName,
            //    count = p.OrderItems.Count(),
            //});
            //foreach (var item in orderproduct)
            //{
            //    Console.WriteLine($"{item.ProductName},{item.count}");
            //}
            //12- Count the number of products in a specific category.
            //var cou=context.Products.Count(p=>p.CategoryId==1);

            //  Console.WriteLine($"{cou}");


            //13- Calculate the average list price of products.
            //var avg=context.Products.Average(p=>p.ListPrice);
            //Console.WriteLine(avg);

            //14- Retrieve a specific product from the products table by ID.
            //var product = context.Products.FirstOrDefault(p=>p.ProductId==3);
            //var product = context.Products.Find(3);

            //Console.WriteLine(product.ProductName);


            //15- List all products that were ordered with a quantity greater than 3 in any order.
            //var products = context.Products.Where(p => p.OrderItems.Any(o => o.Quantity > 3));
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName}");
            //  }

            //16- Display each staff member’s name and how many orders they processed.
            //var staff = context.Staffs.Select(s => new
            //{
            //    s.FirstName,
            //    s.LastName,
            //    count = s.Orders.Count()
            //});
            //foreach (var item in staff)
            //{
            //    Console.WriteLine($"{item.FirstName},{item.LastName},{item.count}");
            //}


            // 17 - List active staff members only(active = true) along with their phone numbers.

            //var staffs = context.Staffs.Where(s => s.Active==1).Select(s=> new
            //{
            //    s.Phone
            //});

            //foreach (var item in staffs)
            //{
            //    Console.WriteLine($"{item.Phone}");
            //}


            ////18- List all products with their brand name and category name.
            //var products = context.Products.Include(p => p.Brand).Include(p => p.Category);
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName},{item.Brand.BrandName},{item.Category.CategoryName}");
            //}

            ////19- Retrieve orders that are completed.
            //var orders = context.Orders.Where(o => o.OrderStatus == 4);
            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"{item.OrderId}");
            //}

            //20- List each product with the total quantity sold (sum of quantity from order_items).
            var products = context.Products.Select(p => new
            {
                p.ProductName,
                total =p.OrderItems.Sum(o=>o.Quantity)

            });
            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductName},{item.total}");
            }

        }

    }
}
