using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Jennifer"},
                {"age", "25"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Jimmy"},
                {"age", "31"}
            });

            myFamily.Add("dad", new Dictionary<string, string>(){ 
                {"name", "Bob"},
                {"age", "57"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){ 
                {"name", "Judy"},
                {"age", "57"}
            });


            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily )
            {
                Console.WriteLine(member.Value["name"] + " is my " + member.Key + " and they are " + member.Value["age"] + " years old." ); 
            }

            // /////////////////////////// the long way to do it //////////////////////
            
            // string memberName = "";
            // string memberAge = "";
            // int counter = 0;

            // foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            // {
            //     foreach(KeyValuePair<string, string> property in member.Value)
            //     {
            //         counter ++;
            //         if (counter == 1)
            //         {
            //             memberName = property.Value;
            //         }
            //         else{
            //             memberAge = property.Value;
            //             counter = 0;
            //         }
            //     }
            //     Console.WriteLine(memberName + " is my " + member.Key + " and they are  " + memberAge + " years old.");
            // } 
        }
    }
}
