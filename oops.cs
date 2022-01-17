using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Product
    {
        private string _ProductID;
        private string _ProductName;
        private decimal _Price;

        /*public void setProducts(string Product, string Productname, string Price)
         * {
         *      this._Product=Products;
         *      this._Productsname=Productname;
         *      this._Price=Price;
         * }
         
         */
        //Read Only Property
        public string ProductID
        {
            get
            {
                return _ProductID;
            }
        }
        public string ProductName
        {
            get
            {
                return _ProductName;
            }
        }
        public decimal Price
        {
            get 
            { 
                return _Price; 
            }
            set
            {
                if(_Price<value)
                {
                    throw new Exception("Error: New price cant be more than the current price");
                }
                else
                {
                    _Price = value;
                }
            }
        }
        public void showProduct()
        {
            Console.WriteLine($"ProductID: {_ProductID}\nProduct Name: {_ProductName}\nPrice: Rs.{_Price}");
        }
    }
    public class demo
    {
        public static void Main(string[] args)
        {
            Product tv = new Product("TV101","LG Golden Eye",15000);

            tv.Price = 5000;
            tv.showProduct();

        }
    }
}

   
