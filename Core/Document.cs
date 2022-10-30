using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Document
    {
        /// <summary>
        ///  //starts background workers reading hte file, processing it. From 1 second to 1 minute for bigger files (500mb+)
        /// </summary>
        /// <param name="path"></param>
        public static void OpenFile(string path)
        { 
           
        }


        /// <summary>
        /// called by background workers. Does last piece of the loading; usually sending to GPU (on UI thread) and updating the UI> 
        /// </summary>
        public static void OpenFileDone()
        { 
        
        }
    }
}
