using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;
using Urban.Services;
using Urban.Views;

namespace Urban.Presenters
{
    public class PersonPresenter
    {
        public IPersonView View  {get; set; }
        PersonService _service =  PersonService.GetInstance();

        public PersonPresenter(IPersonView personView)
        {
            View = personView;
            View.AddPersonHandler += View_AddPersonHandler;          
        }

        private void View_AddPersonHandler(object sender, EventArgs e)
        {
            _service.Add(View.Person);
        }
    }
}
