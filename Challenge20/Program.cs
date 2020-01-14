using System;

namespace PreCourse
{

    public class Item{
        
		public String name;
		public double price;
		public bool onSale;
		
		public double print(double price){
			if(onSale)
				price = price - price * 0.2;
			
			Console.Write("{0} ({1})", name, price);
            return price;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            // Make this code works by create new class, method, and property.
            Item item = new Item();
            item.name = "SilverQueen";
            item.price = 15000;
            item.onSale = true; // If true the price will drop 20%

            item.print(15000); // Output: "Indomie Goreng (Rp2800)"
        }
    }
}
