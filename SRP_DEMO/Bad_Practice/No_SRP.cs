using System;
using System.Collections.Generic;
using System.Linq;

namespace NoSRP
{
    public class  Item 
    {
        public string code;
        public double price;
        public double quantity;
    }

    public class Stock
    {
        public static List<Item> items = new List<Item> 
            {
                new Item {code="123", price=10, quantity=10},
                new Item {code="456", price=12, quantity=2},
                new Item {code="789", price=14, quantity=1},
            };
    }

    public class ShoppingCart
    {
        List<Item> cartItems = new List<Item>();

        public void RemoveFromCart(Item item) 
        {
            if (cartItems.Contains(item)) cartItems.Remove(item);
        }

        public bool Add(Item item)
        {
            // check available qauntity
            var quantityInStock = Stock.items.Where(x => x.code == item.code).FirstOrDefault().quantity;
            if (quantityInStock > item.quantity) 
            {
                cartItems.Add(item);
                return true;
            }
            return false;
        }

        public int GetItemCount() { return cartItems.Count; }

        public void CreateInvoice() 
        {
            // calculate total price
            var total = cartItems.Sum(x => x.price);

            // get customer data

            // save to database

            // print invoice

            // send invoice to customer email
        }
    }

    public class BadPractice
    {
        public void Run()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.Add(new Item());
            myCart.CreateInvoice();

            Console.WriteLine("items counts" + myCart.GetItemCount().ToString());
        }
    }
}