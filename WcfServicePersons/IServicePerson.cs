using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePersons
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePerson" in both code and config file together.
    [ServiceContract]
    public interface IServicePerson
    {
        [OperationContract]
        List<Person> GetPersons();

        [OperationContract]
        void CreateNewPerson(Person person);

        [OperationContract]
        void DeletePerson(int id);

        [OperationContract]
        void UpdatePerson(Person person);
    }
}
