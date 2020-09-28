using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP
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

        public static bool IsAvailableQuantity(Item item) 
        {
            var quantityInStock = Stock.items.Where(x => x.code == item.code).FirstOrDefault().quantity;
            if (quantityInStock > item.quantity) 
            {
                return true;
            }
            return false;
        }
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
            if (Stock.IsAvailableQuantity(item)) 
            {
                cartItems.Add(item);
                return true;
            }
            return false;
        }

        public int GetItemCount() { return cartItems.Count; }

        public List<Item> GetItems() { return cartItems; }
    }

    public class SalesInvoice
    {
        public static void CreateInvoice(List<Item> cartItems, string customerID) 
        {
            // calculate total price
            var total = cartItems.Sum(x => x.price);

            // get customer data

            // save to database


            PrintingManager.print(new object());
            EmailService.send(new object());
        }
    }

    public class PrintingManager
    {
        public static void print(object objInvoice) {}
    }

    public class EmailService
    {
        public static void send(object objEmail) {}
    }

    

    public class BestPractice
    {
        public void Run()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.Add(new Item());
            SalesInvoice.CreateInvoice(myCart.GetItems(), "1");

            Console.WriteLine("items counts" + myCart.GetItemCount().ToString());
        }
    }
}