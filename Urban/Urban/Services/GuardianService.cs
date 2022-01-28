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

    public class GuardianService : IGuardianRepository
    {
        private IGuardianRepository repositor = new GuardianRepository();

        private static GuardianService _instance = null;

        public static GuardianService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GuardianService();
            }
            return _instance;
        }

        public List<Guardian> GetAll()
        {
            return repositor.GetAll();
        }

        public Guardian GetById(int index)
        {
            return repositor.GetById(index);
        }

        public bool Add(Guardian guardian)
        {
            return true;
        }

        public void Update(Guardian guardian)
        {
            repositor.Update(guardian);
        }

        public void Delete(Guardian guardian)
        {
            repositor.Delete(guardian) ;
        }
    }
}

    
