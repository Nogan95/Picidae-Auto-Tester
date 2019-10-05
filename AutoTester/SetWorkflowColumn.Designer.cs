namespace AutoTester
{
    partial class SetWorkflowColumn
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
            this.button_확인 = new System.Windows.Forms.Button();
            this.button_취소 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Option_InputString = new System.Windows.Forms.CheckBox();
            this.Option_Point = new System.Windows.Forms.CheckBox();
            this.Option_Interval = new System.Windows.Forms.CheckBox();
            this.Option_Tag = new System.Windows.Forms.CheckBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // button_확인
            // 
            this.button_확인.Location = new System.Drawing.Point(47, 125);
            this.button_확인.Name = "button_확인";
            this.button_확인.Size = new System.Drawing.Size(75, 23);
            this.button_확인.TabIndex = 0;
            this.button_확인.Text = "확인";
            this.button_확인.UseVisualStyleBackColor = true;
            this.button_확인.Click += new System.EventHandler(this.button_확인_Click);
            // 
            // button_취소
            // 
            this.button_취소.Location = new System.Drawing.Point(128, 125);
            this.button_취소.Name = "button_취소";
            this.button_취소.Size = new System.Drawing.Size(75, 23);
            this.button_취소.TabIndex = 1;
            this.button_취소.Text = "취소";
            this.button_취소.UseVisualStyleBackColor = true;
            this.button_취소.Click += new System.EventHandler(this.button_취소_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btn_Close);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(1, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 24);
            this.panel6.TabIndex = 13;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.BackgroundImage = global::AutoTester.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(181, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(18, 18);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_PrefabsClose_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_PrefabsClose_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "워크플로우 열 속성 편집";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // Option_InputString
            // 
            this.Option_InputString.AutoSize = true;
            this.Option_InputString.ForeColor = System.Drawing.Color.White;
            this.Option_InputString.Location = new System.Drawing.Point(12, 105);
            this.Option_InputString.Name = "Option_InputString";
            this.Option_InputString.Size = new System.Drawing.Size(83, 16);
            this.Option_InputString.TabIndex = 15;
            this.Option_InputString.Text = "InputString";
            this.Option_InputString.UseVisualStyleBackColor = true;
            this.Option_InputString.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // Option_Point
            // 
            this.Option_Point.AutoSize = true;
            this.Option_Point.ForeColor = System.Drawing.Color.White;
            this.Option_Point.Location = new System.Drawing.Point(12, 83);
            this.Option_Point.Name = "Option_Point";
            this.Option_Point.Size = new System.Drawing.Size(52, 16);
            this.Option_Point.TabIndex = 14;
            this.Option_Point.Text = "Point";
            this.Option_Point.UseVisualStyleBackColor = true;
            this.Option_Point.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // Option_Interval
            // 
            this.Option_Interval.AutoSize = true;
            this.Option_Interval.ForeColor = System.Drawing.Color.White;
            this.Option_Interval.Location = new System.Drawing.Point(12, 61);
            this.Option_Interval.Name = "Option_Interval";
            this.Option_Interval.Size = new System.Drawing.Size(64, 16);
            this.Option_Interval.TabIndex = 13;
            this.Option_Interval.Text = "Interval";
            this.Option_Interval.UseVisualStyleBackColor = true;
            this.Option_Interval.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // Option_Tag
            // 
            this.Option_Tag.AutoSize = true;
            this.Option_Tag.ForeColor = System.Drawing.Color.White;
            this.Option_Tag.Location = new System.Drawing.Point(12, 39);
            this.Option_Tag.Name = "Option_Tag";
            this.Option_Tag.Size = new System.Drawing.Size(46, 16);
            this.Option_Tag.TabIndex = 12;
            this.Option_Tag.Text = "Tag";
            this.Option_Tag.UseVisualStyleBackColor = true;
            this.Option_Tag.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // SetWorkflowColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(205, 160);
            this.ControlBox = false;
            this.Controls.Add(this.Option_InputString);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Option_Point);
            this.Controls.Add(this.button_취소);
            this.Controls.Add(this.Option_Interval);
            this.Controls.Add(this.Option_Tag);
            this.Controls.Add(this.button_확인);
            this.MaximumSize = new System.Drawing.Size(221, 176);
            this.MinimumSize = new System.Drawing.Size(221, 176);
            this.Name = "SetWorkflowColumn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_확인;
        private System.Windows.Forms.Button button_취소;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Option_InputString;
        private System.Windows.Forms.CheckBox Option_Point;
        private System.Windows.Forms.CheckBox Option_Interval;
        private System.Windows.Forms.CheckBox Option_Tag;
    }
}