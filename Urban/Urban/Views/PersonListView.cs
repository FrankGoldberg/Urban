using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urban.Models;
using Urban.Presenters;

namespace Urban.Views
{
    public partial class PersonListView : UserControl, IPersonListView
    {
        PersonListPresenter presenter;
        public PersonListView()
        {
            InitializeComponent();
            presenter = new PersonListPresenter(this);
        }

        private List<Person> _personList = new List<Person>();

        public List<Person> PersonList
        {
            get
            {
                if(_personList == null)
                {
                    return new List<Person>();
                }
                return _personList;
            }
            set
            {
                if(value == null)
                {
                    return;
                }

                _personList = value;

                gvPersonList.DataSource = null;
                gvPersonList.DataSource = _personList;          
            }
        }

        public event EventHandler LoadDataHandler;

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (LoadDataHandler != null)
                LoadDataHandler(this, EventArgs.Empty);
        }
    }
}
