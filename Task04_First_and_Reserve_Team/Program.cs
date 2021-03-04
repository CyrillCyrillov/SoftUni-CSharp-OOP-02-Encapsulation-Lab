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

            

            Team team = new Team("SoftUni");

            foreach (Person person in names)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            //Console.WriteLine("Hello World!");
        }
    }
}
