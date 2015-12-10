using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePersons
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePerson" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePerson.svc or ServicePerson.svc.cs at the Solution Explorer and start debugging.
    public class ServicePerson : IServicePerson
    {
        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            Func func = new Func();
            persons = func.ReturnPersons();
            return persons;
        }
        public void CreateNewPerson(Person person)
        {
            Func.InsertNewPerson(person);
        }
        public void DeletePerson(int id)
        {
            Func.DeletePerson(id);
        }
         public  void UpdatePerson(Person person)
        {
            Func.UpdatePerson(person);
        }
    }
}
