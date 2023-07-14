using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            string name = "Tom";

            Console.WriteLine("Hello my name is " + name + ", I am " + age + "years old.");

            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);

            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            Console.WriteLine(@"Hello my name is this 
            and I am a this job.");
        }
    }
}
