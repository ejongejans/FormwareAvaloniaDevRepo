using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using System.Reflection;

using System.Collections.ObjectModel;

namespace FAvalonia.favaloniaViews.Controls
{



    public interface IFControl
    {
        /// <summary>
        /// unique name. This is the winforms name property.. 
        /// </summary>
        string FName { get; set; }

        /// <summary>
        /// tooltip in the ui? --> todo make a nice popup with html/and or image.
        /// </summary>
        string FToolTip { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        bool FEnabled { get; set; }

        /// <summary>
        /// height in pixels
        /// </summary>
        int FHeight { get; set; }

        /// <summary>
        /// width in pixels
        /// </summary>
        int FWidth { get; set; }

        /// <summary>
        /// visible or not toggle. 
        /// </summary>
        bool FVisible { get; set; }

        /// <summary>
        /// location Y 
        /// </summary>
        int FPosX { get; set; }

        /// <summary>
        /// location x
        /// </summary>
        int FPosY { get; set; }

        /// <summary>
        /// colspan in the grid if it needs to be overridden.
        /// </summary>
        int FColspan { get; set; }

        /// <summary>
        /// random tag
        /// </summary>
        object FTag { get; set; }

        /// <summary>
        /// indent on the left when placed in a layout. This is typically used for settings panels or in tools. If a control should look like a subctrl.
        /// </summary>
        int FIndent { get; set; }
    }

    public interface IFSerializableControl : IFControl
    {
        /// <summary>
        /// this serializes the controls value to a string. 
        /// </summary>
        /// <returns></returns>
        string FSerialize();

        /// <summary>
        /// this deserializes the string and sets the controls value. 
        /// </summary>
        /// <param name="value"></param>
        void FDeSerialize(string value);


        void FSetValue(object value);

        object FGetValue();

        bool DisableSerialization { get; set; }
    }

    public interface IFPartList : IFControl
    {
        //void Update(List<FStlTreeItem> tree);
    }

    public interface IFJobList : IFControl
    {
        //void Update(List<FJobTreeItem> tree);
    }

    public interface IFTreeList : IFControl
    {
        ObservableCollection<FTreeItem> FObjects { set; }

        FTreeItem FSelectedObject { get; set; }

        event EventHandler OnSelectedItemChanged;
    }

    public class FTreeItem
    {
        /// <summary>
        /// changed to observable collection.. 
        /// </summary>
        public ObservableCollection<FTreeItem> FChildren { get; set; } = new ObservableCollection<FTreeItem>();



        public string FName { get; set; }

        public string FKey { get; set; }

        public object FTag { get; set; }

        public SKBitmap FIcon { get; set; }

        public bool ShouldRefreshImage { get; set; }
    }


    public interface IFPropertyGrid : IFControl
    {
        object MainGridObject { set; }

        event EventHandler FPropertyChanged;
    }

    public interface IFLabel : IFControl
    {
        string FText { get; set; }

        bool FBold { get; set; }

        SKColor FColor { get; set; }

        //void SetStyle(FMessageType typ);
    }

    public interface IFListView<T> : IFControl
    {
        void AddColumn(int widthPx, string header, bool isLast = false);

        void AddRow(T obj, SKBitmap img, string name, params string[] otherColumnValues);

        void FClear();

        bool FIconBorder { get; set; }

        event EventHandler FOnItemDoubleClick;

        event EventHandler FOnSelectedItemChanged;

        event EventHandler FVisibilityChanged;

        List<T> FSelectedObjects { get; }

        int FSelectedIndex { set; }

        bool FMultiSelect { get; set; }
    }



    public interface IFGridView : IFControl
    {
        void AddItem(string title, SKBitmap image, string tooltip = null, object tag = null);

        void FClear();

        event EventHandler FOnItemDoubleClick;

        event EventHandler FOnSelectedItemChanged;

        List<object> FSelectedObjects { get; }
    }

    public interface IFTextBox : IFSerializableControl
    {
        bool FMultiLine { get; set; }

        bool FScroll { get; set; }

        string FText { get; set; }

        SKColor FBgColor { get; set; }

        bool FPassword { get; set; }

        void StyleAsSelectionBox();


        event EventHandler FOnTextChanged;

        /// <summary>
        /// gets passed the formware key conversion as object! todo make this niser
        /// </summary>
        event EventHandler FOnKeyUp;
    }

    public interface IFGCodeEditor : IFControl
    {
        string FText { get; set; }

    }

    public interface IFPictureBox : IFControl
    {
        public SKBitmap FImage { get; set; }

