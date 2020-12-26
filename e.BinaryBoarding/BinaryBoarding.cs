using System;
using System.Linq;
using d.PassportProcessing;

namespace e.BinaryBoarding
{
    /// <summary>
    /// You board your plane only to discover a new problem: you dropped your boarding pass! You aren't sure which seat is yours, and all of the flight attendants are busy with the flood of people that suddenly made it through passport control.
    // You write a quick program to use your phone's camera to scan all of the nearby boarding passes (your puzzle input); perhaps you can find your seat through process of elimination.
    // Instead of zones or groups, this airline uses binary space partitioning to seat people. A seat might be specified like FBFBBFFRLR, where F means "front", B means "back", L means "left", and R means "right".
    // The first 7 characters will either be F or B; these specify exactly one of the 128 rows on the plane (numbered 0 through 127).
    // Each letter tells you which half of a region the given seat is in.
    // Start with the whole list of rows;
    // the first letter indicates whether the seat is in the front (0 through 63) or the back (64 through 127).
    // The next letter indicates which half of that region the seat is in, and so on until you're left with exactly one row.
    /// </summary>
    class BinaryBoarding
    {
        static void Main(string[] args)
        {
            string[] parsedPositions = Input.Data.Split("\r\n");
            int[] values = parsedPositions.Select(pp => GetId(pp)).OrderByDescending(i => i).ToArray();

            var highestValue = values.First();
            var lastIndex = values.Length-1;
            for (int i = 0; i < lastIndex; i++)
            {
                if (values[i] < highestValue - i)
                {
                    Console.WriteLine("Answer is " + (values[i]+1));
                    break;
                }
            }
            
            foreach (var pos in parsedPositions)
            {
                PositionToInt(pos);
            }

            Console.WriteLine("Hello World!");
        }

        static int GetId(int row, int col)
        {
            return row * 8 + col;
        }

        static int GetId(string rawInput)
        {
            var val = PositionToInt(rawInput);
            return GetId(val.row, val.col);
        }

        static (int row, int col) PositionToInt(string posInput)
        {
            string rowSpecifier = posInput.Substring(0, 7);
            string binaryRow = rowSpecifier.Replace("F", "0").Replace("B", "1");

            string colSpecifier = posInput.Substring(7, 3);
            string binaryCol = colSpecifier.Replace("L", "0").Replace("R", "1");

            int parsedRow = Convert.ToInt32(binaryRow, 2);
            int parsedCol = Convert.ToInt32(binaryCol, 2);
            return (parsedRow, parsedCol);
        }
    }
}
