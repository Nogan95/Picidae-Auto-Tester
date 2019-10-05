using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoTestStructure;
using System.IO;
using System.Runtime.InteropServices;

namespace AutoTester
{
    public partial class PopEventFromImage : Form
    {
        public MacroNode NewNode;
        HashSet<string> curList;
        List<Image> imgList = new List<Image>();
        double height = 0;
        double width = 0;
        bool imageLoad=false;

        public PopEventFromImage(HashSet<string> _curList)
        {
            InitializeComponent();
            comboBox_Type.SelectedIndex = 1;
            curList = _curList;
        }

        private void button_AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg|비트맵|*.bmp";
            openImage.Multiselect = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                foreach(string fname in openImage.FileNames)
                {
                    using (FileStream stream = new FileStream(fname, FileMode.Open, FileAccess.Read))               
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        // Image의 메모리 점유 문제를 해결하기 위해 메모리 스트림으로 이미지를 읽는다.
                        var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                        Image tmp = Image.FromStream(memoryStream);
                        listView_Image.Items.Add(new ListViewItem(fname.Split('\\').Last()));
                        imgList.Add((Image)tmp.Clone());                        
                    } 
                }     
            }
        }

        public event EventHandler AddButtonClick;

        private void AddPrefeb()
        {
            if (AddButtonClick == null)
            {
                return;
            }

            if (textBox_interval.Text.Equals("") || textBox_Tag.Text.Equals(""))
            {
                MessageBox.Show("유효한 모든 필드를 채워넣으십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (curList.Contains(textBox_Tag.Text))
            {
                MessageBox.Show("중복된 Tag의 이벤트을 저장할 수 없습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* 프 리 펩 저 장*/
            NewNode = new MacroNode();
            NewNode.x = int.Parse(textBox_PositionX.Text);
            NewNode.y = int.Parse(textBox_PositionY.Text);
            NewNode.interval = int.Parse(textBox_interval.Text);
            NewNode.tag = textBox_Tag.Text;
            if (comboBox_Type.SelectedIndex == 0)
                NewNode.state = NodeStates.마우스_이동;
            else
                NewNode.state = NodeStates.마우스_이동_후_왼쪽클릭;
            Invoke(AddButtonClick, null); 
        }


        private void button_AddPrefeb_Click(object sender, EventArgs e)
        {
            AddPrefeb();
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void listView_Image_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_Image.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_Image.SelectedIndices[0];                
                pictureBox_ImageArea.BackgroundImage = imgList[selectedIndex];
                height = imgList[selectedIndex].Size.Height;
                width = imgList[selectedIndex].Size.Width;
                label_curPosition.Text = string.Format("(0/{0}, 0/{1})", width, height);
                label_ImageTitle.Text = listView_Image.Items[selectedIndex].Text;
                imageLoad = true;
            }                      
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_PositionX.Text = ((int)(e.Location.X * (width / pictureBox_ImageArea.Size.Width))).ToString();
            textBox_PositionY.Text = ((int)(e.Location.Y * (height / pictureBox_ImageArea.Size.Height))).ToString();
            if (imageLoad)
            {
                pictureBox_ImageArea.Refresh();
                Graphics g;
                Pen myPen = new Pen(Color.Red, 2);
                g = ((PictureBox)sender).CreateGraphics();
                g.DrawRectangle(myPen, new Rectangle(e.Location.X - 1, e.Location.Y - 5, 1, 9));
                g.DrawRectangle(myPen, new Rectangle(e.Location.X - 5, e.Location.Y - 1, 9, 1));
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(imageLoad)
                label_curPosition.Text = string.Format("({0}/{1}, {2}/{3})", (int)(e.Location.X * (width / pictureBox_ImageArea.Size.Width)), width, (int)(e.Location.Y * (height / pictureBox_ImageArea.Size.Height)), height);
        }

        private void AddPrefabFromImagePoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).ImagePrefabEditorOn = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddPrefeb();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
            Close();
        }
        private void btn_PrefabsClose_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close_Hover;
        }

        private void btn_PrefabsClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close;
        }
    }
}