        public bool FBorder { get; set; }

        public bool FStretch { get; set; }

        public SKColor FBackColor { get; set; }

        event EventHandler FOnClick;

        event EventHandler FOnMouseEnter;

        event EventHandler FOnMouseLeave;
    }



    public interface IFCheckBox : IFSerializableControl
    {
        bool FValue { get; set; }

        SKBitmap FImage { set; }

        event EventHandler FOnCheckChanged;
    }

    public interface IFProgressBar : IFControl
    {
        int FMax { get; set; }

        int FMin { get; set; }

        int FValue { get; set; }

    }

    public interface IFNumeric : IFSerializableControl
    {
        float FValue { get; set; }

        float FMin { get; set; }

        float FMax { get; set; }

        int FDecimals { get; set; }

        float FIncrement { get; set; }

        string FUnit { get; set; }

        event EventHandler FOnValueChanged;

        void SetWidthWithRightText(int w);

        void SetColor(SKColor color);
    }

    public interface IFNumericInt : IFSerializableControl
    {
        int FValue { get; set; }

        int FMin { get; set; }

        int FMax { get; set; }

        int FIncrement { get; set; }

        string FUnit { get; set; }

        event EventHandler FOnValueChanged;

        void SetWidthWithRightText(int w);
    }

    public interface IFTrackBar : IFSerializableControl
    {
        int FValue { get; set; }

        int FMin { get; set; }

        int FMax { get; set; }

        int FStepSize { get; set; }

        string FUnit { get; set; }

        bool FNumericEdit { get; set; }

        event EventHandler FOnValueChanged;

        void SetRecommended(int value);
    }

    public interface IFComboBox : IFSerializableControl
    {
        int FSelectedIndex { get; set; }

        List<string> FValues { set; }

        event EventHandler FOnSelectedIndexChanged;
    }

    public interface IFComboBoxGeneric<T> : IFControl
    {
        T FSelectedObject { get; set; }

        //make sure displayname property is set in constructor.
        List<T> FObjects { set; }

        event EventHandler FOnSelectedItemChanged;
    }

    public interface IFComboBoxEnum<T> : IFSerializableControl where T : Enum
    {
        T FSelectedValue { get; set; }

        Type FEnum { set; }

        event EventHandler FOnSelectedItemChanged;
    }

    public interface IFRadioButton : IFSerializableControl
    {
        int FSelectedIndex { get; set; }

        event EventHandler FOnSelectedIndexChanged;
    }

    public interface IFRadioButtonEnum<T> : IFSerializableControl where T : Enum
    {
        T FSelectedValue { get; set; }

        Type FEnum { set; }

        event EventHandler FOnSelectedItemChanged;
    }

    public interface IFButton : IFControl
    {
        event EventHandler FOnClick;

        string FText { get; set; }

        //void SetAsDialogApplyButton(IProgrammaticDialogView view);

        //void SetAsDialogCancelButton(IProgrammaticDialogView view);
    }

    public interface IFContainer : IFControl
    {
        /// <summary>
        /// other containers or controls. 
        /// depending on what this is we will generate controls
        /// </summary>
        List<IFControl> FControls { get; set; }
    }

    public interface IFHorizontalLine : IFControl
    {
        SKColor SKLineColor { get; set; }
    }

    /// <summary>
    /// groupbox item. 
    /// </summary>
    public interface IFGroupBox : IFContainer
    {
        string FText { get; set; }
        void AddContent(IFControl control);
    }

    public interface IFPanel : IFContainer
    {
        void AddContent(IFControl control);

        void AddContent(IProgrammaticView view);

        SKBitmap FBackgroundImage { get; set; }

        SKColor FBackColor { get; set; }

        event EventHandler FOnClick;

        void FClear();

        bool FScroll { get; set; }
    }

    public interface IFTabPanel : IFContainer
    {
        void AddContent(IFControl control, string tabKey, bool addClosingRow = true);

        void AddTab(string tabKey, string tabTitle);

        void AddTabWithContent(string tabkey, string tabTitle, IFControl control, bool addClosingRow = true);

        void RemoveTab(string tabKey);

        string FSelectedTab { get; set; }

        event EventHandler FTabSelectedIndexChanged;
    }

    //todo
    public interface IFColorPicker : IFSerializableControl
    {
        SKColor FColor { get; set; }

        event EventHandler FOnChanged;
    }

    /// <summary>
    /// row item that contains 1 or more controls.. 
    /// </summary>
    public interface IFTableLayout : IFContainer
    {
        //namekey is already there.. 
        //int Cols { get; set; }

