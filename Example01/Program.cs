using StoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            //
            //---------------------------------------------
            Product product = new Product();

            Console.WriteLine("請輸入產品名稱");
            product.Name = Console.ReadLine();

            Console.Write("請輸入{0}的價錢 : ", product.Name);
            //Suppose the price between 39 to 200
            int price = 0;

            //---------------------------------------------
            // Example01--01
            //
            //try
            //{
            //    price = int.Parse(Console.ReadLine());
            //    if (price > 200)
            //    {
            //        product.Price = 200;
            //    }
            //    else if (price < 39)
            //    {
            //        product.Price = 39;
            //    }
            //    else
            //    {
            //        product.Price = price;
            //    }

            //  // Output result
            //  //Console.WriteLine("產品 : {0}的價格為 : {1}", product.Name, product.Price);
            //}
            //catch
            //{
            //    Console.WriteLine("價格輸入錯誤");
            //    return;
            //}
            //---------------------------------------------
            // Example01--02
            try
            {
                price = int.Parse(Console.ReadLine());
                product.SetPrice(price);

                // Output result
                Console.WriteLine("產品 : {0}的價格為 : {1}", product.Name, product.GetPrice());
            }
            catch
            {
                Console.WriteLine("價格輸入錯誤");
                return;
            }

            //---------------------------------------------
        }
    }
}