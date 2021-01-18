using System;
using System.Collections.Generic;

namespace exercDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "9932323211";
            cookies["phone"] = "5423012341";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            
            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("there is no 'email' key ");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("All cookies: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
