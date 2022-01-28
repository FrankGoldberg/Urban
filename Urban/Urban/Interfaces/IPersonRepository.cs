using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        Person GetById(int index);
        Person Add(Person person);
        void Update(Person person);
        void Delete(Person person);

    }
}
