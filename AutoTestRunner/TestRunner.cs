using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using AutoTestStructure;
using System.Security.Permissions;
using System.Diagnostics;
using System.Windows.Automation;

namespace AutoTestRunner
{
    public partial class TestRunner : Form
    {
        #region Field Members

        private List<List<MacroNode>> NodesList = new List<List<MacroNode>>();
        private List<string> FilenameList = new List<string>();
        private const string programKeyword = "Picidae";
        private int lastHotKey = 0;
        private int PID = 0;
        private int runningTime = 0;
        public int AddRunningTime
        {
            get
            {
                return runningTime;
            }
            set
            {
                runningTime += value;
                int calValue = runningTime / 1000 * (int)numericUpDown1.Value;
                int h = (int)calValue / 3600;
                int m = (int)calValue % 3600 / 60;
                int s = calValue % 3600 % 60;
                if (h > 0)
                    label_Time.Text = string.Format("실행시간 : {0}시간 {1}분 {2}초",h,m,s);
                else if (m > 0)
                    label_Time.Text = string.Format("실행시간 : {0}분 {1}초", m, s);
                else
                    label_Time.Text = string.Format("실행시간 : {0}초", s);
            }
        }

        #endregion
        
        #region Public Constructor

        public TestRunner()
        {
            InitializeComponent();
            comboBox_ImageFormat.SelectedIndex = 2;
            comboBox_LogFormat.SelectedIndex = 0;
            comboBox_HotKey.SelectedIndex = 0;
            getProcessList();
            SaveScreen = !this.checkBox_DontSaveSnap.Checked;
            FocusProcess = this.checkBox_Focus.Checked;
          }

        #endregion

        #region Public Boolean Members

        private bool saveScreen = true;
        public bool SaveScreen
        {
            set
            {
                saveScreen = value;
                comboBox_ImageFormat.Enabled = saveScreen;
                textBox_SnapPath.Enabled = saveLog | saveScreen;
                Button_찾아보기.Enabled = saveLog | saveScreen;
            }
            get { return saveScreen; }
        }

        private bool saveLog = true;
        public bool SaveLog
        {
            set
            {
                saveLog = value;
                comboBox_LogFormat.Enabled = saveLog;
                Button_찾아보기.Enabled = saveLog | saveScreen;
                textBox_SnapPath.Enabled = saveLog | saveScreen;             
            }
            get { return saveLog; }
        }

        private bool focusProcess;
        public bool FocusProcess
        {
            set
            {
                focusProcess = value;
                listView_ProcessList.Enabled = focusProcess;
                Button_새로고침.Enabled = focusProcess;
            }
            get
            {
                return focusProcess;
            }
        }

        public bool threadRunning = true;

        #endregion

        #region Private Methods

        /// <summary>
        /// 전체 프로세스 목록을 불러와서 메인 윈도우의 타이틀이 있을 때만 리스트에 저장
        /// </summary>
        private void getProcessList()
        {      
            var query = "SELECT ProcessId, Name, ExecutablePath FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(query))
            using (var results = searcher.Get())
            {                
                var processes = results.Cast<ManagementObject>().Select(x => new
                {
                    ProcessId = (UInt32)x["ProcessId"],
                    Name = (string)x["Name"],
                    ExecutablePath = (string)x["ExecutablePath"]
                });
                listView_ProcessList.Items.Clear();
                foreach (var p in processes)                
                {
                    if(Process.GetProcessById((int)p.ProcessId).MainWindowTitle.Equals(""))
                        continue;

                    if (System.IO.File.Exists(p.ExecutablePath))
                    {
                        var icon = Icon.ExtractAssociatedIcon(p.ExecutablePath);
                        var key = p.ProcessId.ToString();
                        this.ProcessImageList.Images.Add(key, icon.ToBitmap());
                        ListViewItem lim = new ListViewItem(p.Name, key);
                        lim.SubItems.Add(p.ProcessId.ToString());
                        this.listView_ProcessList.Items.Add(lim);
                    }
                }
            }
        }

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const int SW_SHOWNORMAL = 0x0003;
        const UInt32 SWP_SHOWWINDOW = 0x0040;

        private void FocusWindow(int PID)
        {
            Process proc = Process.GetProcessById(PID);
            IntPtr targetHd = proc.MainWindowHandle;
            ShowWindowAsync(targetHd, SW_SHOWNORMAL);
            SetForegroundWindow(targetHd);


            Console.WriteLine(proc.ProcessName);
        }

        private int SumInterval(List<MacroNode> macronodes)
        {
            int result = 0;
            foreach (MacroNode node in macronodes)
            {
                result += node.interval;
            }
            return result;
        }

        #endregion
                
        #region Hotkey For Abort

