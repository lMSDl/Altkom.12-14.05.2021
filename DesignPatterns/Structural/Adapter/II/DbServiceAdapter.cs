using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Adapter.II
{
    class DbServiceAdapter : IPeopleService
    {
        private DbPeopleService dbService;

        public DbServiceAdapter(DbPeopleService dbService)
        {
            this.dbService = dbService;
        }

        public IEnumerable<Person> Get()
        {
            var people = dbService.Get();
            //return people.Select(x => new DbPersonAdapter(x));
            return people.Select(x => x.ToPerson());
        }
    }
}
