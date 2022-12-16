
using Avalonia.Controls;

namespace  FAvalonia.favaloniaViews.Controls
{
    public partial class FButton : Button 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FToolButton : Button 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FCheckBox : CheckBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

      public partial class FLabel : TextBlock 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FComboBox : ComboBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FComboBoxEnum<T> : ComboBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FComboBoxGeneric<T> : ComboBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

     public partial class FProgressBar : ProgressBar 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FNumeric : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FNumericInt : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FTrackBar : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FGCodeEditor : TextBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FTextBox : TextBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FPictureBox : Image 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FRadioButton : UserControl
    {
    public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FRadioButtonEnum<T> : ComboBox
    {
    public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

     public partial class FHorizontalLine : UserControl
    {
    public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FTreeList : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FGroupBox : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

     public partial class FPanel : Panel 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FTableLayout : Grid 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FTabPanel : UserControl 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FListView<T> : ListBox 
    {
public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FGridView : ListBox
    {
        public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }
    
    public partial class FColorPicker : UserControl
    {
        public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

    public partial class FPropertyGrid : UserControl
    {
        public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

     public partial class FJobList : UserControl
    {
        public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }

     public partial class FPartList : UserControl
    {
        public string FName { get { return Name; } set { Name = value; } }
public string FToolTip { get; set; }
public bool FEnabled { get { return this.IsEnabled; } set { IsEnabled = value; } }
public int FHeight { get => (int)this.Height; set => this.Height = value; }
public int FWidth { get => (int)this.Width; set => this.Width = value; }
public bool FVisible { get { return this.IsVisible; } set { this.IsVisible = value; } }
public int FPosY { get { return (int)this.Margin.Top; } set { this.Margin = new Avalonia.Thickness(this.Margin.Left, value,0,0); } }
public int FPosX { get { return (int)this.Margin.Left; } set { this.Margin = new Avalonia.Thickness(value, this.Margin.Top, 0, 0); } }
public int FColspan { get; set; }
public object FTag { get => this.Tag; set => this.Tag = value; }
public int FIndent { get; set; }
    }
}