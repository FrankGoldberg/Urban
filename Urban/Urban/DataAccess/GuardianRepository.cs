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
    public class GuardianRepository : IGuardianRepository
    {
        FakeGuardianDB database = new FakeGuardianDB();
        public bool Add(Guardian guardian)
        {
            return true;
        }
        public void Delete(Guardian guardian)
        {
            database.Data.Remove(guardian);
        }
        public List<Guardian> GetAll()
        {
            return database.Data;
        }
        public Guardian GetById(int index)
        {
            var guardian = database.Data.ElementAt(index);
            return guardian;
        }

        public void Update(Guardian guardian)
        {
            ///todo database.Data.(guardian);
        }
    }
}
