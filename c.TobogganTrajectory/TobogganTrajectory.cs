using System;
using System.Collections.Generic;
using System.Linq;

namespace c.TobogganTrajectory
{
    class TobboganTrajectory
    {
        static void Main(string[] args)
        {
            string[] splitInput = Input.Data.Split("\n").Select(s => s.Trim()).ToArray();

            Console.WriteLine(CalcStageOne(splitInput, 3, 1));
            Console.WriteLine(CalcStageTwo(splitInput));
            Console.WriteLine("Hello World!");
        }

        public static int CalcStageOne(string[] input, int offsetX, int offsetY)
        {
            int treeCount = 0;

            char treeMarker = '#';
            char emptyMarker = '.';

            int xIdx = 0;
            int yIdx = 0;
            int highestMod = 0;

            for (int i = 0; i < input.Length; i+=offsetY)
            {
                string line = input[yIdx];
                int xMod = xIdx % line.Length; 
                
                if (line[xMod] == treeMarker)
                {
                    treeCount++;
                }
                xIdx += offsetX;
                yIdx += offsetY;
            }

            return treeCount;
        }

        public static long CalcStageTwo(string[] input)
        {
            List<(int, int)> pairs = new List<(int, int)>()
            {
                (1, 1),
                (3, 1),
                (5, 1),
                (7, 1),
                (1, 2),
            };
            
            List<int> multipliers = new List<int>();
            long val = 1;
            foreach ((int x, int y) in pairs)
            {
                multipliers.Add(CalcStageOne(input, x, y));
            }

            foreach (var mul in multipliers)
            {
                val *= mul;
            }
            return val;
        }
    }
}