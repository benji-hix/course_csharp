﻿// See https://aka.ms/new-console-template for more information
Random rand = new Random();

for (int i = 1; i<= 10; i++) {
    Console.WriteLine(rand.Next(11));
}