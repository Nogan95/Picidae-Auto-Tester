namespace AutoTester
{
    partial class NodeEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_AddPrefeb = new System.Windows.Forms.Button();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Tag = new System.Windows.Forms.TextBox();
            this.textBox_PositionX = new System.Windows.Forms.TextBox();
            this.label_Position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Position3 = new System.Windows.Forms.Label();
            this.label_Position4 = new System.Windows.Forms.Label();
            this.textBox_PositionY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Position2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Keyborad = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddPrefeb
            // 
            this.button_AddPrefeb.Location = new System.Drawing.Point(103, 179);
            this.button_AddPrefeb.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddPrefeb.Name = "button_AddPrefeb";
            this.button_AddPrefeb.Size = new System.Drawing.Size(60, 22);
            this.button_AddPrefeb.TabIndex = 0;
            this.button_AddPrefeb.Text = "추가";
            this.button_AddPrefeb.UseVisualStyleBackColor = true;
            this.button_AddPrefeb.Click += new System.EventHandler(this.button_AddPrefeb_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.Location = new System.Drawing.Point(176, 179);
            this.button_Cancle.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(60, 22);
            this.button_Cancle.TabIndex = 1;
            this.button_Cancle.Text = "취소";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "마우스:이동",
            "마우스:클릭(왼쪽)",
            "마우스:클릭(오른쪽)",
            "마우스:더블클릭",
            "마우스:휠클릭",
            "마우스:이동 후 왼쪽클릭",
            "마우스:누르기(왼쪽)",
            "마우스:떼기(왼쪽)",
            "마우스:누르기(오른쪽)",
            "마우스:떼기(오른쪽)",
            "마우스:누르기(휠)",
            "마우스:떼기(휠)",
            "시스템:대기",
            "시스템:스크린샷 찍기",
            "키보드:키 입력"});
            this.comboBox_Type.Location = new System.Drawing.Point(84, 37);
            this.comboBox_Type.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(150, 20);
            this.comboBox_Type.TabIndex = 2;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag";
            // 
            // textBox_Tag
            // 
            this.textBox_Tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Tag.Location = new System.Drawing.Point(84, 77);
            this.textBox_Tag.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Tag.Name = "textBox_Tag";
            this.textBox_Tag.Size = new System.Drawing.Size(150, 21);
            this.textBox_Tag.TabIndex = 4;
            // 
            // textBox_PositionX
            // 
            this.textBox_PositionX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PositionX.Location = new System.Drawing.Point(84, 101);
            this.textBox_PositionX.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PositionX.Name = "textBox_PositionX";
            this.textBox_PositionX.Size = new System.Drawing.Size(47, 21);
            this.textBox_PositionX.TabIndex = 6;
            this.textBox_PositionX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.ForeColor = System.Drawing.Color.White;
            this.label_Position.Location = new System.Drawing.Point(6, 103);
            this.label_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(50, 12);
            this.label_Position.TabIndex = 5;
            this.label_Position.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Keyboard";
            // 
            // textBox_interval
            // 
            this.textBox_interval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_interval.Location = new System.Drawing.Point(84, 125);
            this.textBox_interval.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(126, 21);
            this.textBox_interval.TabIndex = 10;
            this.textBox_interval.Text = "800";
            this.textBox_interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(215, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "ms";
            // 
            // label_Position3
            // 
            this.label_Position3.AutoSize = true;
            this.label_Position3.ForeColor = System.Drawing.Color.White;
            this.label_Position3.Location = new System.Drawing.Point(136, 109);
            this.label_Position3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position3.Name = "label_Position3";
            this.label_Position3.Size = new System.Drawing.Size(27, 12);
            this.label_Position3.TabIndex = 13;
            this.label_Position3.Text = "px ,";
            // 
            // label_Position4
            // 
            this.label_Position4.AutoSize = true;
            this.label_Position4.ForeColor = System.Drawing.Color.White;
            this.label_Position4.Location = new System.Drawing.Point(215, 109);
            this.label_Position4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position4.Name = "label_Position4";
            this.label_Position4.Size = new System.Drawing.Size(19, 12);
            this.label_Position4.TabIndex = 18;
            this.label_Position4.Text = "px";
            // 
            // textBox_PositionY
            // 
            this.textBox_PositionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PositionY.Location = new System.Drawing.Point(164, 101);
            this.textBox_PositionY.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PositionY.Name = "textBox_PositionY";
            this.textBox_PositionY.Size = new System.Drawing.Size(47, 21);
            this.textBox_PositionY.TabIndex = 17;
            this.textBox_PositionY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(70, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(70, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = ":";
            // 
            // label_Position2
            // 
            this.label_Position2.AutoSize = true;
            this.label_Position2.ForeColor = System.Drawing.Color.White;
            this.label_Position2.Location = new System.Drawing.Point(70, 103);
            this.label_Position2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position2.Name = "label_Position2";
            this.label_Position2.Size = new System.Drawing.Size(9, 12);
            this.label_Position2.TabIndex = 22;
            this.label_Position2.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(70, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(70, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = ":";
            // 
            // textBox_Keyborad
            // 
            this.textBox_Keyborad.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Keyborad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Keyborad.Location = new System.Drawing.Point(84, 149);
            this.textBox_Keyborad.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Keyborad.Name = "textBox_Keyborad";
            this.textBox_Keyborad.Size = new System.Drawing.Size(150, 21);
            this.textBox_Keyborad.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btn_Close);
            this.panel6.Controls.Add(this.label_Title);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 24);
            this.panel6.TabIndex = 26;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.BackgroundImage = global::AutoTester.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(217, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(18, 18);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_PrefabsClose_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_PrefabsClose_MouseLeave);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(2, 6);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(85, 12);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "새 이밴트 추가";
            this.label_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // NodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(242, 215);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox_Keyborad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_Position2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Position4);
            this.Controls.Add(this.textBox_PositionY);
            this.Controls.Add(this.label_Position3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_interval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_PositionX);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.textBox_Tag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.button_AddPrefeb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 231);
            this.Name = "NodeEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NodeEditor_FormClosing);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddPrefeb;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Tag;
        private System.Windows.Forms.TextBox textBox_PositionX;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Position3;
        private System.Windows.Forms.Label label_Position4;
        private System.Windows.Forms.TextBox textBox_PositionY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Position2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Keyborad;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label_Title;
    }
}