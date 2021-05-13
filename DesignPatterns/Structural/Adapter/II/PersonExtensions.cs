using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public static class DbPersonExtensions
    {
        public static Person ToPerson(this DbPerson dbPerson)
        {
            return new Person() { Name = $"{dbPerson.FirstName} {dbPerson.LastName}", Age = DateTime.Now.Year - dbPerson.BirthDate.Year };
        }
    }
}
