using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common
{
    public static class Input
    {
        public const string InputFilesPath = @"C:\Users\Ace\RiderProjects\AoC2020\a.Common\bin\Debug\netcoreapp3.1\inputs\";

        private static string baseLink = "https://adventofcode.com/";
        private static string AocUrl => baseLink + "2020/day/";

        public static string GetInput(int dayIdx)
        {
            return File.ReadAllText(InputFilesPath + "/" + dayIdx + ".txt").Trim();
        }

        public async static Task DownloadInput()
        {
            HttpClient client = new HttpClient(); 
            char ds = Path.DirectorySeparatorChar;
            string cwd = Environment.CurrentDirectory;
            
            string filesPath = cwd + $"{ds}inputs{ds}";
            Directory.CreateDirectory(filesPath);
            var uri = new Uri(baseLink);
            client.BaseAddress = uri;
            List<Task> taskList = new List<Task>();
            client.DefaultRequestHeaders.Add("Cookie", "session="); // Get this from the cookies on the website
            for (int i = 1; i < 26; i++)
            {
                var getRequest = client.GetAsync($"{AocUrl}{i}/input");
                taskList.Add(getRequest);
                int num = i;
                var result = await getRequest;
                Console.WriteLine("Request Complete!");
                if (result.IsSuccessStatusCode)
                {
                    var inputVal = await result.Content.ReadAsStringAsync();
                    Console.WriteLine($"Downloaded Input for Day {num}");
                    File.WriteAllText($"{filesPath}/{num}.txt", inputVal);
                }
            }
            Console.WriteLine($"Replace the input static location with: \n{filesPath}");
        }
    }
}