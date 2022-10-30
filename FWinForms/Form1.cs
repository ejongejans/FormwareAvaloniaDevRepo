using Core;
using FWinForms.ViewFactory;

namespace FWinForms
{
    public partial class Form1 : Form
    {
        OpenFileCommand cmd = new OpenFileCommand();
        

        public Form1()
        {
            InitializeComponent();

            Button b = new Button();
            b.Text = "Open file";
            b.Click += B_Click;
            this.Controls.Add(b);

            FApp.viewsFactory = new WinFormsViewFactory();
        }

        private void B_Click(object? sender, EventArgs e)
        {
            cmd.Open();
        }
    }
}