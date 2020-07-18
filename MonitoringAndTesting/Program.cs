using Data.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MonitoringAndTesting
{
    class Program
    {
        private static IConfigurationRoot config;
        static void Main(string[] args)
        {
            //TagRepository tagRepository = new TagRepository("Server =DESKTOP-OUSGEAN\\SQLEXPRESS; Database =DoDWebSite; Trusted_Connection = True;");

            //var list = tagRepository.GetAll();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Initialize();
            var repository = CreateRepository();
            var result = repository.GetAll();
            result.Output();
        }
        private static void Initialize()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            config = builder.Build();
        }
        private static ITagRepository CreateRepository()
        {
            return new TagRepository("Server =DESKTOP-OUSGEAN\\SQLEXPRESS; Database =DoDWebSite; Trusted_Connection = True;");
        }
    }
}
