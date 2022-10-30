
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWinForms
{
    public class OpenFileView : IOpenFileView, IDisposable
    {
        private OpenFileDialog d = new OpenFileDialog();
        private string[] selectedFiles = null;

        public string FileName
        {
            get
            {
                if (selectedFiles != null)
                    return selectedFiles[0];
                return null;
            }
        }

        public string[] FileNames
        {
            get
            {
                if (selectedFiles != null)
                    return selectedFiles;
                return null;
            }

        }

        public void Dispose()
        {
            d.Dispose();
        }

        public bool ShowDialog()
        {



            // https://medium.com/bynder-tech/c-why-you-should-use-configureawait-false-in-your-library-code-d7837dce3d7f
            //https://devblogs.microsoft.com/dotnet/configureawait-faq/

            /*
            string[]? Result = d.ShowAsync(FAvaloniaApp.MainWindow()).GetAwaiter().GetResult();
            if (Result == null || Result.Length == 0)
                return false;
            selectedFiles = Result;
            return true;
            */



            DialogResult r =  d.ShowDialog();

            string ghalt = "asdf";

            if (r == DialogResult.Cancel)
                return false;
            selectedFiles = d.FileNames;
            return true;



        }
    }
}
