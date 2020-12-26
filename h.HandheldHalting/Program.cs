using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace h.HandheldHalting
{
    class Program
    {
        private class Instruction
        {
            public string value;
            public bool isExecuted;
            public Instruction(string instruction)
            {
                this.value = instruction;
                this.isExecuted = false;
            }
        }
        
        private static long acc;
        private static List<Instruction> instructions = new List<Instruction>();
        static void Main(string[] args)
        {
            string[] parsedInput = Input.GetInput(8).Split("\n");
            foreach (var line in parsedInput)
            {
                instructions.Add(new Instruction(line));
            }
            Simulate(); // prints answer
            for (int i = 0; i < instructions.Count(); i++)
            {
                if (instructions[i].value.Contains("jmp") || instructions[i].value.Contains("nop"))
                {
                    foreach (var item in instructions)
                    {
                        item.isExecuted = false;
                    }
                    string initialInstruction = instructions[i].value;
                    if (instructions[i].value.Contains("jmp"))
                    {
                        instructions[i].value = instructions[i].value.Replace("jmp", "nop");
                    }
                    else
                    {
                        instructions[i].value = instructions[i].value.Replace( "nop","jmp");
                    }
                    if (Simulate())
                    {
                        Console.WriteLine($"Answer is {acc}");
                        break;
                    }
                    instructions[i].value = initialInstruction;
                }
            }
            Console.WriteLine("Hello World!");
        }

        static bool Simulate()
        {
            acc = 0;
            var instructionCount = instructions.Count;
            bool programComplete = false;
            for (int i = 0; i < instructionCount; i+=0)
            {
                // Console.WriteLine("insruction index is " + i);
                if(instructions[i].isExecuted){break;}
                instructions[i].isExecuted = true;
                string[] split = instructions[i].value.Split(" ");
                int val = int.Parse(split[1].Replace("+", ""));
                switch (split[0])
                {
                    case "nop":
                        break;
                    case "acc":
                        acc += val;
                        break;
                    case "jmp":
                        i += val;
                        continue;
                }
                i++;
                programComplete = i == instructionCount - 1;
            }
            Console.WriteLine(acc);
            return programComplete;
        }
    }
}