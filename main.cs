using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        string userSize;
        string userTopings;

        Console.Write("Hello! What kind of pizza would you like? Please enter the following:");
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("What size? Small, Medium, Large or Extra-Large?");
        userSize = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("What toppings? Extra-Cheese, Pepperoni or Pineapple?");
        userTopings = Console.ReadLine();
        Console.WriteLine("");


        double sizePrice = 0;
        double topingPrice = 0;

        if (userSize == "Small")
        {
            sizePrice = 1.0;
        }
        else if (userSize == "Medium")
        {
            sizePrice = 1.5;
        }
        else if (userSize == "Large")
        {
            sizePrice = 2.0;
        }
        else if (userSize == "Extra-Large")
        {
            sizePrice = 2.5;
        }
        else
        {
            Console.WriteLine("Error");
        }

        if (userTopings == "Extra-Cheese")
        {
            topingPrice = 0.5;
        }
        else if (userTopings == "Pepperoni")
        {
            topingPrice = 1.0;
        }
        else if (userTopings == "Pineapple")
        {
            topingPrice = 1.5;
        }
        else
        {
            Console.WriteLine("Error");
        }

        double totalPrice = sizePrice + topingPrice;

        Console.WriteLine("Your total will be $" + totalPrice + "! Please call 737-1111 to order!");

        Console.WriteLine("\nDone.");

    }
}