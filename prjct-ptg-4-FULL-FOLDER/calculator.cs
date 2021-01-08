using System;
namespace ptg_project
{
    public class calculator
    {
        public calculator()
        {
        }
        public string name;
        public int age;
        public int weight;
        public int height;

        public void print()
        {
            Console.WriteLine($"Hello {name}. Enter your info.");
        }

        public void calculate()
        {
            if (height >= 160 && weight <= 70 && age > 10 || age < 40)
            {
                Console.WriteLine("All is fine");
            } else if (height <= 160 && weight >= 70 && age > 10 || age < 40)
            {
                Console.WriteLine("Thats bad.");
            } else if (weight > 100)
            {
                Console.WriteLine("Thats too bad.");
            } else if (weight > 85 && age < 20)
            {
                Console.WriteLine("GO TO THE GYM");
            } else if (age <= 10)
            {
                Console.WriteLine("You are small.");
            } else if (weight < 70 && weight >= 45)
            {
                Console.WriteLine("Very good");
            } else if ( weight < 45 && height < 130 && age < 10)
            {
                Console.WriteLine("You can not use this. Try with another value.");
            } else if (age > 10 && age < 90 && weight > 30 && weight < 90 && height > 140 && height < 210)
            {
                Console.WriteLine("normal");
            }
            else
            {
                Console.WriteLine("Unkown error");
            }
        }
    }
}
