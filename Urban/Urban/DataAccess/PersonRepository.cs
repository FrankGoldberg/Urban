using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.FakeData;
using Urban.Interfaces;
using Urban.Models;

namespace Urban.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        FakePersonDB database = new FakePersonDB(); 
        public Person Add(Person person)
        {
            database.Data.Add(person);
            return person;
        }

        public void Delete(Person person)
        {
            database.Data.Remove(person);
        }

        public List<Person> GetAll()
        {
            return database.Data; 
        }

        public Person GetById(int index)
        {
            var person = database.Data.ElementAt(index);
            return person;
        }

        public void Update(Person person)
        {
            ///todo database.Data(person);
        }
    }
}