using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        //public string Name;
        public string Name { get; set; } //自動屬性

        //-------------------------------------------------

        public static int TotalProducts { get; set; }

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

        public int Price    //變數名旁邊直接加{} 為宣告做屬性,
        {                   //用開頭大寫代表(Coding style)
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
        //Structure
        //
        //public Product(string name, int price)
        //{
        //    this.Price = price;
        //    this.Name = name;
        //
        //    this.Discount = 1.0f;
        //}
        // ===>
        public Product(string name, int price, float discount)
        {
            this.Price = price;
            this.Name = name;
            this.Discount = discount;

            //
            TotalProducts++;
        }

        public Product(Product product)
            : this(product.Name, product.Price, product.Discount)
        { }

        public Product(int price, string name, float discount)

            : this(name, price, discount)
        { }

        public Product(string name, int price)
            : this(name, price, 1.0f)
        { }

        public Product()
            : this("無產品名稱", 0, 1.0f)
        { }

        //-------------------------------------------------
        public Product Clone()
        {
            return new Product(this);
        }

        //-------------------------------------------------
        //
        //-------------------------------------------------

        public override string ToString()
        {
            return string.Format("產品名稱: {0}\n產品價格 : {1}\n產品折扣 : {2}\n這是第{3}個Product",
                this.Name, this.Price, this.Discount, Product.TotalProducts);
        }

        //-------------------------------------------------
    }
}