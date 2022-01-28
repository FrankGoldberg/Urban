using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.FakeData
{
    public class FakePersonDB
    {
        private List<Person> fakepeople = new List<Person>();
        public List<Person> Data { get { return fakepeople; } set { fakepeople = value; } }
        
        public FakePersonDB()
        {
            fakepeople.Add(new Person()
            {
                Id = 1,
                Name = "Waldemar",
                Surname = "Mikita",
                Age = 25,
                Description = "",
                Experience = "",
                Gender = 'M',
                Nationalioty = "Polska",
                Payment = "Tak",
                Phone = "530 111 222",
                Weight = 80
            });
            fakepeople.Add(new Person()
            {
                Id = 2,
                Name = "Daniel",
                Surname = "Olbchrycki",
                Age = 43,
                Description = "",
                Experience = "",
                Gender = 'M',
                Nationalioty = "Polska",
                Payment = "Nie",
                Phone = "530 111 333",
                Weight = 92
            });
            fakepeople.Add(new Person()
            {
                Id = 3,
                Name = "Sandra",
                Surname = "Górska",
                Age = 28,
                Description = "",
                Experience = "",
                Gender = 'F',
                Nationalioty = "Polska",
                Payment = "Tak",
                Phone = "530 111 444",
                Weight = 65
            });
        }

    }
}
