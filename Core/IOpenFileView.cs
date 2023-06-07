using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// all views are accessible over interfaces. This make winforms/avalonia switching possible. (or console operation without UI for that matter)) 
    /// </summary>
    public interface IOpenFileView : IDisposable
    {
        string FileName { get; }
        string[] FileNames { get; }

        Task<bool> ShowDialogAsync();

        bool ShowDialog();
    }
}
