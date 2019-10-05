using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoTester
{
    public partial class SetWorkflowColumn : Form
    {
        private MainForm.ColumnFlag AfterFlag;
        public SetWorkflowColumn(MainForm.ColumnFlag MainListColumnFlag)
        {
            InitializeComponent();
            AfterFlag = MainListColumnFlag;
            if ((AfterFlag & MainForm.ColumnFlag.Tag) != 0)
                Option_Tag.Checked = true;
            if ((AfterFlag & MainForm.ColumnFlag.Point) != 0)
                Option_Point.Checked = true;
            if ((AfterFlag & MainForm.ColumnFlag.Interval) != 0)
                Option_Interval.Checked = true;
            if ((AfterFlag & MainForm.ColumnFlag.InputString) != 0)
                Option_InputString.Checked = true;          
        }

        private void Option_CheckedChanged(object sender, EventArgs e)        
        {
            
            if (((CheckBox)sender).Checked)
                AfterFlag |= (MainForm.ColumnFlag)Enum.Parse(typeof(MainForm.ColumnFlag), ((CheckBox)sender).Text);
            else
                AfterFlag ^= (MainForm.ColumnFlag)Enum.Parse(typeof(MainForm.ColumnFlag), ((CheckBox)sender).Text);
            Console.WriteLine(AfterFlag.ToString());
        }

        private void button_확인_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).MainListColumnFlag = AfterFlag;
            this.Close();
        }

        private void button_취소_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PrefabsClose_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close_Hover;
        }

        private void btn_PrefabsClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
