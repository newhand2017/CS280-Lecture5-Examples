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
        //private int price;  //Example01--2,
        //
        //public int GetPrice()
        //{
        //    return this.price;
        //}
        //
        ////product.price = price
        //public void SetPrice(int price)
        //{
        //    if (price > 200)
        //    {
        //        this.price = 200;
        //    }
        //    else if (price < 39)
        //    {
        //        this.price = 39;
        //    }
        //    else
        //    {
        //        this.price = price;
        //    }
        //}
        //-------------------------------------------------
        // Example01--03,
        // 可接受以"="做事
        //-------------------------------------------------
        private int price;  //小寫代表變數

        public int Price    //開頭大寫代表"屬性"
        {
            get { return this.price; }

            set
            {
                if (value > 200)
                {
                    this.price = 200;
                }
                else if (value < 39)
                {
                    this.price = 39;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        //-------------------------------------------------
        //
        //public float Discount;

        //
        private float discount;

        public float Discount
        {
            //get => this.discount
            get { return this.discount; }

            set
            {
                if (value > 1.0f)
                {
                    this.discount = 1.0f;
                }
                else if (value < 0.3f)
                {
                    this.discount = 0.3f;
                }
                else
                {
                    this.discount = value;
                }
            }
        }

        //-------------------------------------------------
    }
}