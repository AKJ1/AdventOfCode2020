using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Common;

namespace j.AdapterArray
{
    class AdapterArray
    {
        private static string TestDataTwo = @"16
10
15
5
1
11
7
19
6
12
4";
        private static string TestData = @"28
33
18
42
31
14
46
20
48
47
24
23
49
45
19
38
39
11
1
32
25
35
8
17
7
9
4
2
34
10
3";
        static void Main(string[] args)
        {
            string rawInput = Input.GetInput(10);
            string[] input = Input.GetInput(10).Split("\n");
            string[] testInput = TestDataTwo.Split("\n");
            CalcJoltDifferences(input);
            CalcAdapterCombinations(input);
            // Console.WriteLine(rawInput);
            Console.WriteLine("Hello World!");
        }

        static void CalcAdapterCombinations(string[] input)
        {
            List<int> prasedInput = input.Select(s => int.Parse(s)).ToList();
            List<int> orderedInput = prasedInput.OrderBy(n => n).ToList();
            orderedInput.Add(orderedInput.Last()+3);
            string s = "";
            foreach (var VARIABLE in orderedInput)
            {
                s += VARIABLE.ToString() +",";
            }

            Console.WriteLine(s);
            List<int> terminatedRegions = new List<int>();
            int regionCounter = 1; // 0 can jump to any.
            int baseInput = orderedInput[0];
            for (int i = 0; i < orderedInput.Count; i++)
            {
                if (orderedInput[i] - baseInput == 3)
                {
                    terminatedRegions.Add(regionCounter);
                    regionCounter = 0;
                }
                regionCounter++;
                baseInput = orderedInput[i];
            }
            Console.WriteLine($"Region Count = {terminatedRegions.Count}");
            List<int> RegionPermutations = new List<int>();
            long total = 1;
            foreach (var region in terminatedRegions)
            {
                var multiplier = FormulaCombinationsTwo(region);
                total *= multiplier;
                RegionPermutations.Add(multiplier);
                // total *= FormulaCombinationsTwo(region);
            }
            // var comboWombos = FormulaCombinationsTwo(11);
            // Console.WriteLine(comboWombos);
            
            Console.WriteLine($"Possible adapter permutations are : { total }");
        }
        static void CalcJoltDifferences(string[] input)
        {
            List<int> prasedInput = input.Select(s => int.Parse(s)).ToList();
            List<int> orderedInput = prasedInput.OrderBy(n => n).ToList();
            int baseInput = orderedInput[0];
            Dictionary<int, int> deltaCounts = new Dictionary<int, int>()
            {
                {1, 1}, //1 Jolt difference between 0 and first device.
                {2, 0},
                {3, 1} // 3 jolt difference between highest adapter and target
            };
            for (int i = 1; i < orderedInput.Count; i++)
            {
                if (orderedInput[i] - baseInput > 3)
                {
                    Console.WriteLine("ERROR, Wrong Input");
                    break;
                }
                var newDelta = orderedInput[i] - baseInput;
                deltaCounts[newDelta]++;
                baseInput = orderedInput[i];
            }


            foreach (var cnt in deltaCounts)
                Console.WriteLine($"difference: {cnt.Key}\t occurances: {cnt.Value}");
        }

        static int FormulaCombinationsTwo(int sequenceElements, bool alreadySubbed = false)
        {
            if (sequenceElements <= 3)
            {
                int power = sequenceElements == 1 ? 0 :
                    alreadySubbed? sequenceElements - 1:
                    sequenceElements-2;
                return (int)Math.Pow(2,  power);
            }
            var val = 0;
            for (int i = 1; i <= 3; i++)
            {
                val += FormulaCombinationsTwo(sequenceElements-i);
            }
            return val;
        }
    }
}