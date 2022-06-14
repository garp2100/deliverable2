using System;

class mainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hi Welcome to our Buffet. All you can eat for $9.99!");
        Console.WriteLine("We only charge extra for coffee.");
        Console.WriteLine("How many people are in your group? Please, parties of 6 or lower");
        int partySize = int.Parse(Console.ReadLine());

        int waterOrders = 0;
        int coffeeOrders = 0;               
        string drinkOrder;
        double totalBill = partySize * 9.99;


        if (partySize > 0 && partySize <= 6)
        {
            Console.Write("A table for " + partySize + "! Please follow me and take a seat");
            Console.WriteLine("");
        }
        else if (partySize <= 0)
        {
            Console.Write("Guess no one is eating, goodbye!");
            Console.Read();
            return;
        }
        else
        {
            Console.Write("Oh sorry, can only seat parties up to 6. Have a nice day.");            
            Console.Read();
            return;
        }

        Console.WriteLine("");
        Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");

        while (partySize > 0)
        {                      
            Console.WriteLine("Alright, person number " + partySize-- + ", water of coffee?");
            drinkOrder = Console.ReadLine();
            if (drinkOrder == "water")
            {                
                Console.WriteLine(drinkOrder + ", good choice!");
                waterOrders++;
            }
            else if (drinkOrder == "coffee")
            {                
                Console.WriteLine(drinkOrder + ", okay!");
                coffeeOrders++;
            }
            else                
                Console.WriteLine("We don't have that. No drink for you!");                                   
        }

        Console.WriteLine("Okay, so that's " + coffeeOrders + " coffees and " + waterOrders + " waters. I'll be right back. Feel free to grab your food!");
        

        totalBill = (coffeeOrders * 2.00) + (totalBill);
        Console.WriteLine("");    
        Console.WriteLine("Here's your bill! Total price: $" + totalBill);
        Console.Read();
    }

}