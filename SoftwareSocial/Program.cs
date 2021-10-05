using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var random = new Random();

            var Group1 = new List<string>();
            var Group2 = new List<string>();
            var Group3 = new List<string>();
            var Group4 = new List<string>();

            #region ListMembers

            // Store in a TextFile
            // Members File

            List<string> members = new List<string>
            {
                "Brandon-W",
                "Elwin",
                "Fran",
                "Sunny",
                "Ulka",
                "Darcy",
                "Ashley",
                "Ian",
                "Pinali",
                "Brandon-T",
                "Alec",
                "Sujan",
                "Moeenqaisar",
                "Sharif",
                "Arjan",
                "Sagrika",
                "Mamatha",
                "Teresa",
                "Parul",
                "Suren",
                "Deep",
                "Ghazaleh",
                "Dawa",
                "Lilit",
                "Eddie",
                "Michael",
                "Jackie",
                "Jiten",
                "Shadi",
                "Ansar",
                "Rajan",
                "Manoj",
                "Zlatko",
                "Christelle",
                "Meaghan",
                "Jamie"
            };

            List<string> GameHosts = new List<string>
            {
                "Brandon-W",
                "Sunny",
                "Ulka",
                "Darcy",
                "Ian",
                "Pinali",
                "Brandon-T",
                "Sujan",
                "Moeenqaisar",
                "Sagrika",
                "Deep",
                "Ghazaleh",
                "Dawa",
                "Lilit",
                "Eddie",
                "Michael",
                "Jackie",
                "Jiten",
                "Zlatko",
                "Meaghan",
                "Jamie"
            };

            // PRINTING LIST OF GAME HOSTS AVAILABLE 
            Console.WriteLine($"GameHosts:");
            foreach (var Host in GameHosts)
            {
                Console.WriteLine($"Name: {Host}");
            }

            #endregion ListMembers

            #region SelectHosts

            // The following code can be stored in one method
            // Change this thing

            //PICK HOST 1
            Console.WriteLine($"Select Host 1: ");
            string Host1;
            string ReadHost1 = Console.ReadLine();
            if (members.Contains(ReadHost1) == true)
            {
                Host1 = ReadHost1;
                members.Remove(Host1);
                Group1.Add(Host1);
            }
            else
            {
                Console.WriteLine($"Select Another Host: ");
                string Host1BackUp = Console.ReadLine();
                Host1 = Host1BackUp;
                Group1.Add(Host1);
            }

            //PICK HOST 2
            Console.WriteLine($"Select Host 2: ");
            string Host2;
            string ReadHost2 = Console.ReadLine();
            if (members.Contains(ReadHost2) == true)
            {
                Host2 = ReadHost2;
                members.Remove(Host2);
                Group2.Add(Host2);
            }
            else
            {
                Console.WriteLine($"Select Another Host: ");
                string Host2BackUp = Console.ReadLine();
                Host2 = Host2BackUp;
                Group2.Add(Host2);
            }

            //PICK HOST 3
            Console.WriteLine($"Select Host 3: ");
            string Host3;
            string ReadHost3 = Console.ReadLine();
            if (members.Contains(ReadHost3) == true)
            {
                Host3 = ReadHost3;
                members.Remove(Host3);
                Group3.Add(Host3);
            }
            else
            {
                Console.WriteLine($"Select Another Host: ");
                string Host3BackUp = Console.ReadLine();
                Host3 = Host3BackUp;
                Group3.Add(Host3);
            }

            //PICK HOST 4
            Console.WriteLine($"Select Host 4: ");
            string Host4;
            string ReadHost4 = Console.ReadLine();
            if (members.Contains(ReadHost4) == true)
            {
                Host4 = ReadHost4;
                members.Remove(Host4);
                Group4.Add(Host4);
            }
            else
            {
                Console.WriteLine($"Select Another Host: ");
                string Host4BackUp = Console.ReadLine();
                Host4 = Host4BackUp;
                Group4.Add(Host4);
            }

            Console.Clear();

            #endregion SelectHosts

            // Randomize members List
            var shuffled = members.OrderBy(x => random.Next()).ToList();
            var quarter = shuffled.Count / 4;

            Group1.AddRange(shuffled.Take(quarter));
            Group2.AddRange(shuffled.Skip(quarter).Take(quarter));
            Group3.AddRange(shuffled.Skip(quarter * 2).Take(quarter));
            Group4.AddRange(shuffled.Skip(quarter * 3).Take(quarter));

            Console.WriteLine("Group 1:");
            Group1.ForEach(person => Console.WriteLine($"{person}"));
            Console.WriteLine("\nGroup 2:");
            Group2.ForEach(person => Console.WriteLine($"{person}"));
            Console.WriteLine("\nGroup 3:");
            Group3.ForEach(person => Console.WriteLine($"{person}"));
            Console.WriteLine("\nGroup 4:");
            Group4.ForEach(person => Console.WriteLine($"{person}"));

        }

    }

}
