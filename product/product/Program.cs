using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mLibrary;

namespace product
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public string UnitofMeasurement { get; set; }
        public int Quantity { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                Products product = new Products
                {
                    ProductId = 2,
                    ProductName = "Phone",
                    price = 120000,
                    UnitofMeasurement = "E",
                    Quantity = 2

                };
                Products product2 = new Products
                {
                    ProductId = 4,
                    ProductName = "Ring",
                    price = 1600,
                    Quantity = 5
                };
                Products product3 = new Products
                {
                    ProductId = 8,
                    ProductName = "sheets",
                    price = 1100,
                    Quantity = 7

                };
                Console.WriteLine("Product Information:");
                PrintProductDetails(product2);
                PrintProductDetails(product3);
            }


                static void PrintProductDetails(Products product)
                {
                    
                    Console.WriteLine($"Product Id:{product.ProductId}");
                    Console.WriteLine($"Product Name:{product.ProductName}");
                    Console.WriteLine(($"Price :{product.price}"));
                    Console.WriteLine($"Unit of Measurement: {product.UnitofMeasurement}");
                    Console.WriteLine($"Quantity:{product.Quantity}");

                }
            }
        }
    }



   
