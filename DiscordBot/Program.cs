﻿using System;
using System.IO;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        { 
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