        [DllImport("User32.dll")]
        private static extern int RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("User32.dll")]
        private static extern int UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// 강제 종료를 위한 HOTKEY 등록
        /// </summary>
        /// <param name="KeyState">등록과 해제</param>
        public void Hotkeysetting(bool KeyState, int caseOf)
        {
            if (KeyState)
            {
                switch (caseOf)
                {
                    case 0:
                        RegisterHotKey(this.Handle, 0, 0x1, (int)Keys.F12);                        
                        break;
                    case 1:
                        RegisterHotKey(this.Handle, 0, 0x1, (int)Keys.F11);
                        break;
                    case 2:
                        RegisterHotKey(this.Handle, 0, 0x1, (int)Keys.F10);
                        break;
                    case 3:
                        RegisterHotKey(this.Handle, 0, 0x1, (int)Keys.F19);
                        break;
                }
            }
            else
            {
                UnregisterHotKey(this.Handle, 0);
            }                
        }

        /// <summary>
        /// 윈도우 전역 HotKey에 대한 오버로드
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {            
            if (m.Msg == 0x312) //핫키가 눌러지면
            {
                Console.WriteLine("Stop Message");
                this.threadRunning = false;
            }
            base.WndProc(ref m);
        }        

        #endregion

        #region Test Threading
        
        /// <summary>
        /// 테스트 스레드의 시작점
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_시작_Click(object sender, EventArgs e)
        {            
            tabControl1.Enabled = false;
            Thread th = new Thread(new ThreadStart(RunThread));
            th.Start();
        }
        
        /// <summary>
        /// 테스트 반복과 핫키 리스닝을 위한 중간 스레드 입니다.
        /// </summary>
        public void RunThread()
        {            
            int count = (int)numericUpDown1.Value;
            if (checkBox_Minimize.Checked)
                this.WindowState = FormWindowState.Minimized;
            if (focusProcess)
            {
                Console.WriteLine("Focus Test");
                FocusWindow(PID);
            }    

            threadRunning = true;
            Thread th;
            for (int i = 0; i < count; i++)
            {
                if (!threadRunning) break;
                th = new Thread(new ThreadStart(RealRun));                
                th.Start();
                th.Join();
            }
            tabControl1.Enabled = true;
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }    