        void AddColumn(int totalcolumns, bool absolute, float pixelOrPct);

        void AddColumnsRelative(params float[] widthPcts);

        void AddRow(params object[] controls);

        bool FScroll { get; set; }

        SKColor FBgColor { get; set; }

        int FPadding { set; }

        int FMaxHeight { get; set; }
    }




    /// <summary>
    /// this is something we still need to finish and rewrite to event based processing.
    /// we can't have logic inside the dialogues... 
    /// </summary>

    public interface IProgrammaticDialogView : IProgrammaticView
    {
        /// <summary>
        /// title of the dialog
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// icon
        /// </summary>
        SKBitmap FIcon { set; }

        /// <summary>
        /// enter for apply
        /// </summary>
        bool EnterForApply { get; set; }

        /// <summary>
        /// enter enabled. for example during background work it can be disabled.
        /// </summary>
        bool EnterEnabled { get; set; }

        /// <summary>
        /// esc key for cancel
        /// </summary>
        bool EscForCancel { get; set; }

        /// <summary>
        /// ctrl z for undo
        /// </summary>
        bool CtrlZForUndo { get; set; }

        /// <summary>
        /// checks for disposed.. can be used with background operations etc. 
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// show dialog
        /// </summary>
        void ShowDialog();

        /// <summary>
        /// just show the item.
        /// </summary>
        void Show();

        //cloase view. 
        void Close();

        /// <summary>
        /// close with bypassing confirm
        /// </summary>
        void CloseWithoutConfirm();

        /// <summary>
        /// on apply event.
        /// </summary>
        event EventHandler Apply;

        /// <summary>
        /// on cancel event. 
        /// </summary>
        event EventHandler Cancel;

        /// <summary>
        /// on shown.
        /// </summary>
        event EventHandler FOnShown;

        /// <summary>
        /// bool that is set as dialog result ok. checks which button has been fired.
        /// </summary>
        bool FDialogResultOk { get; set; }

        /// <summary>
        /// set the function to confirm if the cancel action should continue. (logic in the presenter)
        /// </summary>
        Func<bool> ConfirmCancel { get; set; }

        /// <summary>
        /// set this function to confirm the apply should continue. (logic in teh presenter)
        /// </summary>
        Func<bool> ConfirmApply { get; set; }

        /// <summary>
        /// as it's a dialog we need to put the action here. mainpresenter might not be loaded.. 
        /// </summary>
        /// <param name="action"></param>
        void SafeInvoke(Action action);

        /// <summary>
        /// force event pipeline to refresh. andy sometimes. 
        /// </summary>
        void FDoEvents()
        {

        }

        /// <summary>
        /// bring to front.. license box error otherwise..
        /// </summary>
        void FBringToFront()
        {

        }

        /// <summary>
        /// toggle that can be used to set topmost.. important for license box to be on top. 
        /// </summary>
        bool FTopMost { get; set; }

        /// <summary>
        /// add a subview in the dialog.. 
        /// </summary>
        /// <param name="subView"></param>
        void AddControls(IProgrammaticView subView);


        int FMinWidth { get; set; }

        int FMinHeight { get; set; }

        int FMaxWidth { get; set; }

        int FMaxHeight { get; set; }

        void StyleAsSplashScreen(SKBitmap bmp);

        bool FScroll { get; set; }
    }


    /// <summary>
    /// this is a generic programmatic view. 
    /// it can be injected. It's basically a table layout that contains a subset of any other layout. 
    /// there are methods to retrieve the serializable controls to perform model binding or serialization. 
    /// 
    /// </summary>
    public interface IProgrammaticView
    {
        /// <summary>
        /// is shown event?? 
        /// </summary>
        void Shown();

        /// <summary>
        /// allows access to user control enable all controls method.  needed?? 
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// name key for serialization. Should be set in constructor
        /// </summary>
        public string NameKey { get; set; }

        /// <summary>
        /// toggle to disable serialization
        /// </summary>
        public bool DisableSerialization { get; set; }

        /// <summary>
        /// should load the items and turn them into controls. 
        /// </summary>
        /// <param name="rows"></param>
        void AddControls(List<IFControl> controls);

        /// <summary>
        /// add controls by params
        /// </summary>
        /// <param name="controls"></param>
        void AddControls(params IFControl[] controls);

        /// <summary>
        /// get a list of serializable controls
        /// </summary>
        /// <typeparam name="IFSerializableControl"></typeparam>
        /// <param name=""></param>
        /// <param name=""></param>
        List<IFSerializableControl> GetSerializableControls();


    }
}
