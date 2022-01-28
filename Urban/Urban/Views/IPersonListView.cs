using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.Views
{
    public interface IPersonListView
    {
        event EventHandler LoadDataHandler;
        List<Person> PersonList { get; set; }
    }
}
