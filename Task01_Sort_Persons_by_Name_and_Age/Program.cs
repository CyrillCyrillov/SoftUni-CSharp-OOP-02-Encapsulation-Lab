using System;
using System.Linq;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());
            List<Person> names = new List<Person>();

            for (int i = 1; i <= linesNumber; i++)
            {
                string[] nextLineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person nextName = new Person(nextLineData[0], nextLineData[1], int.Parse(nextLineData[2]));

                names.Add(nextName);

            }

            names.OrderBy(p => p.FirstName).ThenBy(n => n.Age).ToList().ForEach(n => Console.WriteLine(n.ToString()));

            //Console.WriteLine("Hello World!");
        }
    }
}
