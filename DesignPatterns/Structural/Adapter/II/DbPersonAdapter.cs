using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Adapter.II
{
    class DbPersonAdapter : IPerson
    {
        private DbPerson person;

        public DbPersonAdapter(DbPerson person)
        {
            this.person = person;
        }

        public string Name => $"{person.FirstName} {person.LastName}";

        public int Age => DateTime.Now.Year - person.BirthDate.Year;
    }
}
