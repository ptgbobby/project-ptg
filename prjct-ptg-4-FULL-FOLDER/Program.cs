using System;

namespace ptg_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Chose an option");
            Console.WriteLine("1 - Patient result loger ");
            Console.WriteLine("2 - Health Calculator");
            int ress = int.Parse(Console.ReadLine());

            if (ress == 1)
            {

                doctor doc = new doctor();
                doc.name = "Boyko";
                doc.username = "admin";
                doc.pass = "admin";

                Console.Write("Enter username: ");
                string user = Console.ReadLine();
                Console.Write("Enter password: ");
                string pass = Console.ReadLine();
                //login
                if (user == doc.username && pass == doc.pass)
                {
                    doc.printhi();
                    Console.Write("Enter patinet name: ");
                    doc.pname = Console.ReadLine();
                    Console.Write("Enter patinet age: ");
                    doc.page = int.Parse(Console.ReadLine());
                    Console.Write("Enter patinet test: ");
                    doc.ptest = Console.ReadLine();
                    Console.Write("Enter patinet res (Positive, +, positive, negative, -, Negative): ");
                    doc.presults = Console.ReadLine();
                    Console.WriteLine("");
                    doc.resp();
                }
                else if (user != doc.username && pass != doc.pass)
                {
                    Console.WriteLine("Im sorry. Invalid data. You cant use this. Please type 1 to exit");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                }
                } else if (ress == 2) {
                    calculator calc = new calculator();
                    Console.Write("Enter your name: ");
                    calc.name = Console.ReadLine();
                    Console.Write("Enter your age: ");
                    calc.age = int.Parse(Console.ReadLine());
                    Console.Write("Enter your weight: ");
                    calc.weight = int.Parse(Console.ReadLine());
                    Console.Write("Enter your height: ");
                    calc.height = int.Parse(Console.ReadLine());
                    calc.print();
                    calc.calculate();



                } else if (ress != 1 || ress != 2)
                {
                    Console.WriteLine("Invalid input. Try with 1 or 2.");
                } else
                {
                    Console.WriteLine("Unkown error!");
                }
            }
        }
    }

