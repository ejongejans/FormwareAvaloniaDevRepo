using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// view factory
    /// </summary>
    public interface IViewFactory
    {
        IOpenFileView OpenView();

    }
}
