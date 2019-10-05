namespace AutoTester
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지로프리팹추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지좌표로워크플로우작성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_워크플로우설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.이벤트집합목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_PrefabsDelete = new System.Windows.Forms.PictureBox();
            this.btn_PrefabsAdd = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_NodeDelete = new System.Windows.Forms.PictureBox();
            this.btn_NodeAdd = new System.Windows.Forms.PictureBox();
            this.label_WorkflowName = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button_NodeToPrefab = new System.Windows.Forms.PictureBox();
            this.button_PrefabToNode = new System.Windows.Forms.PictureBox();
            this.listView_Main = new DragableListView.DragableListView();
            this.IndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Type2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Event2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Tag2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Interval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_InputString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Prefabs = new DragableListView.DragableListView();
            this.Header_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsAdd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NodeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NodeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_NodeToPrefab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_PrefabToNode)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.테스트ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(790, 30);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "X";
            this.menuStrip.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_QuickMenu_Paint);
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem2,
            this.다른이름으로저장ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.새로만들기ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuClick_새로만들기);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.열기ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuClick_열기);
            // 
            // 저장ToolStripMenuItem2
            // 
            this.저장ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.저장ToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.저장ToolStripMenuItem2.Name = "저장ToolStripMenuItem2";
            this.저장ToolStripMenuItem2.ShortcutKeyDisplayString = "";
            this.저장ToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.저장ToolStripMenuItem2.Text = "저장(&S)";
            this.저장ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuClick_저장);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.다른이름으로저장ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuClick_다른이름으로저장);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.저장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem1,
            this.불러오기ToolStripMenuItem});
            this.저장ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.저장ToolStripMenuItem.Text = "이벤트 집합(&E)";
            // 
            // 저장ToolStripMenuItem1
            // 
            this.저장ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.저장ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.저장ToolStripMenuItem1.Name = "저장ToolStripMenuItem1";
            this.저장ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.저장ToolStripMenuItem1.Text = "내보내기";
            this.저장ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuClick_내보내기);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.불러오기ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuClick_불러오기);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.끝내기ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.끝내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuClick_끝내기);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기XToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기VToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.전체선택AToolStripMenuItem});
            this.편집EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 잘라내기XToolStripMenuItem
            // 
            this.잘라내기XToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.잘라내기XToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.잘라내기XToolStripMenuItem.Name = "잘라내기XToolStripMenuItem";
            this.잘라내기XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잘라내기XToolStripMenuItem.Text = "잘라내기(&T)";
            this.잘라내기XToolStripMenuItem.Click += new System.EventHandler(this.Hotkey_잘라내기);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.복사ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복사ToolStripMenuItem.Text = "복사(&C)";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.Hotkey_복사);
            // 
            // 붙여넣기VToolStripMenuItem
            // 
            this.붙여넣기VToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.붙여넣기VToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.붙여넣기VToolStripMenuItem.Name = "붙여넣기VToolStripMenuItem";
            this.붙여넣기VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.붙여넣기VToolStripMenuItem.Text = "붙여넣기(&P)";
            this.붙여넣기VToolStripMenuItem.Click += new System.EventHandler(this.Hotkey_붙여넣기);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.삭제ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.삭제ToolStripMenuItem.Text = "삭제(&D)";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.Hotkey_삭제);
            // 
            // 전체선택AToolStripMenuItem
            // 
            this.전체선택AToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.전체선택AToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.전체선택AToolStripMenuItem.Name = "전체선택AToolStripMenuItem";
            this.전체선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.전체선택AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.전체선택AToolStripMenuItem.Text = "전체선택(&A)";
            this.전체선택AToolStripMenuItem.Click += new System.EventHandler(this.Hotkey_전체선택);
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지로프리팹추가ToolStripMenuItem,
            this.이미지좌표로워크플로우작성ToolStripMenuItem,
            this.ToolStripMenuItem_워크플로우설정,
            this.이벤트집합목록ToolStripMenuItem});
            this.도구ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.도구ToolStripMenuItem.Text = "도구(&T)";
            // 
            // 이미지로프리팹추가ToolStripMenuItem
            // 
            this.이미지로프리팹추가ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.이미지로프리팹추가ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.이미지로프리팹추가ToolStripMenuItem.Name = "이미지로프리팹추가ToolStripMenuItem";
            this.이미지로프리팹추가ToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.이미지로프리팹추가ToolStripMenuItem.Text = "이미지 좌표로 이벤트 추가(&I)";
            this.이미지로프리팹추가ToolStripMenuItem.Click += new System.EventHandler(this.CallPopup_이미지로이벤트추가);
            // 
            // 이미지좌표로워크플로우작성ToolStripMenuItem
            // 
            this.이미지좌표로워크플로우작성ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.이미지좌표로워크플로우작성ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.이미지좌표로워크플로우작성ToolStripMenuItem.Name = "이미지좌표로워크플로우작성ToolStripMenuItem";
            this.이미지좌표로워크플로우작성ToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.이미지좌표로워크플로우작성ToolStripMenuItem.Text = "이미지 좌표로 워크 플로우 작성(&W)";
            this.이미지좌표로워크플로우작성ToolStripMenuItem.Click += new System.EventHandler(this.CallPopup_이미지로워크플로우추가);
            // 
            // ToolStripMenuItem_워크플로우설정
            // 
            this.ToolStripMenuItem_워크플로우설정.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStripMenuItem_워크플로우설정.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_워크플로우설정.Name = "ToolStripMenuItem_워크플로우설정";
            this.ToolStripMenuItem_워크플로우설정.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItem_워크플로우설정.Text = "워크플로우 열 설정 도구";
            this.ToolStripMenuItem_워크플로우설정.Click += new System.EventHandler(this.CallPopup_워크플로우열설정);
            // 
            // 이벤트집합목록ToolStripMenuItem
            // 
            this.이벤트집합목록ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.이벤트집합목록ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.이벤트집합목록ToolStripMenuItem.Name = "이벤트집합목록ToolStripMenuItem";
            this.이벤트집합목록ToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.이벤트집합목록ToolStripMenuItem.Text = "이벤트집합 목록";
            this.이벤트집합목록ToolStripMenuItem.Click += new System.EventHandler(this.CallPopup_이벤트집합목록);
            // 
            // 테스트ToolStripMenuItem
            // 
            this.테스트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.시작ToolStripMenuItem1});
            this.테스트ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.테스트ToolStripMenuItem.Name = "테스트ToolStripMenuItem";
            this.테스트ToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.테스트ToolStripMenuItem.Text = "테스트(&S)";
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.시작ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.시작ToolStripMenuItem.Text = "클릭 없이 시작";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // 시작ToolStripMenuItem1
            // 
            this.시작ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.시작ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.시작ToolStripMenuItem1.Name = "시작ToolStripMenuItem1";
            this.시작ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.시작ToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.시작ToolStripMenuItem1.Text = "시작";
            this.시작ToolStripMenuItem1.Click += new System.EventHandler(this.시작ToolStripMenuItem1_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.CallPopup_도움말);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_PrefabsDelete);
            this.panel6.Controls.Add(this.btn_PrefabsAdd);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(8, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 27);
            this.panel6.TabIndex = 4;
            // 
            // btn_PrefabsDelete
            // 
            this.btn_PrefabsDelete.BackgroundImage = global::AutoTester.Properties.Resources.Button_Minus;
            this.btn_PrefabsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrefabsDelete.Location = new System.Drawing.Point(310, 3);
            this.btn_PrefabsDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PrefabsDelete.Name = "btn_PrefabsDelete";
            this.btn_PrefabsDelete.Size = new System.Drawing.Size(18, 18);
            this.btn_PrefabsDelete.TabIndex = 11;
            this.btn_PrefabsDelete.TabStop = false;
            this.btn_PrefabsDelete.Click += new System.EventHandler(this.btn_PrefabsDelete_Click);
            this.btn_PrefabsDelete.MouseEnter += new System.EventHandler(this.btn_Minus_MouseEnter);
            this.btn_PrefabsDelete.MouseLeave += new System.EventHandler(this.btn_Minus_MouseLeave);
            // 
            // btn_PrefabsAdd
            // 
            this.btn_PrefabsAdd.BackgroundImage = global::AutoTester.Properties.Resources.Button_Plus;
            this.btn_PrefabsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrefabsAdd.Location = new System.Drawing.Point(287, 3);
            this.btn_PrefabsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PrefabsAdd.Name = "btn_PrefabsAdd";
            this.btn_PrefabsAdd.Size = new System.Drawing.Size(18, 18);
            this.btn_PrefabsAdd.TabIndex = 10;
            this.btn_PrefabsAdd.TabStop = false;
            this.btn_PrefabsAdd.Click += new System.EventHandler(this.btn_PrefabsAdd_Click);
            this.btn_PrefabsAdd.MouseEnter += new System.EventHandler(this.btn_Plus_MouseEnter);
            this.btn_PrefabsAdd.MouseLeave += new System.EventHandler(this.btn_Plus_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "이벤트집합";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_NodeDelete);
            this.panel2.Controls.Add(this.btn_NodeAdd);
            this.panel2.Controls.Add(this.label_WorkflowName);
            this.panel2.Location = new System.Drawing.Point(373, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 27);
            this.panel2.TabIndex = 12;
            // 
            // btn_NodeDelete
            // 
            this.btn_NodeDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_NodeDelete.BackgroundImage = global::AutoTester.Properties.Resources.Button_Minus;
            this.btn_NodeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_NodeDelete.Location = new System.Drawing.Point(385, 3);
            this.btn_NodeDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NodeDelete.Name = "btn_NodeDelete";
            this.btn_NodeDelete.Size = new System.Drawing.Size(18, 18);
            this.btn_NodeDelete.TabIndex = 11;
            this.btn_NodeDelete.TabStop = false;
            this.btn_NodeDelete.Click += new System.EventHandler(this.btn_NodeDelete_Click);
            this.btn_NodeDelete.MouseEnter += new System.EventHandler(this.btn_Minus_MouseEnter);
            this.btn_NodeDelete.MouseLeave += new System.EventHandler(this.btn_Minus_MouseLeave);
            // 
            // btn_NodeAdd
            // 
            this.btn_NodeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_NodeAdd.BackgroundImage = global::AutoTester.Properties.Resources.Button_Plus;
            this.btn_NodeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_NodeAdd.Location = new System.Drawing.Point(362, 3);
            this.btn_NodeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NodeAdd.Name = "btn_NodeAdd";
            this.btn_NodeAdd.Size = new System.Drawing.Size(18, 18);
            this.btn_NodeAdd.TabIndex = 10;
            this.btn_NodeAdd.TabStop = false;
            this.btn_NodeAdd.Click += new System.EventHandler(this.btn_NodeAdd_Click);
            this.btn_NodeAdd.MouseEnter += new System.EventHandler(this.btn_Plus_MouseEnter);
            this.btn_NodeAdd.MouseLeave += new System.EventHandler(this.btn_Plus_MouseLeave);
            // 
            // label_WorkflowName
            // 
            this.label_WorkflowName.AutoSize = true;
            this.label_WorkflowName.ForeColor = System.Drawing.Color.White;
            this.label_WorkflowName.Location = new System.Drawing.Point(4, 7);
            this.label_WorkflowName.Name = "label_WorkflowName";
            this.label_WorkflowName.Size = new System.Drawing.Size(67, 15);
            this.label_WorkflowName.TabIndex = 8;
            this.label_WorkflowName.Text = "워크플로우";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button_NodeToPrefab
            // 
            this.button_NodeToPrefab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_NodeToPrefab.BackgroundImage = global::AutoTester.Properties.Resources.Button_LeftArrow;
            this.button_NodeToPrefab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_NodeToPrefab.Location = new System.Drawing.Point(346, 210);
            this.button_NodeToPrefab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_NodeToPrefab.Name = "button_NodeToPrefab";
            this.button_NodeToPrefab.Size = new System.Drawing.Size(21, 70);
            this.button_NodeToPrefab.TabIndex = 16;
            this.button_NodeToPrefab.TabStop = false;
            this.button_NodeToPrefab.Text = "◀";
            this.button_NodeToPrefab.Click += new System.EventHandler(this.button_NodeToPrefab_Click);
            this.button_NodeToPrefab.MouseEnter += new System.EventHandler(this.btn_LeftArrow_MouseEnter);
            this.button_NodeToPrefab.MouseLeave += new System.EventHandler(this.btn_LeftArrow_MouseLeave);
            // 
            // button_PrefabToNode
            // 
            this.button_PrefabToNode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_PrefabToNode.BackgroundImage = global::AutoTester.Properties.Resources.Button_RightArrow;
            this.button_PrefabToNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_PrefabToNode.Location = new System.Drawing.Point(346, 111);
            this.button_PrefabToNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_PrefabToNode.Name = "button_PrefabToNode";
            this.button_PrefabToNode.Size = new System.Drawing.Size(21, 70);
            this.button_PrefabToNode.TabIndex = 15;
            this.button_PrefabToNode.TabStop = false;
            this.button_PrefabToNode.Click += new System.EventHandler(this.button_PrefabToNode_Click);
            this.button_PrefabToNode.MouseEnter += new System.EventHandler(this.btn_RightArrow_MouseEnter);
            this.button_PrefabToNode.MouseLeave += new System.EventHandler(this.btn_RightArrow_MouseLeave);
            // 
            // listView_Main
            // 
            this.listView_Main.AllowDrop = true;
            this.listView_Main.AllowItemDrag = true;
            this.listView_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Main.Before = 0;
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexHeader,
            this.Header_Type2,
            this.Header_Event2,
            this.Header_Tag2,
            this.Header_Point,
            this.Header_Interval,
            this.Header_InputString});
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Main.HideSelection = false;
            this.listView_Main.InsertionLineColor = System.Drawing.Color.Gray;
            this.listView_Main.Location = new System.Drawing.Point(373, 59);
            this.listView_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(408, 590);
            this.listView_Main.SmallImageList = this.imageList;
            this.listView_Main.TabIndex = 13;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.ItemDragDrop += new System.EventHandler<DragableListView.ListViewItemDragEventArgs>(this.listView_Main_ItemDragDrop);
            this.listView_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Main_MouseClick);
            this.listView_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Main_MouseDoubleClick);
            // 
            // IndexHeader
            // 
            this.IndexHeader.Text = "No.";
            this.IndexHeader.Width = 35;
            // 
            // Header_Type2
            // 
            this.Header_Type2.Text = "Type";
            this.Header_Type2.Width = 70;
            // 
            // Header_Event2
            // 
            this.Header_Event2.Text = "Event";
            this.Header_Event2.Width = 90;
            // 
            // Header_Tag2
            // 
            this.Header_Tag2.Text = "Tag";
            // 
            // Header_Point
            // 
            this.Header_Point.Text = "Point";
            // 
            // Header_Interval
            // 
            this.Header_Interval.Text = "Interval";
            // 
            // Header_InputString
            // 
            this.Header_InputString.Text = "InputString";
            // 
            // listView_Prefabs
            // 
            this.listView_Prefabs.AllowDrop = true;
            this.listView_Prefabs.AllowItemDrag = true;
            this.listView_Prefabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Prefabs.Before = 0;
            this.listView_Prefabs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header_Type,
            this.Header_Event,
            this.Header_Tag});
            this.listView_Prefabs.FullRowSelect = true;
            this.listView_Prefabs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Prefabs.HideSelection = false;
            this.listView_Prefabs.InsertionLineColor = System.Drawing.Color.Gray;
            this.listView_Prefabs.Location = new System.Drawing.Point(8, 59);
            this.listView_Prefabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Prefabs.Name = "listView_Prefabs";
            this.listView_Prefabs.Size = new System.Drawing.Size(333, 590);
            this.listView_Prefabs.SmallImageList = this.imageList;
            this.listView_Prefabs.TabIndex = 0;
            this.listView_Prefabs.UseCompatibleStateImageBehavior = false;
            this.listView_Prefabs.View = System.Windows.Forms.View.Details;
            this.listView_Prefabs.ItemDragDrop += new System.EventHandler<DragableListView.ListViewItemDragEventArgs>(this.listView_Prefabs_ItemDragDrop);
            this.listView_Prefabs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Prefabs_MouseDoubleClick);
            // 
            // Header_Type
            // 
            this.Header_Type.Text = "Type";
            this.Header_Type.Width = 70;
            // 
            // Header_Event
            // 
            this.Header_Event.Text = "Event";
            this.Header_Event.Width = 90;
            // 
            // Header_Tag
            // 
            this.Header_Tag.Text = "Tag";
            this.Header_Tag.Width = 220;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(790, 660);
            this.Controls.Add(this.button_NodeToPrefab);
            this.Controls.Add(this.button_PrefabToNode);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.listView_Prefabs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(806, 1403);
            this.MinimumSize = new System.Drawing.Size(806, 600);
            this.Name = "MainForm";
            this.Text = "Title";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrefabsAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NodeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NodeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_NodeToPrefab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_PrefabToNode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 테스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btn_PrefabsDelete;
        private System.Windows.Forms.PictureBox btn_PrefabsAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btn_NodeAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_NodeDelete;
        private System.Windows.Forms.Label label_WorkflowName;
        private System.Windows.Forms.ColumnHeader Header_Type;
        private System.Windows.Forms.ColumnHeader Header_Tag;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지로프리팹추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem2;
        private System.Windows.Forms.ColumnHeader Header_Type2;
        private System.Windows.Forms.ColumnHeader Header_Event2;
        private System.Windows.Forms.PictureBox button_PrefabToNode;
        private System.Windows.Forms.PictureBox button_NodeToPrefab;
        private DragableListView.DragableListView listView_Prefabs;
        private DragableListView.DragableListView listView_Main;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader Header_Event;
        private System.Windows.Forms.ColumnHeader Header_Tag2;
        private System.Windows.Forms.ToolStripMenuItem 이미지좌표로워크플로우작성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기XToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader IndexHeader;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Header_Point;
        private System.Windows.Forms.ColumnHeader Header_Interval;
        private System.Windows.Forms.ColumnHeader Header_InputString;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_워크플로우설정;
        private System.Windows.Forms.ToolStripMenuItem 이벤트집합목록ToolStripMenuItem;
    }
}

