using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PeopleRepository
    {
        public Person[] GetPeople()
        {
            var people = new Person[]
            {
                new Person() { FirstName = "John", LastName = "King", Rating = 7, StartDate = DateTime.Parse("01/26/1994") },
                new Person() { FirstName = "Mike", LastName = "Dylan", Rating = 7, StartDate = DateTime.Parse("01/26/1994") },
                new Person() { FirstName = "Peter", LastName = "May", Rating = 7, StartDate = DateTime.Parse("01/26/1994") }
            };

            return people;
        }
        //public PersonLibrary GetPerson(string lastName)
        //{

        //}
        //public void AddPerson(PersonLibrary newPerson)
        //{
        //}
        //public void UpdatePerson(string lastName, PersonLibrary updatePerson)
        //{

        //}
        //public void DeletePerson (string lastName)
        //{

        //}
        //public void Updatepeople(List<PersonLibrary> updatePeople)
        //{

        //}
    }
}
