using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Interfaces;
using Urban.Models;

namespace Urban.Services
{
    public class PersonNotesService : IPersonNotesRepository
    {
        private IPersonNotesRepository repository = new PersonNotesRepository();
        private static PersonNotesService _instance = null;
        public static PersonNotesService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PersonNotesService();
            }
            return _instance;
        }

        public bool Add(PersonNotes personNotes)
        {        
            return true;
        }
        public void Delete(PersonNotes personNotes)
        {
            repository.Delete(personNotes);
        }

        public void Update(PersonNotes personNotes)
        {
            repository.Update(personNotes);
        }

    }
}