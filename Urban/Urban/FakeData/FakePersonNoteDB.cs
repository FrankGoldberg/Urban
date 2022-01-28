using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.FakeData
{
    class FakePersonNoteDB
    {
        private List<PersonNotes> FakePersonNotes = new List<PersonNotes>();
        public List<PersonNotes> Data { get { return FakePersonNotes; } set { FakePersonNotes = value; } }

        public FakePersonNoteDB()
        {
            FakePersonNotes.Add(new PersonNotes()
            {
                PersonId = 01,
                ///todo Data = 07.01.2022, - Wyskakuje błąd - Znaleźć rozwiązanie do wstawienia automatycznej daty
                Notes = "Rozpoczecie treningu, jaka metodyka, regularnosc, czy podpadł, co przetrenować itp"
            });
        }

    }
}
