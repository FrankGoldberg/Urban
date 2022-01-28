using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.Interfaces
{
    public interface IGuardianRepository
    {
        List<Guardian> GetAll();
        Guardian GetById(int index);
        bool Add(Guardian guardian);
        void Update(Guardian guardian);
        void Delete(Guardian guardian);

    }
}
