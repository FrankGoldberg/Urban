
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.Interfaces
{
    public interface IPersonNotesRepository
    {
        bool Add(PersonNotes personNotes);
        void Delete(PersonNotes personNotes);
        void Update(PersonNotes personNotes);
    }
}
