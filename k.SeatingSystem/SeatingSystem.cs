using System;
using System.Collections.Immutable;
using System.Linq;
using Common;

namespace k.SeatingSystem
{
    class SeatingSystem
    {
        private const string testData = @"L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";
        static void Main(string[] args)
        {
            var input = Input.GetInput(11).Split("\n");
            var testInput = testData.Split("\r\n");
            SimulateSeatOccupation(input);
            Console.WriteLine("Hello World!");
        }

        static void SimulateSeatOccupation(string[] input)
        {
            int stateChanges = 0;
            char[][] currentState = input.Select(s=>s.ToCharArray()).ToArray();
            char[][] newState = input.Select(s=>s.ToCharArray()).ToArray();

            Console.WriteLine(CompareState(currentState, newState));

            do
            {
                currentState = newState.Select(ca => ca.ToArray()).ToArray();
                for (int y = 0; y < currentState.Length; y++)
                {
                    for (int x = 0; x < currentState[y].Length; x++)
                    {
                        newState[y][x] = GetNextState(y, x, currentState);
                    }
                }
                stateChanges++;
            } while (!CompareState(currentState, newState));

            int occupiedSeatsAtEnd = 0;
            for (int i = 0; i < currentState.Length; i++)
            {
                for (int j = 0; j < currentState[i].Length; j++)
                {
                    if (currentState[i][j] == '#')
                    {
                        occupiedSeatsAtEnd++;
                    }
                }
                // Console.WriteLine(currentState[i]);
            }
            
            Console.WriteLine($"State Changes before rest : {stateChanges}, Occupied Seats : {occupiedSeatsAtEnd}");
        }

        static bool CompareState(char[][] first, char[][] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < first[i].Length; j++)
                {
                    if (first[i][j] != second[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static int ScanOccupiedSimple(int y, int x, char[][] state)
        {
            int occupied = 0;
            for (int i = y-1; i <= y+1; i++)
            {
                if (i < 0 || i >= state.Length)
                {
                    continue;
                }
                for (int j = x-1; j <= x+1; j++)
                {
                    if (j < 0 || j >= state[i].Length)
                    {
                        continue;
                    }

                    if (state[i][j] == '#')
                    {
                        occupied++;
                    }
                }
            }
            return occupied;
        }

        private static int ScanOccupiedDirectional(int y, int x, char[][] state)
        {
            char[][] visibility = new[]
            {
                new[] {'u', 'u', 'u'},
                new[] {'u', '.', 'u'},
                new[] {'u', 'u', 'u'},
            };
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    int range = 1;
                    char result = 'D';
                    int xIdx = x+j;
                    int yIdx = y+i;
                    while (xIdx >= 0 && xIdx < state[y].Length
                        && yIdx >= 0 && yIdx < state.Length )
                    {
                        if (state[yIdx][xIdx] == 'L' || state[yIdx][xIdx] == '#')
                        {
                            result = state[yIdx][xIdx];
                            break;
                        }
                        range++;
                        xIdx = x + (j * range);
                        yIdx = y + (i * range);
                    }
                    visibility[i+1][j+1] = result;
                }
            }
            return visibility.Select(v => v.Count( chr => chr == '#')).Sum();
        }
        
        private static char GetNextState(int y, int x, char[][] state)
        {
            int occupied = ScanOccupiedDirectional(y,x,state);
            char currentState = state[y][x];
            if (currentState == '.')
            {
                return '.';
            }

            if (occupied > 4 && currentState == '#') return 'L';
            if (occupied == 0 && currentState == 'L') return '#';
            return currentState;
        }
    }
}