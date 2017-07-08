using System;
using System.Collections.Generic;

namespace hashCarSets
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();

            //Add four of your favorite car model names to the set.
            Showroom.Add("Accord");
            Showroom.Add("Civic");
            Showroom.Add("Pathfinder");
            Showroom.Add("Tesla");

            //Print to the console how many cars are in your show room.
            Console.WriteLine(Showroom.Count);

            //Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Accord");

            //Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }
            //Console.WriteLine(string.Join(", ", Showroom));

            //Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("White Car");
            UsedLot.Add("Blue Car");
            
            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            Console.WriteLine("after UnionWith");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            //You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Accord");
            Console.WriteLine("after removing accord");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            //Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Acura");
            Junkyard.Add("Civic");
            Junkyard.Add("Ford Focus");
            Junkyard.Add("Truck");
            Junkyard.Add("Tesla");

            //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            Showroom.IntersectWith(Junkyard);
            Console.WriteLine("after intersectwith");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            //Use the Remove() method to remove any cars that you acquired from the junkyard that you want in your showroom.
            Showroom.Remove("Truck");
        }
    }
}
