using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urban.Presenters;
using Urban.Models;

namespace Urban.Views
{
    public partial class PersonView : UserControl, IPersonView
    {

        PersonPresenter presenter;
        public PersonView()
        {
            InitializeComponent();
            presenter = new PersonPresenter(this);
        }

        private Person _person = new Person();

        public Person Person 
        { 
            get
            {
                _person.Name = txtName.Text;                
                _person.Surname = txtSurname.Text;
                _person.Age = int.Parse(txtAge.Text);
                _person.Id = int.Parse(txtID.Text);
                _person.Description = txtDescription.Text;
                _person.Experience = txtExperience.Text;
                _person.Gender = txtGender.Text.First();
                _person.Nationalioty = txtNationality.Text;
                _person.Payment = txtPayment.Text;
                _person.Weight = int.Parse(txtPayment.Text);

                return _person;
            }
            set
            {
                _person = value;

                txtName.Text = _person.Name;
                txtSurname.Text = _person.Surname;
                txtID.Text = _person.Id.ToString();
                txtDescription.Text = _person.Description;
                txtExperience.Text = _person.Experience;
                txtGender.Text = _person.Gender.ToString();
                txtNationality.Text = _person.Nationalioty;
                txtPayment.Text = _person.Payment;
                txtWeight.Text = _person.Weight.ToString();
 
            }        
        }

        public event EventHandler AddPersonHandler;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validate(_person)) return;
            if (AddPersonHandler != null)
                AddPersonHandler(this, EventArgs.Empty);
        }

        private bool Validate(Person person)
        {
            MessageBox.Show("Fill all the information", "Warning");
            return true;
        }
    }
}
