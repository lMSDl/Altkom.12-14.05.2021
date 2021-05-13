using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Proxy
{
    public class Database : IDatabase, IDisposable
    {
        private int _connectionCounter = 0;
        private const int maxConnections = 5;

        public Database()
        {
            Console.WriteLine("Database service opened");
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_connectionCounter >= maxConnections)
            {
                Console.WriteLine($"Request {parameter} dropped!");
                return null;
            }

            Console.WriteLine($"Opening connection {++_connectionCounter}");
            await Task.Delay(1000);

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter--})");
            return parameter;
        }

        public void Dispose()
        {
            Console.WriteLine("Database service closed");
        }
    }
}
