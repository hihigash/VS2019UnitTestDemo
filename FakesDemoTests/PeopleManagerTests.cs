using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesDemo.Tests
{
    [TestClass()]
    public class PeopleManagerTests
    {
        [TestMethod()]
        public void AddMember_Age_20()
        {
            IPerson person = new Fakes.StubIPerson();
            person.Age = 20;

            var peopleManager = new PeopleManager();
            peopleManager.AddMember(person);
            Assert.AreEqual(1, peopleManager.GetNumberOfMembers());
        }

        [TestMethod()]
        [ExpectedException(typeof(ComplianceException))]
        public void AddMember_Age_17()
        {
            IPerson person = new Fakes.StubIPerson();
            person.Age = 17;

            var peopleManager = new PeopleManager();
            peopleManager.AddMember(person);
        }
    }
}