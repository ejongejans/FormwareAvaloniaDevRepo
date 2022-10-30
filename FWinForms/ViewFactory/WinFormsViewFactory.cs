using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWinForms;

namespace FWinForms.ViewFactory
{
    public class WinFormsViewFactory : IViewFactory
    {
        IOpenFileView IViewFactory.OpenView()
        {
            return new OpenFileView();
        }
    }
}
