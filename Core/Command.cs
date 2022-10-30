using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Command
    {
        protected abstract void OnExecuted(EventArgs e);

        public void Execute()
        {
            OnExecuted(EventArgs.Empty);
        }

        public void Execute(EventArgs e)
        {
            OnExecuted(e);
        }
    }
}
