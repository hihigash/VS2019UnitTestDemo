using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesDemo
{
    public class ComplianceException : Exception
    {
        // Noting todo.
    }

    public class PeopleManager
    {
        private List<IPerson> People { get; } = new List<IPerson>();

        public void AddMember(IPerson person)
        {
            if (person.Age <= 17)
            {
                throw new ComplianceException();
            }

            People.Add(person);
        }

        public int GetNumberOfMembers()
        {
            return People.Count;
        }
    }
}
