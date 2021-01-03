using System;
using System.Collections.Generic;
using System.Numerics;
using Common;

namespace l.RainRisk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Input.GetInput(12).Split("\n");
            MoveShip(input);
            Console.WriteLine("Hello World!");
        }

        private static Dictionary<int, (int x, int y)> DirectionByRotation = new Dictionary<int, (int x, int y)>()
        {
            {0, (1, 0)},
            {90, (0, -1)},
            {180, (-1, 0)},
            {270, (0, 1)},
        };

        private static (int x, int y) RotatedWaypoint(int degrees)
        {
            switch (degrees)
            {
                case 0:
                    return waypointOffset;
                case 90:
                    return (waypointOffset.y, -waypointOffset.x);
                case 180:
                    return (-waypointOffset.x, -waypointOffset.y);
                case 270:
                    return (-waypointOffset.y, waypointOffset.x);
            }
            return waypointOffset;
        }

        private static (int x, int y) waypointOffset = (10, 1);

        static void MoveShip(string[] input)
        {
            (int x, int y) position = (0, 0);
            (int x, int y) positionPhaseTwo = (0, 0);
            int rotationAccumulator = 0;
            Func<int, int> rotation = (val) =>
                val < 0 ? (val + 360) % 360 : val % 360;
            
            for (int i = 0; i < input.Length; i++)
            {
                string command = input[i].Substring(0, 1);
                int value = int.Parse( input[i].Substring(1));
                switch (command)
                {
                    case "N":
                        position.y += value;
                        waypointOffset.y += value;
                        break;
                    case "S":
                        position.y -= value;
                        waypointOffset.y -= value;
                        break;
                    case "E":
                        position.x += value;
                        waypointOffset.x += value;
                        break;
                    case "W":
                        position.x -= value;
                        waypointOffset.x -= value;
                        break;
                    case "R":
                        rotationAccumulator += value;
                        waypointOffset = RotatedWaypoint(rotation(value));
                        break;
                    case "L":
                        rotationAccumulator -= value;
                        waypointOffset = RotatedWaypoint(rotation(-value));
                        break;
                    case "F":
                        position.x += DirectionByRotation[rotation(rotationAccumulator)].x * value;
                        position.y += DirectionByRotation[rotation(rotationAccumulator)].y * value;
                        positionPhaseTwo.x += waypointOffset.x * value;
                        positionPhaseTwo.y += waypointOffset.y * value;
                        break;
                }
            }

            var extraAnswer = positionPhaseTwo;
            extraAnswer.x += waypointOffset.x;
            extraAnswer.y += waypointOffset.y;
            Console.WriteLine($"Manhattan distance travelled, phase one : {ManhattanDistance(position)}");
            Console.WriteLine($"position is x:{positionPhaseTwo.x}, y:{positionPhaseTwo.y}");
            Console.WriteLine($"Manhattan distance travelled, phase two : {ManhattanDistance(positionPhaseTwo)}");
            Console.WriteLine($"Manhattan distance travelled, phase two with waypoint added. : {ManhattanDistance(extraAnswer )}");
        }
        
        static int ManhattanDistance((int x, int y) position)
        {
            return Math.Abs(position.x) + Math.Abs(position.y);
        }
    }
}