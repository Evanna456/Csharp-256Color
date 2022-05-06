﻿using Pastel;
using System;

namespace Csharp_256Color
{
    class Program
    {
        private static void Main(string[] args)
        {
            var spectrum = new (string color, string letter)[]{
             ("#000000", "0"),
             ("#800000", "1"),
             ("#008000", "2"),
             ("#808000", "3"),
             ("#000080", "4"),
             ("#3FBDB6", "5"),
             ("#800080", "6"),
             ("#c0c0c0", "7"),
             ("#808080", "8"),
             ("#ff0000", "9"),
             ("#00ff00", "10"),
             ("#ffff00", "11"),
             ("#0000ff", "12"),
             ("#ff00ff", "13"),
             ("#00ffff", "14"),
             ("#ffffff", "15"),
             ("#000000", "16"),
             ("#00005f", "17"),
             ("#000087", "18"),
             ("#0000af", "19"),
             ("#0000d7", "20"),
             ("#0000ff", "21"),
             ("#005f00", "22"),
             ("#005f5f", "23"),
             ("#005f87", "24"),
             ("#005faf", "25"),
             ("#005fd7", "26"),
             ("#005fff", "27"),
             ("#008700", "28"),
             ("#00875f", "29"),
             ("#008787", "30"),
        };
            Console.WriteLine(string.Join("", spectrum.Select(s => s.letter.Pastel(s.color))));
        }
    }
}