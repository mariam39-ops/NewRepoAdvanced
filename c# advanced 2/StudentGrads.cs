using System;
using System.Collections.Generic;
using System.Text;

namespace c__advanced_2
{
    internal class StudentGrads
    {
        //answer 1
      static void Main(string[] args)
            {
                List<int> grades = new List<int>()
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

                foreach (int x in grades)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine(grades.Count);
                Console.WriteLine(grades.First());
                Console.WriteLine(grades.Last());

                grades.Sort();

                foreach (int x in grades)
                {
                    Console.WriteLine(x);
                }

                int result = grades.First(x => x > 90);
                Console.WriteLine(result);

                var failed = grades.Where(x => x < 75).ToList();

                foreach (int x in failed)
                {
                    Console.WriteLine(x);
                }

                grades.RemoveAll(x => x < 75);

                bool check = grades.Any(x => x == 100);
                Console.WriteLine(check);

                List<string> newGrades = grades.Select(x => "Grade: " + x).ToList();

                foreach (string x in newGrades)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }

