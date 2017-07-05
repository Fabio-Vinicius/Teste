using People.Service;
using PersonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace People.Service
{
    public class PersonService: IPersonService
    {
        public List<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person() {FirstName="Jonh", LastName="King", StartDate=DateTime.Parse("10/17/1990"), Rating=6},
                new Person() { FirstName = "Mary", LastName = "Jack", StartDate = DateTime.Parse("10/17/1990"), Rating = 6 },
                new Person() { FirstName = "Ann", LastName = "Inner", StartDate = DateTime.Parse("10/17/1990"), Rating = 6 },
                new Person() { FirstName = "Mike", LastName = "Blass", StartDate = DateTime.Parse("10/17/1990"), Rating = 6 }
            };

            return p;
        }

        public Person GetPerson(string lastName)
        {
            throw new NotSupportedException();
        }

        public void AddPerson(Person newPerson)
        {
            // Method intentionally left empty.
        }

        public void UpdatePerson(string LastName, Person updated)
        {
            // Method intentionally left empty.
        }

        public void DeletePerson(string LastName)
        {
            // Method intentionally left empty.
        }

        public void UpdatePeople(List<Person> updatePeople)
        {

        }
    }
}
