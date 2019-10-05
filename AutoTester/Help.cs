using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoTester
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            string str = richTextBox_0.Rtf;
            str = Properties.Resources.키_입력_도움말;
            richTextBox_0.Rtf = str;
            richTextBox_0.ReadOnly = true;

            str = richTextBox_Home.Rtf;
            str = Properties.Resources.도움말_홈;
            richTextBox_Home.Rtf = str;
            richTextBox_Home.ReadOnly = true;

            str = richTextBox2.Rtf;
            str = Properties.Resources.메뉴_표시줄;
            richTextBox2.Rtf = str;
            richTextBox2.ReadOnly = true;

            str = richTextBox1.Rtf;
            str = Properties.Resources.이벤트_집합과_워크플로우;
            richTextBox1.Rtf = str;
            richTextBox1.ReadOnly = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(4);
        }

        private void Top_Home_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
        }

        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.Owner).HelpOn = false;
        }

        private void Top_SWInfo_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(5);
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(5);
        }
    }
}
