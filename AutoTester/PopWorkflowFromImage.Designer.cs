namespace AutoTester
{
    partial class PopWorkflowFromImage
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
            this.components = new System.ComponentModel.Container();
            this.label_curPosition = new System.Windows.Forms.Label();
            this.button_AddImage = new System.Windows.Forms.Button();
            this.listView_Image = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_AddWorkFlow = new System.Windows.Forms.Button();
            this.button_RemoveAll = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Header_Type2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Event2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Tag2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_ImageArea = new System.Windows.Forms.PictureBox();
            this.label_ImageTitle = new System.Windows.Forms.Label();
            this.listView_WorkFlow = new DragableListView.DragableListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageArea)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_curPosition
            // 
            this.label_curPosition.AutoSize = true;
            this.label_curPosition.ForeColor = System.Drawing.Color.White;
            this.label_curPosition.Location = new System.Drawing.Point(9, 36);
            this.label_curPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_curPosition.Name = "label_curPosition";
            this.label_curPosition.Size = new System.Drawing.Size(59, 12);
            this.label_curPosition.TabIndex = 76;
            this.label_curPosition.Text = "(0/0, 0/0)";
            // 
            // button_AddImage
            // 
            this.button_AddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddImage.Location = new System.Drawing.Point(106, 520);
            this.button_AddImage.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddImage.Name = "button_AddImage";
            this.button_AddImage.Size = new System.Drawing.Size(88, 22);
            this.button_AddImage.TabIndex = 72;
            this.button_AddImage.Text = "이미지 추가";
            this.button_AddImage.UseVisualStyleBackColor = true;
            this.button_AddImage.Click += new System.EventHandler(this.button_AddImage_Click);
            // 
            // listView_Image
            // 
            this.listView_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Image.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView_Image.FullRowSelect = true;
            this.listView_Image.HideSelection = false;
            this.listView_Image.Location = new System.Drawing.Point(6, 348);
            this.listView_Image.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Image.MultiSelect = false;
            this.listView_Image.Name = "listView_Image";
            this.listView_Image.Size = new System.Drawing.Size(188, 168);
            this.listView_Image.TabIndex = 75;
            this.listView_Image.UseCompatibleStateImageBehavior = false;
            this.listView_Image.View = System.Windows.Forms.View.Details;
            this.listView_Image.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Image_ItemSelectionChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이미지 목록";
            this.columnHeader4.Width = 181;
            // 
            // button_AddWorkFlow
            // 
            this.button_AddWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddWorkFlow.Location = new System.Drawing.Point(332, 520);
            this.button_AddWorkFlow.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddWorkFlow.Name = "button_AddWorkFlow";
            this.button_AddWorkFlow.Size = new System.Drawing.Size(117, 22);
            this.button_AddWorkFlow.TabIndex = 78;
            this.button_AddWorkFlow.Text = "워크 플로우에 추가";
            this.button_AddWorkFlow.UseVisualStyleBackColor = true;
            this.button_AddWorkFlow.Click += new System.EventHandler(this.button_AddWorkFlow_Click);
            // 
            // button_RemoveAll
            // 
            this.button_RemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RemoveAll.Location = new System.Drawing.Point(200, 520);
            this.button_RemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveAll.Name = "button_RemoveAll";
            this.button_RemoveAll.Size = new System.Drawing.Size(71, 22);
            this.button_RemoveAll.TabIndex = 79;
            this.button_RemoveAll.Text = "전체 삭제";
            this.button_RemoveAll.UseVisualStyleBackColor = true;
            this.button_RemoveAll.Click += new System.EventHandler(this.button_RemoveAll_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Remove.Location = new System.Drawing.Point(275, 520);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(43, 22);
            this.button_Remove.TabIndex = 80;
            this.button_Remove.Text = "삭제";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Header_Type2
            // 
            this.Header_Type2.Text = "Type";
            this.Header_Type2.Width = 70;
            // 
            // Header_Event2
            // 
            this.Header_Event2.Text = "Event";
            this.Header_Event2.Width = 95;
            // 
            // Header_Tag2
            // 
            this.Header_Tag2.Text = "Tag";
            this.Header_Tag2.Width = 80;
            // 
            // pictureBox_ImageArea
            // 
            this.pictureBox_ImageArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ImageArea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox_ImageArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ImageArea.Location = new System.Drawing.Point(6, 55);
            this.pictureBox_ImageArea.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ImageArea.Name = "pictureBox_ImageArea";
            this.pictureBox_ImageArea.Size = new System.Drawing.Size(451, 289);
            this.pictureBox_ImageArea.TabIndex = 73;
            this.pictureBox_ImageArea.TabStop = false;
            this.pictureBox_ImageArea.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ImageArea_MouseDoubleClick);
            this.pictureBox_ImageArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ImageArea_MouseDown);
            this.pictureBox_ImageArea.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox_ImageArea.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox_ImageArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox_ImageArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ImageArea_MouseUp);
            // 
            // label_ImageTitle
            // 
            this.label_ImageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ImageTitle.ForeColor = System.Drawing.Color.White;
            this.label_ImageTitle.Location = new System.Drawing.Point(122, 26);
            this.label_ImageTitle.Name = "label_ImageTitle";
            this.label_ImageTitle.Size = new System.Drawing.Size(327, 23);
            this.label_ImageTitle.TabIndex = 82;
            this.label_ImageTitle.Text = "  ";
            this.label_ImageTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // listView_WorkFlow
            // 
            this.listView_WorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_WorkFlow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_WorkFlow.FullRowSelect = true;
            this.listView_WorkFlow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_WorkFlow.HideSelection = false;
            this.listView_WorkFlow.InsertionLineColor = System.Drawing.Color.Gray;
            this.listView_WorkFlow.LargeImageList = this.imageList;
            this.listView_WorkFlow.Location = new System.Drawing.Point(200, 348);
            this.listView_WorkFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_WorkFlow.Name = "listView_WorkFlow";
            this.listView_WorkFlow.Size = new System.Drawing.Size(257, 168);
            this.listView_WorkFlow.SmallImageList = this.imageList;
            this.listView_WorkFlow.TabIndex = 81;
            this.listView_WorkFlow.UseCompatibleStateImageBehavior = false;
            this.listView_WorkFlow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 24);
            this.panel1.TabIndex = 83;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::AutoTester.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(438, 3);
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
            this.label2.Size = new System.Drawing.Size(173, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이미지 좌표로 워크플로우 작성";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // WorkflowEditorTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(462, 558);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ImageTitle);
            this.Controls.Add(this.listView_WorkFlow);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_RemoveAll);
            this.Controls.Add(this.button_AddWorkFlow);
            this.Controls.Add(this.label_curPosition);
            this.Controls.Add(this.button_AddImage);
            this.Controls.Add(this.listView_Image);
            this.Controls.Add(this.pictureBox_ImageArea);
            this.Name = "WorkflowEditorTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkflowEditorTool_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_curPosition;
        private System.Windows.Forms.Button button_AddImage;
        private System.Windows.Forms.ListView listView_Image;
        private System.Windows.Forms.PictureBox pictureBox_ImageArea;
        private System.Windows.Forms.Button button_AddWorkFlow;
        private System.Windows.Forms.Button button_RemoveAll;
        private System.Windows.Forms.Button button_Remove;
        private DragableListView.DragableListView listView_WorkFlow;
        private System.Windows.Forms.ColumnHeader Header_Type2;
        private System.Windows.Forms.ColumnHeader Header_Event2;
        private System.Windows.Forms.ColumnHeader Header_Tag2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label_ImageTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label2;

    }
}