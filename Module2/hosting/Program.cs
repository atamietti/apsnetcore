using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .Build();
            host.Run();
            Console.WriteLine("Hello World!");
        }
    }
}
