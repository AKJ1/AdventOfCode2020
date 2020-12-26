using System;
using System.Linq;
using Common;

namespace a.ReportRepair
{
    class ReportRepair
    {

        static void Main(string[] args)
        {

            int[] parsedData = Input.GetInput(1)
                .Split("\n")
                .Select(itm => int.Parse(itm))
                .ToArray();
            long result = 0;
            for (int i = 0; i < parsedData.Length; i++)
            {
                for (int j = 0; j < parsedData.Length; j++)
                {
                    for (int k = 0; k < parsedData.Length; k++)
                    {
                        if(i == j || i == k || j == k) continue;;
                        if (parsedData[i] + parsedData[j] + parsedData[k] == 2020)
                        {
                            result = parsedData[i] * parsedData[j] * parsedData[k];
                            break;
                        }
                    }
                    if (result != 0) break;
                }
                if (result != 0) break;
            }
            
            Console.WriteLine(result);
        }
    }
}