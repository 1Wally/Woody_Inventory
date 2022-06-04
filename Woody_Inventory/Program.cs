// Colton Woody
// IT112 
// NOTES: Commented out section that I originally used to ask the user to give another command. Removed because the 
// 'compute shipping charges' was supposed to end the program anyways.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            int uptoten = 0;
            string choice;
            decimal ship = 0;
            int bicyclecount = 0;
            int mowercount = 0;
            int glovecount = 0;
            int crackerscount = 0;
            bool finalCompute = true;

            IShippable[] shippables = new IShippable[10];

            Bicycle bicycle = new Bicycle();
            LawnMower lawnmower = new LawnMower();
            baseballGlove glove = new baseballGlove();
            crackers crackers = new crackers();

            Console.WriteLine("Hello. Would you like to make an order?");
            Console.WriteLine();

            String orderyesno = Console.ReadLine();
            Console.WriteLine();
            orderyesno = orderyesno.ToLower();

            while (orderyesno == "yes" && uptoten < 10 && finalCompute == true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("Bicycle: 9.50"); //$9.50
                Console.WriteLine("Lawn Mower: 24.00"); //$24.00
                Console.WriteLine("Baseball glove: 3.23"); //$3.23
                Console.WriteLine("Crackers: 0.57"); //$0.57
                Console.WriteLine("List shipment items");
                Console.WriteLine("Compute shipping charges");
                Console.WriteLine();

                choice = Console.ReadLine();
                Console.WriteLine();
                choice = choice.ToLower();

                if (choice == "bicycle")
                {
                    shippables[uptoten] = bicycle;      //Console.WriteLine(shippables[0].ShipCost);
                    bicyclecount++;
                }

                if (choice == "lawn mower")
                {
                    shippables[uptoten] = lawnmower;
                    mowercount++;
                }

                if(choice == "baseball glove")
                {
                    shippables[uptoten] = glove;
                    glovecount++;
                }

                if(choice == "crackers")
                {
                    shippables[uptoten] = crackers;
                    crackerscount++;
                }

                if (choice == "list shipment items")
                {
                    Console.WriteLine("Your list includes:");

                    if (bicyclecount == 1)
                    {
                        Console.WriteLine(bicyclecount + " bicycle");
                    }

                    if (bicyclecount > 1)
                    {
                        Console.WriteLine(bicyclecount + " bicycles");
                    }

                    if (mowercount == 1)
                    {
                        Console.WriteLine(mowercount + " lawn mower");
                    }


                    if (mowercount > 1)
                    {
                        Console.WriteLine(mowercount + " lawn mowers");
                    }

                    if (glovecount == 1)
                    {
                        Console.WriteLine(glovecount + " glove");
                    }

                    if (glovecount > 1)
                    {
                        Console.WriteLine(glovecount + " gloves");
                    }

                    if (crackerscount >= 1)
                    {
                        Console.WriteLine(crackerscount + " crackers");
                    }
                    Console.WriteLine();
                }

                if (choice == "compute shipping charges")
                {
                    for(int i = 0; i < uptoten; i++)
                    {
                        ship += shippables[i].ShipCost;
                    }

                    Console.WriteLine("Total shipping cost for this order is $" + ship);
                    Console.WriteLine();
                }

                if (choice == "bicycle" || choice == "lawn mower" || choice == "baseball glove" || choice == "crackers")
                {
                    uptoten = 1 + uptoten;
                };

                //if (uptoten <= 9 && finalCompute == true)
                //{
                //    Console.WriteLine("Would you like to choose another action?");
                //    Console.WriteLine();
                //    orderyesno = Console.ReadLine();
                //    orderyesno = orderyesno.ToLower();
                //};

                if (uptoten >= 10)
                {
                    for (int i = 0; i < uptoten; i++)
                    {
                        ship += shippables[i].ShipCost;
                    }

                    Console.WriteLine("Maximum items reached. Loading your order now . . .");
                    Console.WriteLine();
                    Console.WriteLine("Total shipping cost for this order is $" + ship);
                    Console.WriteLine(); 
                    
                    finalCompute = false;

                };

                if (choice == "compute shipping charges" )
                {
                    finalCompute = false;
                }

                };

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine(". . .");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine(". . .");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine(". . .");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Order sent. Your shipping label will be available shortly.");
        }

    }

}