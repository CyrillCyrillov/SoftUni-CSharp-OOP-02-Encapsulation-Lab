using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int linesNumbers = int.Parse(Console.ReadLine());
            List<Person> names = new List<Person>();

            for (int i = 1; i <= linesNumbers; i++)
            {
                string[] nextLineDatas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person nextName = new Person(nextLineDatas[0], nextLineDatas[1], int.Parse(nextLineDatas[2]), decimal.Parse(nextLineDatas[3]));
                names.Add(nextName);
            }

            int percentage = int.Parse(Console.ReadLine());

            foreach (Person name in names)
            {
                name.IncreaseSalary(percentage);
                Console.WriteLine(name);
            }





            //Console.WriteLine("Hello World!");
        }
    }
}
