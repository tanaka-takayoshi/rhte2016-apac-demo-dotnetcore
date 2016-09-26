using System;
using System.Runtime.InteropServices;

namespace SelfContainedApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Built on Windows, Running on {RuntimeInformation.OSDescription}");
            Console.ReadLine();
        }
    }
}
