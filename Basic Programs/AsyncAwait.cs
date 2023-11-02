using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class AsyncAwait
    {
        public async static void Example()
        {
            List<string> urls = new List<string>
        {
            "https://www.example.com",
            "https://www.google.com",
            "https://www.microsoft.com"
        };

            Console.WriteLine("Downloading web pages asynchronously...");

            List<Task<string>> downloadTasks = new List<Task<string>>();

            foreach (string url in urls)
            {
                downloadTasks.Add(DownloadWebPageAsync(url));
            }

            await Task.WhenAll(downloadTasks);

            foreach (Task<string> task in downloadTasks)
            {
                string content = await task;
                Console.WriteLine($"Downloaded {content.Length} bytes from a web page.");
            }

            Console.WriteLine("All web pages downloaded.");
        }
        static async Task<string> DownloadWebPageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(url);
                return content;
            }
        }
    }
}
