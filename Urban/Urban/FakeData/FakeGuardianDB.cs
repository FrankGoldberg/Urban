using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.FakeData
{
    class FakeGuardianDB
    {

        private List<Guardian> fakeguardian = new List<Guardian>();
        public List<Guardian> Data { get { return fakeguardian; } set { fakeguardian = value; } }

        public FakeGuardianDB()
        {
            fakeguardian.Add(new Guardian()
            {
                Name = "Magdalena",
                Surname = "Korzeniowska",
                Phone = "545214785",
                Address = "Lipowa 25"
            });

            fakeguardian.Add(new Guardian()
            {
                Name = "Mateusz",
                Surname = "Kozioł",
                Phone = "123123123",
                Address = "Malmeda 33"
            });
        }
        
    }
} 