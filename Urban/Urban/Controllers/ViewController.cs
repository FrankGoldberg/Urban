using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban.Controllers
{
    public class ViewController
    {
        Panel mainPanel;
        Dictionary<string, UserControl> Views = new Dictionary<string, UserControl>();

        public ViewController(Panel panel)
        {
            mainPanel = panel;
        }

        public void RegisterView(string name, UserControl control)
        {
            if (!Views.ContainsKey(name))
            {
                Views.Add(name, control);
            }
        }

        public void ShowView(string name)
        {
            if (!Views.ContainsKey(name))
            {
                throw new Exception($"There is no view {name}");
            }

            UserControl ctrl = Views[name];
            ctrl.Visible = true;
            ctrl.Dock = DockStyle.Fill;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ctrl);
        }
    }

}
