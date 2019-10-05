using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoTestStructure;
using System.Runtime.InteropServices;

namespace AutoTester
{
    public partial class NodeEditor : Form
    {
        public MacroNode NewNode;
        HashSet<string> curKey;
        public PopType Type;
        public enum PopType
        {
            NewPrefab,
            NewNode,
            EditNode
        }

        public NodeEditor(HashSet<string> _curKey, PopType type)
        {
            Type = type;
            if (type == PopType.NewPrefab)
            {
                InitializeComponent();
                comboBox_Type.SelectedIndex = 5;
                curKey = _curKey;
            }
        }

        public NodeEditor(PopType type)
        {
            Type = type;
            if (type == PopType.EditNode)
            {
                InitializeComponent();
                comboBox_Type.SelectedIndex = 5;
                label_Title.Text = "워크플로우 편집기";
                button_Cancle.Enabled = false;
                button_Cancle.Visible = false;
                button_AddPrefeb.Text = "적용";
                button_AddPrefeb.Location = button_Cancle.Location;
            }
            else if (type == PopType.NewNode)
            {
                InitializeComponent();
                comboBox_Type.SelectedIndex = 5;
                label_Title.Text = "새 워크플로우 추가";
            }
        }

        public void setEditor(MacroNode selectedNode)
        {
            textBox_PositionX.Text = selectedNode.x.ToString();
            textBox_PositionY.Text = selectedNode.y.ToString();
            textBox_interval.Text = selectedNode.interval.ToString();
            textBox_Tag.Text = selectedNode.tag.ToString();
            textBox_Keyborad.Text = selectedNode.inputString;
            comboBox_Type.SelectedIndex = (int)selectedNode.state;
        }

        private void button_AddPrefeb_Click(object sender, EventArgs e)
        {
            AddNode();
        }

        public event EventHandler AddButtonClick;

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {            
            NodeStates ns = (NodeStates)comboBox_Type.SelectedIndex;
            PositionEnabled(ns == NodeStates.마우스_이동 || ns == NodeStates.마우스_이동_후_왼쪽클릭);
            textBox_Keyborad.Enabled = (ns == NodeStates.키보드_키입력);
            textBox_Keyborad.BackColor = EnableColor(textBox_Keyborad.Enabled);
        }

        private bool IsInvaild(bool checkType2)
        {
            if (Type == PopType.NewPrefab &&(textBox_Tag.Text.Equals("") || textBox_interval.Text.Equals("")))
                return true;
            if (checkType2)
                if (textBox_PositionX.Text.Equals("") || textBox_PositionY.Text.Equals(""))
                    return true;
            return false;
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
        }

        private void PositionEnabled(bool status)
        {
            textBox_PositionX.Enabled = status;
            textBox_PositionY.Enabled = status;
            textBox_PositionX.BackColor = EnableColor(status);
            textBox_PositionY.BackColor = EnableColor(status);
        }

        private Color EnableColor(bool Enabled)
        {
            if (Enabled)
                return SystemColors.Window;                
            else
                return Color.FromArgb(255, 89, 89, 89);
        }

        private void NodeEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Type == PopType.EditNode)
            {
                ((MainForm)this.Owner).nodeEditorOn = false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddNode();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddNode()
        {
            NodeStates ns = (NodeStates)comboBox_Type.SelectedIndex;
            if (IsInvaild(ns == NodeStates.마우스_이동 || ns == NodeStates.마우스_이동_후_왼쪽클릭))
            {
                if (Type == PopType.NewPrefab)
                    MessageBox.Show("유효한 모든 필드를 채워넣으십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Tag를 제외한 모든 필드를 채워넣으십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Type == PopType.NewPrefab && curKey.Contains(textBox_Tag.Text))
            {
                MessageBox.Show("중복된 Tag의 이벤트을 저장할 수 없습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* 프 리 펩 저 장*/
            NewNode = new MacroNode();
            if (ns == NodeStates.마우스_이동 || ns == NodeStates.마우스_이동_후_왼쪽클릭)
            {
                NewNode.x = int.Parse(textBox_PositionX.Text);
                NewNode.y = int.Parse(textBox_PositionY.Text);
            }
            NewNode.interval = int.Parse(textBox_interval.Text);
            NewNode.tag = textBox_Tag.Text;
            NewNode.state = ns;
            NewNode.inputString = textBox_Keyborad.Text;
            ((MainForm)this.Owner).addSuccess = true;

            if (Type == PopType.EditNode)
            {
                Invoke(AddButtonClick, null);
            }
            else
                this.Visible = false;
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
