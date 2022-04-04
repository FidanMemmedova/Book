using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Product
{
    class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;
        public bool isWrong;
        public Product(int no, string name, int price)
        {
            No = no;
            Name = name;
            Price = price;
        }

    }
}
