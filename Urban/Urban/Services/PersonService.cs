using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.DataAccess;
using Urban.Interfaces;
using Urban.Models;

namespace Urban.Services
{
    public class PersonService : IPersonRepository
    {
        private IPersonRepository repository = new PersonRepository();

        private static PersonService _instance = null;

        public static PersonService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PersonService();
            }
            return _instance;
        }

        private PersonService()
        {
        }

        public Person Add(Person person)
        {
            repository.Add(person);
            return person;
        }

        public void Delete(Person person)
        {
            repository.Delete(person);
        }

        public List<Person> GetAll()
        {
            return repository.GetAll();
        }        

        public Person GetById(int index)
        {
            return repository.GetById(index);
        }

        public void Update(Person person)
        {
            repository.Update(person);
        }
    }
}
