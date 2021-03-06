﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Kevin Hunter";
            string password = "topsecret";

            Console.Write("Enter a message to post:");
            string message = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("[Facebook]");
            SocialMedia facebook = new Facebook(username, password);
            facebook.PostMessage(message);

            Console.WriteLine();

            Console.WriteLine("[Twitter]");
            SocialMedia Twitter = new Twitter(username, password);
            Twitter.PostMessage(message);

            Console.ReadKey();
        }
    }
}
