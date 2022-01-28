using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urban.Models;

namespace Urban.Views
{
    public interface IPersonView
    {
        event EventHandler AddPersonHandler;
        Person Person { get; set; }
    }
}
