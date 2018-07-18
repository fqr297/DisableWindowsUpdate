using System;

namespace DisableWindowsUpdate
{
    class Program
    {
        //Invoke Menu
        static void Main(string[] args)
        {
            Process ps = new Process();
            Console.WriteLine("============================");
            Console.WriteLine("Welcome");
            Console.WriteLine("============================");
            Console.WriteLine("(d)isable or (e)nable Windows Update");
            Console.Write("Choose action: ");
            string choice = Console.ReadLine();
            if (choice.Equals("d"))
            {
                ps.Disable();
            }
            else if (choice.Equals("e"))
            {
                ps.Enable();
            } else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine("Made by FQR, 2018");
        }
    }
}
