namespace AutoTester
{
    partial class PopEventFromImage
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
            this.listView_Image = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_AddImage = new System.Windows.Forms.Button();
            this.label_curPosition = new System.Windows.Forms.Label();
            this.pictureBox_ImageArea = new System.Windows.Forms.PictureBox();
            this.label_ImageTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_AddPrefeb = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Position2 = new System.Windows.Forms.Label();
            this.textBox_Tag = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_PositionX = new System.Windows.Forms.TextBox();
            this.label_Position4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PositionY = new System.Windows.Forms.TextBox();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.label_Position3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageArea)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Image
            // 
            this.listView_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Image.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Image.Location = new System.Drawing.Point(7, 356);
            this.listView_Image.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Image.MultiSelect = false;
            this.listView_Image.Name = "listView_Image";
            this.listView_Image.Size = new System.Drawing.Size(202, 165);
            this.listView_Image.TabIndex = 69;
            this.listView_Image.UseCompatibleStateImageBehavior = false;
            this.listView_Image.View = System.Windows.Forms.View.Details;
            this.listView_Image.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Image_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이미지 목록";
            this.columnHeader1.Width = 181;
            // 
            // button_AddImage
            // 
            this.button_AddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddImage.Location = new System.Drawing.Point(121, 526);
            this.button_AddImage.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddImage.Name = "button_AddImage";
            this.button_AddImage.Size = new System.Drawing.Size(88, 22);
            this.button_AddImage.TabIndex = 67;
            this.button_AddImage.Text = "이미지 추가";
            this.button_AddImage.UseVisualStyleBackColor = true;
            this.button_AddImage.Click += new System.EventHandler(this.button_AddImage_Click);
            // 
            // label_curPosition
            // 
            this.label_curPosition.AutoSize = true;
            this.label_curPosition.ForeColor = System.Drawing.Color.White;
            this.label_curPosition.Location = new System.Drawing.Point(5, 33);
            this.label_curPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_curPosition.Name = "label_curPosition";
            this.label_curPosition.Size = new System.Drawing.Size(59, 12);
            this.label_curPosition.TabIndex = 71;
            this.label_curPosition.Text = "(0/0, 0/0)";
            // 
            // pictureBox_ImageArea
            // 
            this.pictureBox_ImageArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ImageArea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox_ImageArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ImageArea.Location = new System.Drawing.Point(7, 52);
            this.pictureBox_ImageArea.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ImageArea.Name = "pictureBox_ImageArea";
            this.pictureBox_ImageArea.Size = new System.Drawing.Size(474, 274);
            this.pictureBox_ImageArea.TabIndex = 67;
            this.pictureBox_ImageArea.TabStop = false;
            this.pictureBox_ImageArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox_ImageArea.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox_ImageArea.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox_ImageArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label_ImageTitle
            // 
            this.label_ImageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ImageTitle.ForeColor = System.Drawing.Color.White;
            this.label_ImageTitle.Location = new System.Drawing.Point(213, 25);
            this.label_ImageTitle.Name = "label_ImageTitle";
            this.label_ImageTitle.Size = new System.Drawing.Size(266, 21);
            this.label_ImageTitle.TabIndex = 72;
            this.label_ImageTitle.Text = "  ";
            this.label_ImageTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 24);
            this.panel1.TabIndex = 73;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::AutoTester.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(461, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(18, 18);
            this.btn_Close.TabIndex = 74;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_PrefabsClose_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_PrefabsClose_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이미지로 이밴트 추가";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(7, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 24);
            this.panel2.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "이미지 목록";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(234, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 24);
            this.panel3.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "속성";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(237, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 12);
            this.label9.TabIndex = 89;
            this.label9.Text = "Type";
            // 
            // button_AddPrefeb
            // 
            this.button_AddPrefeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddPrefeb.ForeColor = System.Drawing.Color.Black;
            this.button_AddPrefeb.Location = new System.Drawing.Point(362, 526);
            this.button_AddPrefeb.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddPrefeb.Name = "button_AddPrefeb";
            this.button_AddPrefeb.Size = new System.Drawing.Size(119, 22);
            this.button_AddPrefeb.TabIndex = 77;
            this.button_AddPrefeb.Text = "이벤트 집합에 추가";
            this.button_AddPrefeb.UseVisualStyleBackColor = true;
            this.button_AddPrefeb.Click += new System.EventHandler(this.button_AddPrefeb_Click);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "마우스:이동",
            "마우스:이동 후 왼쪽클릭"});
            this.comboBox_Type.Location = new System.Drawing.Point(321, 365);
            this.comboBox_Type.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(160, 20);
            this.comboBox_Type.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(297, 475);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 12);
            this.label13.TabIndex = 93;
            this.label13.Text = ":";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tag";
            // 
            // label_Position2
            // 
            this.label_Position2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Position2.AutoSize = true;
            this.label_Position2.ForeColor = System.Drawing.Color.White;
            this.label_Position2.Location = new System.Drawing.Point(297, 445);
            this.label_Position2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position2.Name = "label_Position2";
            this.label_Position2.Size = new System.Drawing.Size(9, 12);
            this.label_Position2.TabIndex = 92;
            this.label_Position2.Text = ":";
            // 
            // textBox_Tag
            // 
            this.textBox_Tag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Tag.Location = new System.Drawing.Point(321, 413);
            this.textBox_Tag.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Tag.Name = "textBox_Tag";
            this.textBox_Tag.Size = new System.Drawing.Size(160, 21);
            this.textBox_Tag.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(297, 415);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 12);
            this.label11.TabIndex = 91;
            this.label11.Text = ":";
            // 
            // label_Position
            // 
            this.label_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Position.AutoSize = true;
            this.label_Position.ForeColor = System.Drawing.Color.White;
            this.label_Position.Location = new System.Drawing.Point(237, 445);
            this.label_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(50, 12);
            this.label_Position.TabIndex = 81;
            this.label_Position.Text = "Position";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(297, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 90;
            this.label10.Text = ":";
            // 
            // textBox_PositionX
            // 
            this.textBox_PositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PositionX.Location = new System.Drawing.Point(321, 443);
            this.textBox_PositionX.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PositionX.Name = "textBox_PositionX";
            this.textBox_PositionX.ReadOnly = true;
            this.textBox_PositionX.Size = new System.Drawing.Size(47, 21);
            this.textBox_PositionX.TabIndex = 82;
            // 
            // label_Position4
            // 
            this.label_Position4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Position4.AutoSize = true;
            this.label_Position4.ForeColor = System.Drawing.Color.White;
            this.label_Position4.Location = new System.Drawing.Point(460, 450);
            this.label_Position4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position4.Name = "label_Position4";
            this.label_Position4.Size = new System.Drawing.Size(19, 12);
            this.label_Position4.TabIndex = 88;
            this.label_Position4.Text = "px";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(237, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 83;
            this.label4.Text = "interval";
            // 
            // textBox_PositionY
            // 
            this.textBox_PositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PositionY.Location = new System.Drawing.Point(409, 442);
            this.textBox_PositionY.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PositionY.Name = "textBox_PositionY";
            this.textBox_PositionY.ReadOnly = true;
            this.textBox_PositionY.Size = new System.Drawing.Size(47, 21);
            this.textBox_PositionY.TabIndex = 87;
            // 
            // textBox_interval
            // 
            this.textBox_interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_interval.Location = new System.Drawing.Point(321, 473);
            this.textBox_interval.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(135, 21);
            this.textBox_interval.TabIndex = 84;
            this.textBox_interval.Text = "800";
            // 
            // label_Position3
            // 
            this.label_Position3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Position3.AutoSize = true;
            this.label_Position3.ForeColor = System.Drawing.Color.White;
            this.label_Position3.Location = new System.Drawing.Point(372, 450);
            this.label_Position3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position3.Name = "label_Position3";
            this.label_Position3.Size = new System.Drawing.Size(27, 12);
            this.label_Position3.TabIndex = 86;
            this.label_Position3.Text = "px ,";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(458, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 85;
            this.label5.Text = "ms";
            // 
            // AddPrefabFromImagePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(486, 558);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_AddPrefeb);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Position2);
            this.Controls.Add(this.textBox_Tag);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_PositionX);
            this.Controls.Add(this.label_Position4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PositionY);
            this.Controls.Add(this.textBox_interval);
            this.Controls.Add(this.label_Position3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ImageTitle);
            this.Controls.Add(this.label_curPosition);
            this.Controls.Add(this.button_AddImage);
            this.Controls.Add(this.listView_Image);
            this.Controls.Add(this.pictureBox_ImageArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(486, 549);
            this.Name = "AddPrefabFromImagePoint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPrefabFromImagePoint_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ImageArea;
        private System.Windows.Forms.ListView listView_Image;
        private System.Windows.Forms.Button button_AddImage;
        private System.Windows.Forms.Label label_curPosition;
        private System.Windows.Forms.Label label_ImageTitle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_AddPrefeb;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Position2;
        private System.Windows.Forms.TextBox textBox_Tag;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_PositionX;
        private System.Windows.Forms.Label label_Position4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PositionY;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Label label_Position3;
        private System.Windows.Forms.Label label5;

    }
}