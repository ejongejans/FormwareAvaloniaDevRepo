using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using SkiaSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Emit;
using FCore;
using FAvalonia.favaloniaViews.Helpers;

namespace FAvalonia.favaloniaViews.Controls
{
    public partial class FAvaloniaToolbar : UserControl
    {
        private int IconSize = 24;
        private int ActiveIndex = -1;

        public FAvaloniaToolbar()
        {
            InitializeComponent();

            // MenuFlyout menuFlyout = (MenuFlyout)ToolBarSelectBtn.Flyout;
            // menuFlyout.Items = toolbarMenuSelect;

            this.Margin = new Thickness(10, 0);
            LabelPanel.Margin = new Thickness(0, 0, 0, 10);
            QuickAccessPanel.IsVisible = false;
        }
        private List<List<Control>> toolbars = new List<List<Control>>();

        private List<FLabel> labels = new List<FLabel>();
        private List<string> toolbarNames = new List<string>();
        private ObservableCollection<MenuItem> toolbarMenuSelect = new ObservableCollection<MenuItem>();



        public void LoadToolbar(int i)
        {
            if (i > toolbars.Count - 1)
                return;

            // ToolBarSelectBtn.Content = toolbarNames[i];

            ButtonPanel.Children.Clear();

            foreach (Control t in toolbars[i])
            {
                ButtonPanel.Children.Add(t);
            }

            foreach (FLabel l in labels)
            {
                l.FColor = SKColors.Black;
                //l.FBold = false;
                //l.RemoveUnderline();
                l.Background = null;

            }




            //labels[i].FBold = true;
            //labels[i].FColor = FGlobalsStyle.GetBadgeBackgroundColor();

            if (labels[i].Bounds.Width > 0)
            {
                SKBitmap bmp = new SKBitmap((int)labels[i].Bounds.Width, (int)labels[i].Bounds.Height);
                using (SKCanvas g = new SKCanvas(bmp))
                {
                    using (SKPaint pt = new SKPaint())
                    {
                        pt.Style = SKPaintStyle.Fill;
                        pt.Color = SKColors.Green;
                        //pt.Color = FGlobalsStyle.GetBadgeBackgroundColor();
                        g.DrawLine(new SKPoint(0, bmp.Height - 1), new SKPoint(bmp.Width, bmp.Height - 1), pt);
                    }

                }

                labels[i].Background = bmp.ToImageBrush();

            }
            // labels[i].SetUnderline();
            ActiveIndex = i;
        }

        public void AddToolBar(List<ICommand> cmds, string title)
        {
            toolbarNames.Add(title);

            FLabel lb = new FLabel(title.ToUpper());
            //lb.Margin = new Avalonia.Thickness(20, 0);
            lb.Padding = new Thickness(20, 3);
            lb.Tag = toolbarMenuSelect.Count;
            lb.FontSize -= 1;

            lb.PointerReleased += (sender, args) => {
                int i = (int)((FLabel)sender).Tag;
                LoadToolbar(i);
            };
            lb.PointerEnter += (sender, args) =>
            {
                FLabel lb = sender as FLabel;
                //lb.FColor = FGlobalsStyle.GetBadgeBackgroundColor();
            };
            lb.PointerLeave += (sender, args) =>
            {
                FLabel lb = sender as FLabel;
                int i = (int)((FLabel)sender).Tag;
                if (i != ActiveIndex)
                    lb.FColor = SKColors.Black;
            };
            labels.Add(lb);
            LabelPanel.Children.Add(lb);


            MenuItem mi = new MenuItem();
            mi.Header = title;
            mi.Tag = toolbarMenuSelect.Count;
            mi.Click += (sender, args) => {
                int i = (int)((MenuItem)sender).Tag;
                LoadToolbar(i);
            };
            toolbarMenuSelect.Add(mi);

            List<Control> btnGroups = new List<Control>();

            foreach (var cmdsGroup in cmds.GroupBy(d => d.Category))
            {


                FTableLayout table = new FTableLayout();
                int columnCnt = cmdsGroup.Count();
                foreach (ICommand cmd in cmdsGroup)
                {
                    table.AddColumn(columnCnt, false, 100f / columnCnt);
                }


                List<IFControl> btns = new List<IFControl>();
                foreach (ICommand cmd in cmdsGroup)
                {
                    SKBitmap bmp = cmd.Icon(IconSize);
                    if (bmp == null)
                        bmp = new SKBitmap(IconSize, IconSize);

                    FToolButton btn = new FToolButton(bmp);
                    btn.Background = SKColors.Transparent.ToSolidBrush();
                    btn.Margin = new Avalonia.Thickness(3, 0);
                    btn.FOnClick += (sender, args) => { cmd.Execute(); };

                    //link button to UI. 
                    CommandControl link = new CommandControl()
                    {
                        SetChecked = (val) => { },
                        SetVisible = (val) => { btn.IsVisible = val; },
                        SetEnabled = (val) => { btn.IsEnabled = val; },
                        SetImage = (img) => { btn.SetImage(img); }
                    };
                    cmd.LinkedUIControls.Add(link);

                    FTableLayout tableTooltip = new FTableLayout();
                    tableTooltip.AddColumn(2, false, 50);
                    tableTooltip.AddColumn(2, false, 50);

                    FLabel titleLb = new FLabel(cmd.Title);
                    titleLb.FBold = true;
                    FLabel shortcutLb = new FLabel(" ");
                    shortcutLb.FColor = SKColors.Gray;
                   // if (cmd.FShortCut != FCore.fservices.KeyService.FKey.Unknown)
                        //shortcutLb.Text = cmd.FShortCut.ToNiceString();
                    shortcutLb.TextAlignment = TextAlignment.Right;
                    tableTooltip.AddRow(titleLb, shortcutLb);


                    if (!string.IsNullOrEmpty(cmd.ToolTip))
                    {
                        FLabel tt = new FLabel(cmd.ToolTip);
                        //tt.FColspan = 2;
                        tableTooltip.AddRow(tt);
                    }
                    ToolTip.SetTip(btn, tableTooltip);
                    ToolTip.SetPlacement(btn, PlacementMode.Bottom);
                    ToolTip.SetShowDelay(btn, 0);



                    btns.Add(btn);
                }

                //now add the row of buttons to the table. 
                table.AddRow(btns.ToArray());

                FPanel p = new FPanel();
                p.Height = 13;
                FLabel category = new FLabel(cmdsGroup.Key.ToUpper());
                //category.TextWrapping = Avalonia.Media.TextWrapping.Wrap;
                category.TextAlignment = Avalonia.Media.TextAlignment.Right;
                category.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;


                //category.Width = cmdsGroup.Count() * (IconSize+ 8 + 6); //width of vertical line etc.
                // category.Background = FUtilSkia.RandomColor().ToSolidBrush();
                category.Margin = new Avalonia.Thickness(0, 0, 0, 0); //10 is thickness of verticalline. 
                category.FColor = SKColors.Gray;
                category.FontSize -= 1;

                p.AddContent(category);

                table.AddRow(p);


                btnGroups.Add(table);
                //btnGroups.Add(new FVerticalLine(SKColors.Gray));

            }
            toolbars.Add(btnGroups);

            LoadToolbar(0);
        }


    }
}
