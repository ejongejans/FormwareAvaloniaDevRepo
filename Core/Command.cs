using FCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// base for the commands. There are around 120 commands in the application. 
    /// </summary>
    public abstract class Command : ICommand
    {
        /// <summary>
        /// New command. 
        /// </summary>
        public Command(string ID)
        {
            this.ID = ID;
            this.LinkedUIControls = new List<CommandControl>();
        }

        public List<CommandControl> LinkedUIControls { get; set; }
        /// <summary>
        /// Occurs when the command is executed 
        /// </summary>
        public event EventHandler Executed;

        /// <summary>
        /// Raises the <see cref="Executed"/> event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected virtual void OnExecuted(EventArgs e)
        {
            Executed?.Invoke(this, e);

            //if (this.EnabledAsLastCommand)
            //    FUICommands.Last = this; //set the last command.
        }

        /// <summary>
        /// Execute the command programatically.
        /// Triggers the onexecuted action with exmpty command args.
        /// Can be used to link from other commands.
        /// </summary>
        public void Execute()
        {
            OnExecuted(EventArgs.Empty);
        }

        public void Execute(EventArgs e)
        {
            OnExecuted(e);
        }

        /// <summary>
        /// Gets or sets the ID of the command
        /// </summary>
        /// <remarks>
        /// This can be used to identify a command.
        /// </remarks>
        /// <value>The command ID.</value>
        public string ID { get; set; }


        bool _checked = false;

        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                foreach (CommandControl ctrl in LinkedUIControls)
                {
                    //EJ: disabled in devapp not important
                    /*
                    FUI.SafeInvoke(() =>
                    {
                        ctrl.SetChecked(value);
                    });
                    */
                }
            }
        }

        bool visible = true;

        public bool Visible
        {
            get { return visible; }
            set
            {
                visible = value;
                foreach (CommandControl ctrl in LinkedUIControls)
                {
                    //FUI.SafeInvoke(() => //EJ: disabled in devapp not important
                   // {
                    //    ctrl.SetVisible(value);
                  //  });
                }

            }
        }

        bool enabled = true;

        /// <summary>
        /// when this bool is set to true in the command you can move to this command with the last executed command.
        /// </summary>
        public bool EnabledAsLastCommand { get; set; }

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                foreach (CommandControl ctrl in LinkedUIControls)
                {
                   // FUI.SafeInvoke(() =>
                   // {
                   //     ctrl.SetEnabled(value);
                   // });
                }


            }
        }

        public object Tag { get; set; }

        public string MenuTextKey { get; set; }

        public string ToolTipKey { get; set; }


        public abstract string Title { get; }

        public abstract string ToolTip { get; }

        public string Category { get; set; }

        public bool IsCategoryHeader { get; set; }


        /// <summary>
        /// icon type for dynamic icon loading.
        /// </summary>
        private Type iconType = typeof(Type); //dummy. doesnt' matter here. 

        public Type IconType
        {
            get { return iconType; }
            set
            {
                iconType = value;
                foreach (CommandControl ctrl in LinkedUIControls)
                {
                   // FUI.SafeInvoke(() =>
                   // {
                   //     if (ctrl.SetImageType != null)
                   //         ctrl.SetImageType();
                    //});
                }
            }

        }


        public SKBitmap Icon(int size)
        {
            return FUtilSkia.RandomBitmap(size, size);
        }


        private SKBitmap image;

        public SKBitmap Image
        {
            get { return image; }
            set
            {
                image = value;
                foreach (CommandControl ctrl in LinkedUIControls)
                {
                   // FUI.SafeInvoke(() =>
                   // {
                   //     if (ctrl.SetImage != null)
                   //         ctrl.SetImage(value);
                   // });
                }
            }
        }
    }
}
