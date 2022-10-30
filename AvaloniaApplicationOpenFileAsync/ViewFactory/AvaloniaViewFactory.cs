using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplicationOpenFileAsync.ViewFactory
{
    public class AvaloniaViewFactory : IViewFactory
    {
        IOpenFileView IViewFactory.OpenView()
        {
            return new OpenFileView();
        }
    }
}
