using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        public string Name;

        //-------------------------------------------------
        // Example01--1
        //-------------------------------------------------
        //public int Price;   //Example01--1
        //-------------------------------------------------
        // Example01--2, (封裝)
        // 無法直接以 "=" 設定數值(set), 也無法直接以"." 做呼叫(get)
        //-------------------------------------------------
        private int Price;  //Example01--2,

        public int GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(int price)
        {
            if (price > 200)
            {
                this.Price = 200;
            }
            else if (price < 39)
            {
                this.Price = 39;
            }
            else
            {
                this.Price = price;
            }
        }

        //-------------------------------------------------

        public float Discount;

        //-------------------------------------------------
    }
}