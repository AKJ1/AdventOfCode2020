using System;
using System.Linq;

namespace b.PasswordPhillosophy
{
    class PasswordPhillosophy
    {
        static void Main(string[] args)
        {
            string[] passwordLines = Input.Data.Split("\n");
            var validPhaseOne = CalcStageOne(passwordLines);
            Console.WriteLine(validPhaseOne);
            
            var validPhaseTwo = CalcStageTwo(passwordLines);
            Console.WriteLine(validPhaseTwo);
        }

        static long CalcStageTwo(string[] inputs)
        {
            long validCounter = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                string[] components = inputs[i].Split(" ");
                string[] indecies = components[0].Split("-");
                
                int lowerBound = int.Parse(indecies[0])-1;
                int upperBound = int.Parse(indecies[1])-1;
                char targetChar = components[1].First();
                
                string input = components[2];
                if (input[lowerBound] == targetChar ^ input[upperBound] == targetChar)
                {
                    validCounter++;
                }
            }
            return validCounter;
        }

        static long CalcStageOne(string[] inputs)
        {
            long validCounter = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                string[] components = inputs[i].Split(" ");
                string[] bounds = components[0].Split("-");
                
                int lowerBound = int.Parse(bounds[0]);
                int upperBound = int.Parse(bounds[1]);
                char targetChar = components[1].First();

                string input = components[2];
                int occurances = input.Count(c => c == targetChar);
                if (occurances >= lowerBound && occurances <= upperBound)
                {
                    validCounter++;
                }
            }
            return validCounter;
        }
    }
}