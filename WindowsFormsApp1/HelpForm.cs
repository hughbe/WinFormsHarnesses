using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WindowsFormsApp1
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        public const string FileName = "Common/topics.classic.chm";

        public static string Url => new Uri(Path.GetFullPath(FileName)).AbsoluteUri;

        private void popupButton_Click(object sender, EventArgs e)
        {
            Help.ShowPopup(this, popupCaptionTextBox.Text, new Point(100, 100));
        }

        private void keywordIndexButton_Click(object sender, EventArgs e)
        {
            MyHelp.ShowHelp(this, Url, HelpNavigator.KeywordIndex, keywordTextBox.Text);
        }

        private void associatedIndexButton_Click(object sender, EventArgs e)
        {
            MyHelp.ShowHelp(this, Url, HelpNavigator.AssociateIndex, keywordTextBox.Text);
        }

        private void searchQueryButton_Click(object sender, EventArgs e)
        {
            var component = new Component();
            var f = new ComponentEditorForm(component, new Type[] { typeof(SubComponentEditorPage) } );
            f.ShowDialog();
            Help.ShowHelp(this, Url, HelpNavigator.Find, searchTextBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private class SubComponentEditorPage : ComponentEditorPage
        {
            public new const int ScrollStateAutoScrolling = ComponentEditorPage.ScrollStateAutoScrolling;

            public new const int ScrollStateHScrollVisible = ComponentEditorPage.ScrollStateHScrollVisible;

            public new const int ScrollStateVScrollVisible = ComponentEditorPage.ScrollStateVScrollVisible;

            public new const int ScrollStateUserHasScrolled = ComponentEditorPage.ScrollStateUserHasScrolled;

            public new const int ScrollStateFullDrag = ComponentEditorPage.ScrollStateFullDrag;

            public new bool CanEnableIme => base.CanEnableIme;

            public new bool CanRaiseEvents => base.CanRaiseEvents;

            public new IComponent Component
            {
                get => base.Component;
                set => base.Component = value;
            }

            public new CreateParams CreateParams => base.CreateParams;

            public new Cursor DefaultCursor => base.DefaultCursor;

            public new ImeMode DefaultImeMode => base.DefaultImeMode;

            public new Padding DefaultMargin => base.DefaultMargin;

            public new Size DefaultMaximumSize => base.DefaultMaximumSize;

            public new Size DefaultMinimumSize => base.DefaultMinimumSize;

            public new Padding DefaultPadding => base.DefaultPadding;

            public new Size DefaultSize => base.DefaultSize;

            public new bool DesignMode => base.DesignMode;

            public new bool DoubleBuffered
            {
                get => base.DoubleBuffered;
                set => base.DoubleBuffered = value;
            }

            public new EventHandlerList Events => base.Events;

            public new bool FirstActivate
            {
                get => base.FirstActivate;
                set => base.FirstActivate = value;
            }

            public new int FontHeight
            {
                get => base.FontHeight;
                set => base.FontHeight = value;
            }

            public new ImeMode ImeModeBase
            {
                get => base.ImeModeBase;
                set => base.ImeModeBase = value;
            }

            public new bool ResizeRedraw
            {
                get => base.ResizeRedraw;
                set => base.ResizeRedraw = value;
            }

            public new bool ShowFocusCues => base.ShowFocusCues;

            public new bool ShowKeyboardCues => base.ShowKeyboardCues;

            public new bool HScroll
            {
                get => base.HScroll;
                set => base.HScroll = value;
            }

            public new int Loading
            {
                get => base.Loading;
                set => base.Loading = value;
            }

            public new bool LoadRequired
            {
                get => base.LoadRequired;
                set => base.LoadRequired = value;
            }

            public new IComponentEditorPageSite PageSite
            {
                get => base.PageSite;
                set => base.PageSite = value;
            }

            public new bool VScroll
            {
                get => base.VScroll;
                set => base.VScroll = value;
            }

            public new void EnterLoadingMode() => base.EnterLoadingMode();

            public new void ExitLoadingMode() => base.ExitLoadingMode();

            public new AutoSizeMode GetAutoSizeMode() => base.GetAutoSizeMode();

            public new Control GetControl() => base.GetControl();

            public new bool GetScrollState(int bit) => base.GetScrollState(bit);

            public new IComponent GetSelectedComponent() => base.GetSelectedComponent();

            public new bool GetStyle(ControlStyles flag) => base.GetStyle(flag);

            public new bool GetTopLevel() => base.GetTopLevel();

            public new bool IsFirstActivate() => base.IsFirstActivate();

            public new bool IsLoading() => base.IsLoading();

            public int LoadComponentCallCount { get; set; }

            protected override void LoadComponent() => LoadComponentCallCount++;

            public int PreProcessMessageCallCount { get; set; }

            public override bool PreProcessMessage(ref Message msg)
            {
                PreProcessMessageCallCount++;
                return true;
            }

            public new void ReloadComponent() => base.ReloadComponent();

            public int SaveComponentCallCount { get; set; }

            protected override void SaveComponent() => SaveComponentCallCount++;

            public new void SetDirty() => base.SetDirty();
        }
    }
}
