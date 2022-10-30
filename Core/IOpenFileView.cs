using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IOpenFileView : IDisposable
    {
        string FileName { get; }
        string[] FileNames { get; }

        bool ShowDialog();
    }
}
