﻿using System;

namespace DockerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"TEST={Environment.GetEnvironmentVariable("TEST")}");
        }
    }
}
