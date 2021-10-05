namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> list = new List<string>();
            ShowMembers(list);
        }

        private static void ShowMembers(ICollection<string> members)
        {
            members.Add("Nisse");
        }
    }
}
