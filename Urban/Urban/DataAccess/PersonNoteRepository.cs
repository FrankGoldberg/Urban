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
    public class PersonNoteRepository : IPersonNotesRepository
    {
        FakePersonNoteDB database = new FakePersonNoteDB();
        public bool Add(PersonNotes personNotes)
        {
            return true;
        }
        public void Delete(PersonNotes personNotes)
        {
            database.Data.Remove(personNotes);
        }
        public void Update(PersonNotes personNotes)
        {
            ///todo database.Data.Update(personNotes); (Update? nie działa database. 
        }
    }
}
