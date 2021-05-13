using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private IDatabase database;
        private int semaphoreSlimCount = 1;
        private SemaphoreSlim semaphoreSlim;

        public DatabaseProxy(IDatabase database)
        {
            semaphoreSlim = new SemaphoreSlim(semaphoreSlimCount);
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (database == null)
                database = new Database();

            await semaphoreSlim.WaitAsync();
            var result = await database.RequestAsync(parameter);
            semaphoreSlim.Release();

            if(semaphoreSlim.CurrentCount == semaphoreSlimCount)
            {
                if (database is IDisposable disposable)
                    disposable.Dispose();
                database = null;
            }    

            return result;
        }
    }
}
