namespace AutoTester
{
    partial class EventSetList
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
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_PrefabsDelete = new System.Windows.Forms.PictureBox();
            this.btn_PrefabsAdd = new System.Windows.Forms.PictureBox();
            this.listBox_EventSetList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.BackgroundImage = global::AutoTester.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(209, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(18, 18);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_PrefabsClose_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_PrefabsClose_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btn_Close);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 24);
            this.panel6.TabIndex = 12;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "이벤트집합 목록";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btn_PrefabsDelete
            // 
            this.btn_PrefabsDelete.BackgroundImage = global::AutoTester.Properties.Resources.Button_Minus;
            this.btn_PrefabsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrefabsDelete.Location = new System.Drawing.Point(24, 3);
            this.btn_PrefabsDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrefabsDelete.Name = "btn_PrefabsDelete";
            this.btn_PrefabsDelete.Size = new System.Drawing.Size(18, 18);
            this.btn_PrefabsDelete.TabIndex = 11;
            this.btn_PrefabsDelete.TabStop = false;
            this.btn_PrefabsDelete.Click += new System.EventHandler(this.btn_PrefabsDelete_Click);
            this.btn_PrefabsDelete.MouseEnter += new System.EventHandler(this.btn_PrefabsDel_MouseEnter);
            this.btn_PrefabsDelete.MouseLeave += new System.EventHandler(this.btn_PrefabsDel_MouseLeave);
            // 
            // btn_PrefabsAdd
            // 
            this.btn_PrefabsAdd.BackgroundImage = global::AutoTester.Properties.Resources.Button_Plus;
            this.btn_PrefabsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrefabsAdd.Location = new System.Drawing.Point(2, 3);
            this.btn_PrefabsAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrefabsAdd.Name = "btn_PrefabsAdd";
            this.btn_PrefabsAdd.Size = new System.Drawing.Size(18, 18);
            this.btn_PrefabsAdd.TabIndex = 10;
            this.btn_PrefabsAdd.TabStop = false;
            this.btn_PrefabsAdd.Click += new System.EventHandler(this.btn_PrefabsAdd_Click);
            this.btn_PrefabsAdd.MouseEnter += new System.EventHandler(this.btn_PrefabsAdd_MouseEnter);
            this.btn_PrefabsAdd.MouseLeave += new System.EventHandler(this.btn_PrefabsAdd_MouseLeave);
            // 
            // listBox_EventSetList
            // 
            this.listBox_EventSetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_EventSetList.Font = new System.Drawing.Font("D2Coding", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_EventSetList.FormattingEnabled = true;
            this.listBox_EventSetList.ItemHeight = 18;
            this.listBox_EventSetList.Location = new System.Drawing.Point(5, 56);
            this.listBox_EventSetList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.listBox_EventSetList.Name = "listBox_EventSetList";
            this.listBox_EventSetList.Size = new System.Drawing.Size(230, 166);
            this.listBox_EventSetList.TabIndex = 13;
            this.listBox_EventSetList.SelectedIndexChanged += new System.EventHandler(this.listBox_EventSetList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btn_PrefabsDelete);
            this.panel1.Controls.Add(this.btn_PrefabsAdd);
            this.panel1.Location = new System.Drawing.Point(5, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 24);
            this.panel1.TabIndex = 13;
            // 
            // EventSetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_EventSetList);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(256, 512);
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "EventSetList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventSetList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btn_PrefabsDelete;
        private System.Windows.Forms.PictureBox btn_PrefabsAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_EventSetList;
        private System.Windows.Forms.Panel panel1;
    }
}