﻿using System;

namespace MaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximum find = new FindMaximum();
            Console.WriteLine(find.MaximumStringNumber("Apple", "Banana", "Carrot"));
        }
    }
}
