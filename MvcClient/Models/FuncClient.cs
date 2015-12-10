using MvcClient.ServiceReferencePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcClient.Models
{
    class FuncClient
    {
        ServicePersonClient client = new ServicePersonClient();
        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            var person = client.GetPersons();
            persons = person.OfType<Person>().ToList();
            return persons;
        }
        public void CreatePersons(Person person)
        {
            client.CreateNewPerson(person);
        }
        public void DeletePersons(int id)
        {
            client.DeletePerson(id);
        }
        public void UpdatePersons(Person person)
        {
            client.UpdatePerson(person);
        }
    }
}