        /// <summary>
        /// 테스트용 스레드
        /// </summary>
        public void TestingRun()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                if (!threadRunning) break;
            }            
        }

        /*
        /// <summary>
        /// 각각의 워킹플로우를 실행하는 스레드입니다.
        /// </summary>
        public void RealRun()
        {
            for (int i = 0; i < NodesList.Count; i++)
            {
                if (!threadRunning) break;
                int SnapCount = 0;
                foreach (MacroNode node in NodesList[i])
                {
                    if (!threadRunning) break;
                    SnapCount = RunTest.Run(node, textBox_SnapPath.Text, FilenameList[i], SnapCount, (ImageExtensions)comboBox_ImageFormat.SelectedIndex, SaveScreen);
                }
            }
        }
        */ // RealRun 백업
        
        /// <summary>
        /// 각각의 워킹플로우를 실행하는 스레드입니다.
        /// </summary>
        public void RealRun()
        {
            for (int i = 0; i < NodesList.Count; i++)
            {
                if (!threadRunning) break;
                if(saveLog | saveScreen)
                {
                    DirectoryInfo di = new DirectoryInfo(string.Format("{0}\\{1}", textBox_SnapPath.Text, FilenameList[i]));
                    if (!di.Exists)
                        di.Create();
                }
                if (SaveLog)
                {
                     using (FileStream fs = new FileStream(string.Format("{0}\\{1}\\Log.{2}", textBox_SnapPath.Text, FilenameList[i], comboBox_LogFormat.SelectedItem.ToString()), FileMode.Append, FileAccess.Write))// + "\\" + FilenameList[i] + "\\Log.csv", FileMode.Append, FileAccess.Write))
                     using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                     {
                         sw.WriteLine("No,Time,Event,X,Y,Interval,InputString,Tag,Window Class,Window Caption,Control Type,Name");
                         int no = 1;
                         foreach (MacroNode node in NodesList[i])
                         {
                             if (!threadRunning) break;
                             RunTest.Run(node, textBox_SnapPath.Text, FilenameList[i], no, (ImageExtensions)comboBox_ImageFormat.SelectedIndex, SaveScreen);

                             if (SaveLog)
                             {
                                 StringBuilder className = new StringBuilder(256);
                                 StringBuilder caption = new StringBuilder(256);
                                 IntPtr hwnd = (IntPtr)WindowFromPoint(Cursor.Position);
                                 AutomationElement AE = AutomationElement.FromHandle(hwnd);


                                 GetClassName(hwnd, className, 256);
                                 GetWindowText(hwnd, caption, 256);

                                 sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                                     (no++).ToString(),
                                     DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"),
                                     node.state.ToString(),
                                     node.x.ToString(),
                                     node.y.ToString(),
                                     node.interval.ToString(),
                                     node.inputString,
                                     node.tag,
                                     className,
                                     caption,
                                     AE.Current.ControlType.LocalizedControlType,
                                     AE.Current.Name
                                     ));
                             }
                         }
                         sw.Flush();
                     }
                }
                else                    
                {
                    int SnapCount = 1;
                    foreach (MacroNode node in NodesList[i])
                    {
                        if (!threadRunning) break;
                        SnapCount = RunTest.Run(node, textBox_SnapPath.Text, FilenameList[i], SnapCount++, (ImageExtensions)comboBox_ImageFormat.SelectedIndex, SaveScreen);
                    }               
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern int WindowFromPoint(Point lpPoint);

        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);

        [DllImport("user32.dll")]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public IntPtr getHandle()
        {
            Point ptCursor = new Point();
            ptCursor = Cursor.Position;

            return (IntPtr)WindowFromPoint(ptCursor);
        }


        #endregion

        #region Testing Class

        /// <summary>
        /// Main Work Flow의 테스트를 위한 클래스
        /// </summary>
        private class RunTest
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

            [DllImport("user32")]
            public static extern int SetCursorPos(int x, int y);

            [DllImport("user32.dll")]
            public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

            private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
            private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
            private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
            private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            private const int MOUSEEVENTF_RIGHTUP = 0x0010;
            private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
            private const int MOUSEEVENTF_WHEEL = 0x0800;
            private const int MOUSEEVENTF_HWHEEL = 0x01000;

            private const int vKeyUp = 0x0000; /* keyboard up */
            private const int vKeyDown = 0x0002; /* keyboard down */

            private readonly ManualResetEvent stoppeing_event_ = new ManualResetEvent(false);
            TimeSpan interval_ = TimeSpan.FromMilliseconds(100);

            public static void SendKeyInterval(string message)
            {
                SendKeys.SendWait(message);
            }

            public static int Run(MacroNode macroNode, string path, string filename, int SnapCount, ImageExtensions extensions, bool saveScreen)
            {
                try
                {
                    ManualResetEvent stoppeing_event_ = new ManualResetEvent(false);
                    stoppeing_event_.Reset();

                    switch (macroNode.state)
                    {
                        case NodeStates.마우스_이동:
                            SetCursorPos(macroNode.x, macroNode.y);
                            break;
                        case NodeStates.마우스_왼쪽클릭:
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            break;
                        case NodeStates.마우스_오른쪽클릭:
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            break;
                        case NodeStates.마우스_더블클릭:
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            break;
                        case NodeStates.마우스_휠클릭:
                            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);

                            break;
                        case NodeStates.마우스_이동_후_왼쪽클릭:
                            SetCursorPos(macroNode.x, macroNode.y);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            break;
                            /*
                        case NodeStates.마우스_휠_내리기:
                            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 0, 2);
                            break;

                        case NodeStates.마우스_휠_올리기:
                            mouse_event(MOUSEEVENTF_HWHEEL, 0, 0, 0, 2);
                            break;
                            */
                        case NodeStates.마우스_누르기_왼쪽:
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            break;

                        case NodeStates.마우스_떼기_왼쪽:
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            break;

                        case NodeStates.마우스_누르기_오른쪽:
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                            break;

                        case NodeStates.마우스_떼기_오른쪽:
                            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            break;

                        case NodeStates.마우스_누르기_휠:
                            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                            break;

                        case NodeStates.마우스_떼기_휠:
                            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                            break;

                        case NodeStates.시스템_대기:
                            break;

                        case NodeStates.시스템_스크린샷찍기:
                            if(saveScreen)
                                ScreenSave(string.Format("{0}\\{1}", path, filename), SnapCount++, extensions);
                            break;

                        case NodeStates.키보드_키입력:
                            SendKeyInterval(macroNode.inputString);
                            break;
                    }
                    stoppeing_event_.WaitOne(macroNode.interval);
                    return SnapCount;
                }
                catch (Exception e)
                {
                    MessageBox.Show("EXCEPTION : \r\n" + e.Message);
                    return -1;
                }
            }

            public static void ScreenSave(string path, int SnapCount, ImageExtensions extensions)
            {
                // 주화면의 크기 정보 읽기
                // SetDpiAwareness();
                Rectangle rect = Screen.PrimaryScreen.WorkingArea;

                // 2nd screen = Screen.AllScreens[1]

                //Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                Console.WriteLine(string.Format("모니터 1 : ({0}x{1})", rect.Width, rect.Height));
                // 픽셀 포맷 정보 얻기 (Optional)
                //PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
                PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
                // 화면 크기만큼의 Bitmap 생성
                Bitmap bmp = new Bitmap(rect.Width, rect.Height, pixelFormat);

                // Bitmap 이미지 변경을 위해 Graphics 객체 생성
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    // 화면을 그대로 카피해서 Bitmap 메모리에 저장
                    gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
                }

                // Bitmap 데이타를 파일로 저장                
                bmp.Save(string.Format("{0}\\snap{1}.{2}", path, SnapCount.ToString(), extensions.ToString()));
                Console.WriteLine(string.Format("스크린샷 저장 ({3}x{4}) : {0}\\snap{1}.{2}", path, SnapCount.ToString(), extensions.ToString(), rect.Width, rect.Height));

                bmp.Dispose();
            }

            private enum ProcessDPIAwareness
            {
                ProcessDPIUnaware = 0,
                ProcessSystemDPIAware = 1,
                ProcessPerMonitorDPIAware = 2
            }
        }

        public enum ImageExtensions
        {
            jpg,
            bmp,
            png
        }

        #endregion

        #region Event Handlers

        private void Button_추가_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialig = new OpenFileDialog();
            openFileDialig.Filter = string.Format("Picidae 워크플로우|*.pawf");
            openFileDialig.Title = string.Format("워크플로우 추가");
            openFileDialig.Multiselect = true;
            if (openFileDialig.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialig.FileNames)
                {
                    Stream stream = File.Open(filename, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<MacroNode> openedWorkflow = (List<MacroNode>)formatter.Deserialize(stream);
                    NodesList.Add(openedWorkflow);
                    string name = filename.Split('\\').Last().Split('.')[0];

                    // 이미 추가한 Workflow라면 뒤에 넘버링을 한다.
                    int num = 0;
                    if (FilenameList.Contains(name))
                    {
                        while (FilenameList.Contains(string.Format("{0}({1})", name, ++num))) ;
                        name = string.Format("{0}({1})", name, num);
                    }                        

                    ListViewItem lim = new ListViewItem(name);
                    int interval = SumInterval(openedWorkflow);
                    lim.SubItems.Add(interval.ToString());
                    AddRunningTime = interval;
                    listView_WorkFlow.Items.Add(lim);
                    FilenameList.Add(name);
                    stream.Close();
                }
            }
        }

        private void Button_삭제_Click(object sender, EventArgs e)
        {
            if (listView_WorkFlow.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_WorkFlow.SelectedIndices[0];
                Console.WriteLine("== Delete Workflow {0}", selectedIndex.ToString());
                NodesList.RemoveAt(selectedIndex);
                AddRunningTime = -int.Parse(listView_WorkFlow.Items[selectedIndex].SubItems[1].Text);
                listView_WorkFlow.Items[selectedIndex].Remove();
                FilenameList.RemoveAt(selectedIndex);              
            }
            else
                Console.WriteLine("== Delete Fail");
        }

        private void listView_WorkFlow_ItemDragDrop(object sender, DragableListView.ListViewItemDragEventArgs e)
        {
            if (!e.Cancel)
            {
                int before = ((DragableListView.DragableListView)sender).Before;
                int after = e.InsertionIndex;
                Console.WriteLine(string.Format("Before : {0}, After : {1}", before, after));
                List<MacroNode> beforeNode = NodesList[before];
                NodesList.RemoveAt(before);
                NodesList.Insert(after, beforeNode);
            }
        }

        private void Button_찾아보기_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_SnapPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void checkBox_DontSaveSnap_CheckedChanged(object sender, EventArgs e)
        {
            SaveScreen = !((CheckBox)sender).Checked;
        }

        private void checkBox_Focus_CheckedChanged(object sender, EventArgs e)
        {
            FocusProcess = ((CheckBox)sender).Checked;
        }         

        private void comboBox_HotKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotkeysetting(false, lastHotKey);
            Hotkeysetting(true,comboBox_HotKey.SelectedIndex);
            lastHotKey = comboBox_HotKey.SelectedIndex;
        }

        private void listView_ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_FocusWindow.Text = "PID : " + listView_ProcessList.Items[listView_ProcessList.SelectedIndices[0]].SubItems[1].Text;
            PID = int.Parse(listView_ProcessList.Items[listView_ProcessList.SelectedIndices[0]].SubItems[1].Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AddRunningTime = 0;
        }

        private void Button_새로고침_Click(object sender, EventArgs e)
        {
            getProcessList();
        }

        #endregion

        private void checkBox_DontSaveLog_CheckedChanged(object sender, EventArgs e)
        {
            SaveLog = !((CheckBox)sender).Checked;
        }
    }
}
