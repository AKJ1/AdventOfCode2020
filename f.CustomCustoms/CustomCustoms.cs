using System;
using System.Linq;
using Common;

namespace f.CustomCustoms
{
    class CustomCustoms
    {
        static void Main(string[] args)
        {
            string input = Input.GetInput(6);
            string[] groups = input.Split("\n\n");
            Console.WriteLine(CalcPhaseOne(groups));
            Console.WriteLine(CalcPhaseTwo(groups));
        }

        static int CalcPhaseOne(string[] groups) => groups.Sum(g => g.Replace("\n", "").Distinct().Count());
        
        static int CalcPhaseTwo(string[] groups)
        {
            return groups.Sum(grp =>
            {
                var people = grp.Split("\n");
                var distinctAnswers = grp.Replace("\n", "").Distinct();
                var counts = distinctAnswers.Count(c => people.Count(record => record.Contains(c)) == people.Length);
                return counts;
            });
        }
    }
}