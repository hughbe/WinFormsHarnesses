using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interop;
using static Interop.ComCtl32;

namespace WindowsFormsApp1
{
    public partial class Groups : Form
    {
        public Groups()
        {
            new ListViewGroup();
            InitializeComponent();
            User32.SendMessageW(listView1.Handle, (User32.WindowMessage)LVM.SETIMAGELIST, (IntPtr)LVSIL.GROUPHEADER, listView1.SmallImageList.Handle);
        }

        private void ReloadEvent(object sender, EventArgs e)
        {
            ReloadListView();
        }

        private unsafe void ReloadListView()
        {
            ListViewGroup group = listView1.Groups[0];
            int id = (int)typeof(ListViewGroup).GetProperty("ID", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(group);

            IntPtr lParam = (IntPtr)id;
            LVGF mask = 0;
            mask |= LVGF.HEADER;
            mask |= LVGF.SUBTITLE;
            mask |= LVGF.FOOTER;
            mask |= LVGF.ALIGN;
            mask |= LVGF.DESCRIPTIONBOTTOM;
            mask |= LVGF.DESCRIPTIONTOP;
            mask |= LVGF.STATE;
            mask |= LVGF.TASK;
            mask |= LVGF.TITLEIMAGE;
            mask |= LVGF.EXTENDEDIMAGE;
            LVGS stateMask =
                LVGS.COLLAPSED |
                LVGS.COLLAPSIBLE |
                LVGS.NOHEADER |
                LVGS.SUBSETED |
                0;
            LVGS state = 0;
            if (collapsibleCheckBox.Checked)
            {
                state |= LVGS.COLLAPSIBLE;
            }
            if (collapsedCheckBox.Checked)
            {
                state |= LVGS.COLLAPSED;
            }
            if (!showHeaderCheckBox.Checked)
            {
                state |= LVGS.NOHEADER;
            }
            if (subsetTitleCheckBox.Checked)
            {
                state |= LVGS.SUBSETED;
            }
            var lvgroup = new LVGROUPW
            {
                cbSize = (uint)sizeof(LVGROUPW),
                mask = mask,
                iGroupId = id,
                stateMask = stateMask,
                state = state,
                iTitleImage = (int)titleImageIndexNumericUpDown.Value,
                iExtendedImage = (int)extendedImageIndexNumericUpDown.Value,
            };

            switch (headerAlignmentComboBox.SelectedIndex)
            {
                case 0:
                    lvgroup.uAlign |= LVGA.HEADER_LEFT;
                    break;
                case 1:
                    lvgroup.uAlign |= LVGA.HEADER_CENTER;
                    break;
                case 2:
                    lvgroup.uAlign |= LVGA.HEADER_RIGHT;
                    break;
            }

            switch (footerAlignmentComboBox.SelectedIndex)
            {
                case 0:
                    lvgroup.uAlign |= LVGA.FOOTER_LEFT;
                    break;
                case 1:
                    lvgroup.uAlign |= LVGA.FOOTER_CENTER;
                    break;
                case 2:
                    lvgroup.uAlign |= LVGA.FOOTER_RIGHT;
                    break;
            }

            fixed (char* pHeader = headerTextBox.Text)
            fixed (char* pFooter = footerTextBox.Text)
            fixed (char* pDescriptionBottom = descriptionBottomTextBox.Text)
            fixed (char* pDescriptionTop = descriptionTopTextBox.Text)
            fixed (char* pSubsetTitle = subsetTitleTextBox.Text)
            fixed (char* pSubtitle = subtitleTextBox.Text)
            fixed (char* pTask = taskTextBox.Text)
            {
                if (footerCheckBox.Checked && footerTextBox.Text.Length > 0)
                {
                    lvgroup.cchFooter = footerTextBox.Text.Length;
                    lvgroup.pszFooter = pFooter;
                }
                if (descriptionBottomCheckBox.Checked)
                {
                    lvgroup.cchDescriptionBottom = (uint)descriptionBottomTextBox.Text.Length;
                    lvgroup.pszDescriptionBottom = pDescriptionBottom;
                }
                if (descriptionTopCheckBox.Checked)
                {
                    lvgroup.cchDescriptionTop = (uint)descriptionTopTextBox.Text.Length;
                    lvgroup.pszDescriptionTop = pDescriptionTop;
                }
                if (subsetTitleCheckBox.Checked)
                {
                    lvgroup.cchSubsetTitle = (uint)subsetTitleTextBox.Text.Length;
                    lvgroup.pszSubsetTitle = pSubsetTitle;
                }
                if (subtitleCheckBox.Checked)
                {
                    lvgroup.cchSubsetTitle = (uint)subtitleTextBox.Text.Length;
                    lvgroup.pszSubtitle = pSubtitle;
                }
                if (taskCheckBox.Checked && taskTextBox.Text.Length > 0)
                {
                    lvgroup.cchTask = (uint)taskTextBox.Text.Length;
                    lvgroup.pszTask = pTask;
                }

                lvgroup.pszHeader = pHeader;
                IntPtr result = User32.SendMessageW(listView1.Handle, (User32.WindowMessage)LVM.SETGROUPINFO, lParam, ref lvgroup);

                listView1.Invalidate(true);
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
                                NMLVLINK* link = (NMLVLINK*)m.LParam;
                                string task = "Clicked";
                                var group = new LVGROUPW
                                {
                                    cbSize = (uint)sizeof(LVGROUPW),
                                    mask = LVGF.TASK,
                                    cchTask = (uint)task.Length
                                };
                                fixed (char* pTask = "Clicked")
                                {
                                    group.pszTask = pTask;
                                    User32.SendMessageW(Handle, (User32.WindowMessage)LVM.SETGROUPINFO, (IntPtr)link->iSubItem, ref group);
                                    MessageBox.Show("Link Clicked");
                                }
                                break;
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
                            default:
                                break;
                        }

                        base.WndProc(ref m);
                        break;
                    default:

                        //Debug.WriteLine((User32.WindowMessage)m.Msg);
                        base.WndProc(ref m);
                        break;
                }
            }
        }

        private void viewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (viewComboBox.SelectedIndex)
            {
                case 0:
                    listView1.View = View.LargeIcon;
                    break;
                case 1:
                    listView1.View = View.Details;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.Details;
                    break;
                case 4:
                    listView1.View = View.Tile;
                    break;
            }
        }

        private unsafe void updateMetricsButton_Click(object sender, EventArgs e)
        {
            ListViewGroup group = listView1.Groups[0];
            int id = (int)typeof(ListViewGroup).GetProperty("ID", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(group);

            //listView1.MultiSelect = true;

            var metrics = new LVGROUPMETRICS
            {
                cbSize = (uint)sizeof(LVGROUPMETRICS),
                mask = LVGMF.BORDERSIZE | LVGMF.BORDERCOLOR
            };
            metrics.Right = 50;
            metrics.Left = 50;
            metrics.Top = 50;
            metrics.Bottom = 50;
            metrics.crRight = (uint)COLORREF.ColorToCOLORREF(Color.Red);
            metrics.crLeft = (uint)COLORREF.ColorToCOLORREF(Color.Red);
            metrics.crTop = (uint)COLORREF.ColorToCOLORREF(Color.Red);
            metrics.crBottom = (uint)COLORREF.ColorToCOLORREF(Color.Red);
            IntPtr r = User32.SendMessageW(listView1.Handle, (User32.WindowMessage)LVM.SETGROUPMETRICS, (IntPtr)id, ref metrics);
        }
    }
}
