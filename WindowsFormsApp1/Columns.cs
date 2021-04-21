using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interop;
using static Interop.ComCtl32;

namespace WindowsFormsApp1
{
    public partial class Columns : Form
    {
        public unsafe Columns()
        {
            InitializeComponent();

            char* pText = stackalloc char[256];
            var column = new LVCOLUMNW
            {
                mask = (LVCF)uint.MaxValue,
                cchTextMax = 256,
                pszText = pText
            };
            IntPtr r = User32.SendMessageW(listView1.Handle, (User32.WindowMessage)LVM.GETCOLUMN, (IntPtr)0, ref column);
            string s = new string(pText);
        }

        private void ReloadEvent(object sender, EventArgs e)
        {
            Reload();
        }

        private unsafe void Reload()
        {
            LVCF mask =
                LVCF.FMT |
                LVCF.TEXT |
                LVCF.IMAGE |
                LVCF.WIDTH |
                LVCF.MINWIDTH;
            var column = new LVCOLUMNW
            {
                mask = mask,
                cchTextMax = textTextBox.Text.Length,
                iImage = (int)imageIndexNumericUpDown.Value,
                cx = (int)widthNumericUpDown.Value,
                cxMin = (int)minimumWidthNumericUpDown.Value,
            };

            if (fixedWidthCheckBox.Checked)
            {
                column.fmt |= LVCFMT.FIXED_WIDTH;
            }
            if (splitButtonCheckBox.Checked)
            {
                column.fmt |= LVCFMT.SPLITBUTTON;
            }

            switch (alignComboBox.SelectedIndex)
            {
                case 0:
                    column.fmt |= LVCFMT.LEFT;
                    break;
                case 1:
                    column.fmt |= LVCFMT.CENTER;
                    break;
                case 2:
                    column.fmt |= LVCFMT.RIGHT;
                    break;
            }

            fixed (char* pText = textTextBox.Text)
            {
                column.pszText = pText;
                User32.SendMessageW(listView1.Handle, (User32.WindowMessage)LVM.SETCOLUMN, (IntPtr)1, ref column);
            }
        }

        private class SubListView : ListView
        {
            public new void RecreateHandle() => base.RecreateHandle();

            protected unsafe override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case (int)LVM.HITTEST:
                    case (int)LVM.GETITEM:
                    case (int)LVM.GETITEMRECT:
                    case (int)LVM.GETITEMCOUNT:
                    case (int)LVM.GETITEMSTATE:
                    case (int)LVM.GETNEXTITEM:
                    case (int)LVM.FINDITEM:
                    case (int)LVM.UPDATE:
                    case (int)LVM.SETTEXTBKCOLOR:
                    case (int)LVM.SETTEXTCOLOR:
                    case (int)LVM.SETBKCOLOR:
                    case (int)LVM.ENABLEGROUPVIEW:
                    case (int)LVM.SETIMAGELIST:
                    case (int)LVM.SETITEMSTATE:
                    case (int)LVM.SETVIEW:
                    case (int)User32.WindowMessage.WM_NCCREATE:
                    case (int)User32.WindowMessage.WM_NCCALCSIZE:
                    case (int)User32.WindowMessage.WM_CREATE:
                    case (int)User32.WindowMessage.WM_MOUSEHOVER:
                    case (int)User32.WindowMessage.WM_MOUSELEAVE:
                    case (int)User32.WindowMessage.WM_MOUSEMOVE:
                    case (int)User32.WindowMessage.WM_NCHITTEST:
                    case (int)User32.WindowMessage.WM_SETCURSOR:
                    case (int)User32.WindowMessage.WM_SETREDRAW:
                    case (int)User32.WindowMessage.WM_KILLFOCUS:
                    case (int)User32.WindowMessage.WM_PAINT:
                    case (int)User32.WindowMessage.WM_ERASEBKGND:
                    case (int)User32.WindowMessage.WM_CAPTURECHANGED:
                    case (int)User32.WindowMessage.WM_SIZE:
                    case (int)User32.WindowMessage.WM_MOVE:
                    case (int)User32.WindowMessage.WM_IME_SETCONTEXT:
                    case (int)User32.WindowMessage.WM_IME_NOTIFY:
                    case (int)User32.WindowMessage.WM_SETFOCUS:
                        base.WndProc(ref m);
                        break;
                    case (int)User32.WindowMessage.WM_LBUTTONUP:
                        base.DefWndProc(ref m);
                        break;
                    case (int)User32.WindowMessage.WM_REFLECT_NOTIFY:
                        User32.NMHDR* nmhdr = (User32.NMHDR*)m.LParam;
                        switch (nmhdr->code)
                        {
                            case (int)LVN.LINKCLICK:
                            case (int)LVN.GETDISPINFOW:
                            case (int)LVN.ITEMCHANGING:
                            case (int)LVN.ITEMCHANGED:
                            case (int)LVN.INSERTITEM:
                            case (int)LVN.MARQUEEBEGIN:
                            case (int)LVN.HOTTRACK:
                            case (int)NM.SETFOCUS:
                            case (int)NM.KILLFOCUS:
                            case (int)NM.CUSTOMDRAW:
                            case (int)NM.RELEASEDCAPTURE:
                            case (int)NM.CLICK:
                                base.WndProc(ref m);
                                break;
                            case (int)LVN.COLUMNDROPDOWN:
                                {
                                    NMLISTVIEW* nmlv = (NMLISTVIEW*)m.LParam;
                                    IntPtr header = User32.SendMessageW(Handle, (User32.WindowMessage)LVM.GETHEADER, IntPtr.Zero, IntPtr.Zero);

                                    RECT r1 = default;
                                    IntPtr result1 = User32.SendMessageW(header, (User32.WindowMessage)HDM.GETITEMDROPDOWNRECT, (IntPtr)nmlv->iSubItem, ref r1);
                                    Point p1 = PointToScreen(new Point(r1.left, r1.bottom));

                                    RECT r2 = default;
                                    IntPtr result2 = User32.SendMessageW(header, (User32.WindowMessage)HDM.GETITEMRECT, (IntPtr)nmlv->iSubItem, IntPtr.Zero);
                                    Point p2 = PointToScreen(new Point(r2.right - SystemInformation.MenuButtonSize.Width, r2.bottom));

                                    var menu = new ContextMenuStrip();
                                    EventHandler onClick = (sender, e) => { };
                                    menu.Items.Add(new ToolStripButton("Button") { CheckOnClick = true });
                                    menu.Show(p1);

                                    break;
                                }
                            default:
                                base.WndProc(ref m);
                                break;
                        }

                        break;
                    default:

                        //Debug.WriteLine((User32.WindowMessage)m.Msg);
                        base.WndProc(ref m);
                        break;
                }
            }
        }
    }
}
