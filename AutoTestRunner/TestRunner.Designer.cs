namespace AutoTestRunner
{
    partial class TestRunner
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRunner));
            this.ProcessImageList = new System.Windows.Forms.ImageList(this.components);
            this.Button_찾아보기 = new System.Windows.Forms.Button();
            this.textBox_SnapPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_DontSaveSnap = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Time = new System.Windows.Forms.Label();
            this.Button_시작 = new System.Windows.Forms.Button();
            this.Button_추가 = new System.Windows.Forms.Button();
            this.Button_삭제 = new System.Windows.Forms.Button();
            this.listView_WorkFlow = new DragableListView.DragableListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_HotKey = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_LogFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_DontSaveLog = new System.Windows.Forms.CheckBox();
            this.comboBox_ImageFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_새로고침 = new System.Windows.Forms.Button();
            this.label_FocusWindow = new System.Windows.Forms.Label();
            this.listView_ProcessList = new System.Windows.Forms.ListView();
            this.checkBox_Focus = new System.Windows.Forms.CheckBox();
            this.checkBox_Minimize = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessImageList
            // 
            this.ProcessImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ProcessImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ProcessImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Button_찾아보기
            // 
            this.Button_찾아보기.Location = new System.Drawing.Point(183, 137);
            this.Button_찾아보기.Margin = new System.Windows.Forms.Padding(2);
            this.Button_찾아보기.Name = "Button_찾아보기";
            this.Button_찾아보기.Size = new System.Drawing.Size(65, 26);
            this.Button_찾아보기.TabIndex = 9;
            this.Button_찾아보기.Text = "찾아보기";
            this.Button_찾아보기.UseVisualStyleBackColor = true;
            this.Button_찾아보기.Click += new System.EventHandler(this.Button_찾아보기_Click);
            // 
            // textBox_SnapPath
            // 
            this.textBox_SnapPath.Location = new System.Drawing.Point(53, 138);
            this.textBox_SnapPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SnapPath.Name = "textBox_SnapPath";
            this.textBox_SnapPath.Size = new System.Drawing.Size(126, 21);
            this.textBox_SnapPath.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "경로 : ";
            // 
            // checkBox_DontSaveSnap
            // 
            this.checkBox_DontSaveSnap.AutoSize = true;
            this.checkBox_DontSaveSnap.Location = new System.Drawing.Point(16, 23);
            this.checkBox_DontSaveSnap.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_DontSaveSnap.Name = "checkBox_DontSaveSnap";
            this.checkBox_DontSaveSnap.Size = new System.Drawing.Size(128, 16);
            this.checkBox_DontSaveSnap.TabIndex = 10;
            this.checkBox_DontSaveSnap.Text = "스크린샷 저장 안함";
            this.checkBox_DontSaveSnap.UseVisualStyleBackColor = true;
            this.checkBox_DontSaveSnap.CheckedChanged += new System.EventHandler(this.checkBox_DontSaveSnap_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 334);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label_Time);
            this.tabPage1.Controls.Add(this.Button_시작);
            this.tabPage1.Controls.Add(this.Button_추가);
            this.tabPage1.Controls.Add(this.Button_삭제);
            this.tabPage1.Controls.Add(this.listView_WorkFlow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(272, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "테스트 목록";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(8, 243);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(83, 12);
            this.label_Time.TabIndex = 4;
            this.label_Time.Text = "실행시간 : 0초";
            // 
            // Button_시작
            // 
            this.Button_시작.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_시작.Location = new System.Drawing.Point(5, 262);
            this.Button_시작.Margin = new System.Windows.Forms.Padding(2);
            this.Button_시작.Name = "Button_시작";
            this.Button_시작.Size = new System.Drawing.Size(260, 41);
            this.Button_시작.TabIndex = 3;
            this.Button_시작.Text = "테스트 시작";
            this.Button_시작.UseVisualStyleBackColor = true;
            this.Button_시작.Click += new System.EventHandler(this.Button_시작_Click);
            // 
            // Button_추가
            // 
            this.Button_추가.Location = new System.Drawing.Point(161, 239);
            this.Button_추가.Margin = new System.Windows.Forms.Padding(2);
            this.Button_추가.Name = "Button_추가";
            this.Button_추가.Size = new System.Drawing.Size(50, 20);
            this.Button_추가.TabIndex = 2;
            this.Button_추가.Text = "추가";
            this.Button_추가.UseVisualStyleBackColor = true;
            this.Button_추가.Click += new System.EventHandler(this.Button_추가_Click);
            // 
            // Button_삭제
            // 
            this.Button_삭제.Location = new System.Drawing.Point(215, 239);
            this.Button_삭제.Margin = new System.Windows.Forms.Padding(2);
            this.Button_삭제.Name = "Button_삭제";
            this.Button_삭제.Size = new System.Drawing.Size(50, 20);
            this.Button_삭제.TabIndex = 1;
            this.Button_삭제.Text = "삭제";
            this.Button_삭제.UseVisualStyleBackColor = true;
            this.Button_삭제.Click += new System.EventHandler(this.Button_삭제_Click);
            // 
            // listView_WorkFlow
            // 
            this.listView_WorkFlow.AllowDrop = true;
            this.listView_WorkFlow.AllowItemDrag = true;
            this.listView_WorkFlow.Before = 0;
            this.listView_WorkFlow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_WorkFlow.FullRowSelect = true;
            this.listView_WorkFlow.HideSelection = false;
            this.listView_WorkFlow.Location = new System.Drawing.Point(5, 5);
            this.listView_WorkFlow.Margin = new System.Windows.Forms.Padding(2);
            this.listView_WorkFlow.Name = "listView_WorkFlow";
            this.listView_WorkFlow.Size = new System.Drawing.Size(263, 230);
            this.listView_WorkFlow.TabIndex = 0;
            this.listView_WorkFlow.UseCompatibleStateImageBehavior = false;
            this.listView_WorkFlow.View = System.Windows.Forms.View.Details;
            this.listView_WorkFlow.ItemDragDrop += new System.EventHandler<DragableListView.ListViewItemDragEventArgs>(this.listView_WorkFlow_ItemDragDrop);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WorkFlow";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Interval";
            this.columnHeader2.Width = 76;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(272, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "테스트 옵션1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_HotKey);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(5, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(258, 63);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "테스트 제어";
            // 
            // comboBox_HotKey
            // 
            this.comboBox_HotKey.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_HotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HotKey.FormattingEnabled = true;
            this.comboBox_HotKey.Items.AddRange(new object[] {
            "Alt + F12",
            "Alt + F11",
            "Alt + F10",
            "Alt + F9"});
            this.comboBox_HotKey.Location = new System.Drawing.Point(138, 30);
            this.comboBox_HotKey.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_HotKey.Name = "comboBox_HotKey";
            this.comboBox_HotKey.Size = new System.Drawing.Size(108, 20);
            this.comboBox_HotKey.TabIndex = 16;
            this.comboBox_HotKey.SelectedIndexChanged += new System.EventHandler(this.comboBox_HotKey_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "테스트 정지 단축키 : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(5, 175);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(258, 63);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "반복 실행";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "반복 횟수 : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(86, 31);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_LogFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox_DontSaveLog);
            this.groupBox1.Controls.Add(this.comboBox_ImageFormat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SnapPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_DontSaveSnap);
            this.groupBox1.Controls.Add(this.Button_찾아보기);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(260, 166);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "스크린샷&&로그";
            // 
            // comboBox_LogFormat
            // 
            this.comboBox_LogFormat.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_LogFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LogFormat.FormattingEnabled = true;
            this.comboBox_LogFormat.Items.AddRange(new object[] {
            "csv",
            "txt"});
            this.comboBox_LogFormat.Location = new System.Drawing.Point(79, 104);
            this.comboBox_LogFormat.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_LogFormat.Name = "comboBox_LogFormat";
            this.comboBox_LogFormat.Size = new System.Drawing.Size(167, 20);
            this.comboBox_LogFormat.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "저장 포멧 :  ";
            // 
            // checkBox_DontSaveLog
            // 
            this.checkBox_DontSaveLog.AutoSize = true;
            this.checkBox_DontSaveLog.Location = new System.Drawing.Point(16, 81);
            this.checkBox_DontSaveLog.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_DontSaveLog.Name = "checkBox_DontSaveLog";
            this.checkBox_DontSaveLog.Size = new System.Drawing.Size(104, 16);
            this.checkBox_DontSaveLog.TabIndex = 16;
            this.checkBox_DontSaveLog.Text = "로그 기록 안함";
            this.checkBox_DontSaveLog.UseVisualStyleBackColor = true;
            this.checkBox_DontSaveLog.CheckedChanged += new System.EventHandler(this.checkBox_DontSaveLog_CheckedChanged);
            // 
            // comboBox_ImageFormat
            // 
            this.comboBox_ImageFormat.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_ImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ImageFormat.FormattingEnabled = true;
            this.comboBox_ImageFormat.Items.AddRange(new object[] {
            "jpg",
            "bmp",
            "png"});
            this.comboBox_ImageFormat.Location = new System.Drawing.Point(79, 42);
            this.comboBox_ImageFormat.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ImageFormat.Name = "comboBox_ImageFormat";
            this.comboBox_ImageFormat.Size = new System.Drawing.Size(167, 20);
            this.comboBox_ImageFormat.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "저장 포멧 :  ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(272, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "테스트 옵션2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_새로고침);
            this.groupBox2.Controls.Add(this.label_FocusWindow);
            this.groupBox2.Controls.Add(this.listView_ProcessList);
            this.groupBox2.Controls.Add(this.checkBox_Focus);
            this.groupBox2.Controls.Add(this.checkBox_Minimize);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(262, 300);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "시작 포커스";
            // 
            // Button_새로고침
            // 
            this.Button_새로고침.Location = new System.Drawing.Point(162, 272);
            this.Button_새로고침.Margin = new System.Windows.Forms.Padding(2);
            this.Button_새로고침.Name = "Button_새로고침";
            this.Button_새로고침.Size = new System.Drawing.Size(89, 23);
            this.Button_새로고침.TabIndex = 3;
            this.Button_새로고침.Text = "목록 새로고침";
            this.Button_새로고침.UseVisualStyleBackColor = true;
            this.Button_새로고침.Click += new System.EventHandler(this.Button_새로고침_Click);
            // 
            // label_FocusWindow
            // 
            this.label_FocusWindow.AutoSize = true;
            this.label_FocusWindow.Location = new System.Drawing.Point(17, 278);
            this.label_FocusWindow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FocusWindow.Name = "label_FocusWindow";
            this.label_FocusWindow.Size = new System.Drawing.Size(42, 12);
            this.label_FocusWindow.TabIndex = 13;
            this.label_FocusWindow.Text = "PID : -";
            // 
            // listView_ProcessList
            // 
            this.listView_ProcessList.HideSelection = false;
            this.listView_ProcessList.LargeImageList = this.ProcessImageList;
            this.listView_ProcessList.Location = new System.Drawing.Point(19, 59);
            this.listView_ProcessList.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ProcessList.MultiSelect = false;
            this.listView_ProcessList.Name = "listView_ProcessList";
            this.listView_ProcessList.Size = new System.Drawing.Size(232, 209);
            this.listView_ProcessList.SmallImageList = this.ProcessImageList;
            this.listView_ProcessList.TabIndex = 1;
            this.listView_ProcessList.UseCompatibleStateImageBehavior = false;
            this.listView_ProcessList.View = System.Windows.Forms.View.Tile;
            this.listView_ProcessList.SelectedIndexChanged += new System.EventHandler(this.listView_ProcessList_SelectedIndexChanged);
            // 
            // checkBox_Focus
            // 
            this.checkBox_Focus.AutoSize = true;
            this.checkBox_Focus.Location = new System.Drawing.Point(19, 39);
            this.checkBox_Focus.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Focus.Name = "checkBox_Focus";
            this.checkBox_Focus.Size = new System.Drawing.Size(236, 16);
            this.checkBox_Focus.TabIndex = 6;
            this.checkBox_Focus.Text = "시작 시 특정 프로세스에 포커스 맞추기";
            this.checkBox_Focus.UseVisualStyleBackColor = true;
            this.checkBox_Focus.CheckedChanged += new System.EventHandler(this.checkBox_Focus_CheckedChanged);
            // 
            // checkBox_Minimize
            // 
            this.checkBox_Minimize.AutoSize = true;
            this.checkBox_Minimize.Location = new System.Drawing.Point(19, 19);
            this.checkBox_Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Minimize.Name = "checkBox_Minimize";
            this.checkBox_Minimize.Size = new System.Drawing.Size(156, 16);
            this.checkBox_Minimize.TabIndex = 5;
            this.checkBox_Minimize.Text = "시작 시 프로그램 최소화";
            this.checkBox_Minimize.UseVisualStyleBackColor = true;
            // 
            // TestRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(280, 334);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TestRunner";
            this.Text = "Picidae Tester";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ProcessImageList;
        private System.Windows.Forms.Button Button_찾아보기;
        private System.Windows.Forms.TextBox textBox_SnapPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_DontSaveSnap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_ImageFormat;
        private System.Windows.Forms.Label label3;
        private DragableListView.DragableListView listView_WorkFlow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Button_추가;
        private System.Windows.Forms.Button Button_삭제;
        private System.Windows.Forms.Button Button_시작;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_새로고침;
        private System.Windows.Forms.Label label_FocusWindow;
        private System.Windows.Forms.ListView listView_ProcessList;
        private System.Windows.Forms.CheckBox checkBox_Focus;
        private System.Windows.Forms.CheckBox checkBox_Minimize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_HotKey;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.ComboBox comboBox_LogFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_DontSaveLog;
    }
}

