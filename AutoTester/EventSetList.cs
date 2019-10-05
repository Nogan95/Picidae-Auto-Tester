using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using AutoTestStructure;

namespace AutoTester
{
    public partial class EventSetList : Form
    {
        public EventSetList()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void btn_PrefabsClose_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close_Hover;
        }

        private void btn_PrefabsClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close;
        }

        private void btn_PrefabsAdd_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Plus_Hover_;
        }

        private void btn_PrefabsAdd_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Plus;
        }

        private void btn_PrefabsDel_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Minus_Hover_;
        }

        private void btn_PrefabsDel_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Minus;
        }


        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public List<PrefabsSaveFormat> eventSetList = new List<PrefabsSaveFormat>();
        public int SelectedIndex = 0;
        private const string PROGRAM_KEY_WORD = "Picidae";
        private const string EVENT_SET_EXTENTION = "*.paes";

        private void btn_PrefabsAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialig = new OpenFileDialog();
            openFileDialig.Filter = string.Format("{0} {1}|{2}", PROGRAM_KEY_WORD, "이벤트 집합", EVENT_SET_EXTENTION);
            openFileDialig.Title = "이벤트 집합 열기";
            openFileDialig.Multiselect = true;
            if (openFileDialig.ShowDialog() == DialogResult.OK)
            {
                foreach(string fileName in openFileDialig.FileNames)
                {
                    PrefabsSaveFormat openedData;
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (Stream stream = File.Open(fileName, FileMode.Open))
                        openedData = (PrefabsSaveFormat)formatter.Deserialize(stream);
                    eventSetList.Add(openedData);
                    listBox_EventSetList.Items.Add(fileName.Split('\\').Last());
                }
            }
        }

        private void btn_PrefabsDelete_Click(object sender, EventArgs e)
        {
            if (listBox_EventSetList.SelectedIndex > -1)
            {
                int index = listBox_EventSetList.SelectedIndex;
                eventSetList.RemoveAt(index);
                listBox_EventSetList.Items.RemoveAt(index);
            }
        }

        public EventHandler SelectEventSet = null;

        private void listBox_EventSetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = listBox_EventSetList.SelectedIndex;
            if (SelectEventSet != null)
            {
                Invoke(SelectEventSet,sender, e);                
            }
        }

        private void EventSetList_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).EventSetListOn = false;
        }
        
    }
}
