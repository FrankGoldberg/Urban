using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Services;
using Urban.Views;

namespace Urban.Presenters
{
    public class PersonListPresenter
    {
        public IPersonListView View { get; set; }
        PersonService _service = PersonService.GetInstance();

        public PersonListPresenter(IPersonListView view)
        {
            View = view;
            View.LoadDataHandler += View_LoadDataHandler;
        }

        private void View_LoadDataHandler(object sender, EventArgs e)
        {
            View.PersonList = _service.GetAll();
        }
    }
}
