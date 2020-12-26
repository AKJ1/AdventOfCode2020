using System;
using System.Threading.Tasks;

namespace Common
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Input.DownloadInput();
            Console.WriteLine("Hello World!");
        }
    }
}