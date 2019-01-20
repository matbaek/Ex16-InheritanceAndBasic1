using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book
    {
        private string itemId = "";
        private string title = "";
        private double price = 0;

        public string ItemId {
            get { return itemId; }
            set { itemId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0) { }

        public Book(string itemId) : this(itemId, "") { }
        
        public Book() { }


        override
        public string ToString()
        {
            string result = null;

            result += "ItemId: " + itemId + ", ";
            result += "Title: " + title + ", ";
            result += "Price: " + price;

            return result;
        }
    }
}
