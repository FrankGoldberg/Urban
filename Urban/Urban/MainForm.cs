using System;
using System.Windows.Forms;
using Urban.Controllers;
using Urban.Views;

namespace Urban
{
    public partial class MainForm : Form
    {
        ViewController viewController;

        public MainForm()
        {
            InitializeComponent();

            viewController = new ViewController(pnlContent);

            PersonView personView = new PersonView();
            PersonListView personListView = new PersonListView();            
            viewController.RegisterView("PersonListView", personListView);
            viewController.RegisterView("PersonView", personView);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PersonView personview = new PersonView();
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(personview);
            ////viewController.ShowView("PersonView)");
            viewController.ShowView("PersonView");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            //PersonListView personListView = new PersonListView();
            //personListView.Dock = DockStyle.Fill;
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(personListView);
            viewController.ShowView("PersonListView");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewController.ShowView("PersonListView");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewController.ShowView("PersonListView");
        }
    }
}
