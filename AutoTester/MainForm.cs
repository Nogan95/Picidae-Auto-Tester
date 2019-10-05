using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.InteropServices;
using DragableListView;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using AutoTestStructure;

namespace AutoTester
{
    public partial class MainForm : Form
    {
        #region Private Instance Field

        private HashSet<string> PrefabsDupCheckSet;
        private List<MacroNode> Prefabs;
        private List<MacroNode> Nodes;
        private PrefabsSaveFormat SerializePrefabs = new PrefabsSaveFormat();
        private PopEventFromImage ImagePointEditor;
        private PopWorkflowFromImage workflowEditorTool;
        private EventSetList _EventSetList;
        private NodeEditor NodeModifyer;
        private string workFlowPath="";
        private const string PROGRAM_FULL_NAME = "Picidae Autotest Editor"; // Picidae 딱따구리
        private const string PROGRAM_KEY_WORD = "Picidae";
        private const int No_INDEX = 0;
        private List<MacroNode> Clipboard = new List<MacroNode>();        

        #endregion

        #region Public Member Field

        public bool addSuccess = false;
        public bool nodeEditorOn = false;
        public bool ImagePrefabEditorOn = false;
        public bool ImageWorkflowEditorOn = false;
        public bool HelpOn = false;
        public bool isModified = false;
        public string WorkFlowName
        {
            get
            {
                if (workFlowPath.Equals(""))
                    return workFlowPath;
                else
                    return workFlowPath.Split('\\').Last().Split('.')[0];
            }
        }
        public string WorkFlowPath
        {
            get
            {
                return workFlowPath;
            }
            set
            {
                workFlowPath = value;
                if (value.Equals(""))
                {
                    this.Text = PROGRAM_FULL_NAME;
                    label_WorkflowName.Text = "워크플로우";
                }
                else
                {
                    this.Text = string.Format("{0} - {1}", WorkFlowName, PROGRAM_FULL_NAME);
                    label_WorkflowName.Text = string.Format("워크플로우 - {0}", WorkFlowName);
                }
            }
        }
        
        public ColumnFlag MainListColumnFlag = ColumnFlag.Tag;
        public bool EventSetListOn = false;

        #endregion

        #region Public Constructors

        public MainForm()
        {
            InitializeComponent();
            customInitialize();
            this.Text = PROGRAM_FULL_NAME;
            menuStrip.Renderer = new renderer();
            GstStructureExtension.Add(SavedContainerType.이벤트집합, "*.paes");
            GstStructureExtension.Add(SavedContainerType.워크플로우, "*.pawf");
            SetWorkflowColumnHeader(); 
            GenerateImages();
        }

        #endregion

        #region Private Members

        /// <summary>
        /// 초기화를 위한 함수입니다.
        /// </summary>
        private void customInitialize()
        {
            PrefabsDupCheckSet = new HashSet<string>();
            Prefabs = new List<MacroNode>();
            Nodes = new List<MacroNode>();
            listView_Main.Items.Clear();
            listView_Prefabs.Items.Clear();
            SerializePrefabs.Prefabs = Prefabs;
            SerializePrefabs.PrefabsDupCheckSet = PrefabsDupCheckSet;
            addSuccess = false;
            nodeEditorOn = false;
            ImagePrefabEditorOn = false;
            isModified = false;
        }
        
        /// <summary>
        ///  불러오기 한 리스트를 덮어씌워주는 함수
        /// </summary>
        /// <param name="list">타겟 리스트</param>
        /// <param name="node">아이템 제네릭 리스트</param>
        private void SetNodeList(ListView list, List<MacroNode> node, bool isPrefab)
        {
            list.Items.Clear();            
            foreach (MacroNode macroNode in node)
            {
                list.Items.Add(GenerateItem(macroNode, isPrefab));
            }
            SetListIndex();
        }

        /// <summary>
        /// 워크플로우 열을 바꿉니다.
        /// </summary>
        private void SetWorkflowColumnHeader()
        {
            listView_Main.Columns.Clear();
            listView_Main.Columns.Add(new ColumnHeader { Text = "No" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Type" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Event" });

            if ((MainListColumnFlag & ColumnFlag.Tag) != 0)
                listView_Main.Columns.Add(new ColumnHeader { Text = "Tag" });

            if ((MainListColumnFlag & ColumnFlag.Point) != 0)
                listView_Main.Columns.Add(new ColumnHeader { Text = "Point" });

            if ((MainListColumnFlag & ColumnFlag.Interval) != 0)
                listView_Main.Columns.Add(new ColumnHeader { Text = "Interval" });

            if ((MainListColumnFlag & ColumnFlag.InputString) != 0)
                listView_Main.Columns.Add(new ColumnHeader { Text = "InputString" });
        }
        
        [Flags]
        public enum ColumnFlag
        {
            None=0,
            Tag = 1 << 0,
            Point = 1 << 1,
            Interval = 1 << 2,
            InputString = 1 << 3,
        }

        /// <summary>
        /// 리스트 인덱스를 다시 그립니다.
        /// </summary>
        private void SetListIndex()
       {
           int index = 0;
           foreach (ListViewItem item in listView_Main.Items)
           {
               item.SubItems[No_INDEX].Text = (++index).ToString();
           }
       }

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
                SendKeys.Send(message);
            } 

            public static void Run(MacroNode macroNode, bool clickTest)
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
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;
                        case NodeStates.마우스_오른쪽클릭:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            }
                            break;
                        case NodeStates.마우스_더블클릭:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;
                        case NodeStates.마우스_휠클릭:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                            }
                            break;
                        case NodeStates.마우스_이동_후_왼쪽클릭:
                            SetCursorPos(macroNode.x, macroNode.y);
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
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
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.마우스_떼기_왼쪽:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.마우스_누르기_오른쪽:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.마우스_떼기_오른쪽:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.마우스_누르기_휠:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.마우스_떼기_휠:
                            if (clickTest)
                            {
                                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                            }
                            break;

                        case NodeStates.시스템_대기:
                            break;

                        case NodeStates.시스템_스크린샷찍기:
                            break;

                        case NodeStates.키보드_키입력:
                            SendKeyInterval(macroNode.inputString);
                            break;
                    }
                    stoppeing_event_.WaitOne(macroNode.interval);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Send Event \r\n" + e.Message);
                }
            }
        }

        /// <summary>
        /// MacroNode로 리스트뷰 형식에 맞는 ListViewItem을 반환해줍니다.
        /// </summary>
        /// <param name="macroNode"></param>
        /// <returns></returns>
        private ListViewItem GenerateItem(MacroNode macroNode, bool isPrefab)
        {
            if (isPrefab)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    ImageIndex = (int)macroNode.state,
                    Text = NodeSetter.NodeName(macroNode.state, false)
                };
                listViewItem.SubItems.Add(NodeSetter.NodeName(macroNode.state, true));
                listViewItem.SubItems.Add(macroNode.tag);
                return listViewItem;
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    ImageIndex = (int)macroNode.state,
                    Text = ""
                };
                listViewItem.SubItems.Add(NodeSetter.NodeName(macroNode.state, false));
                listViewItem.SubItems.Add(NodeSetter.NodeName(macroNode.state, true));

                if ((MainListColumnFlag & ColumnFlag.Tag) != 0)
                    listViewItem.SubItems.Add(macroNode.tag);

                if ((MainListColumnFlag & ColumnFlag.Point) != 0)
                    listViewItem.SubItems.Add(string.Format("{0}, {1}", macroNode.x, macroNode.y));

                if ((MainListColumnFlag & ColumnFlag.Interval) != 0)
                    listViewItem.SubItems.Add(macroNode.interval.ToString());

                if ((MainListColumnFlag & ColumnFlag.InputString) != 0)
                    listViewItem.SubItems.Add(macroNode.inputString);
                return listViewItem;
            }          
        }
        
        /// <summary>
        /// MacroNode ColorTable에 맞는 ImageList를 초기화 합니다.
        /// </summary>
        private void GenerateImages()
        {
            foreach (NodeStates nodeState in Enum.GetValues(typeof(NodeStates)))
            {
                Bitmap image;
                Rectangle bounds;

                bounds = new Rectangle(Point.Empty, imageList.ImageSize);
                image = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);

                using (Graphics g = Graphics.FromImage(image))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    using (Brush brush = new SolidBrush(NodeSetter.NodeColor(nodeState)))
                    {
                        g.FillEllipse(brush, bounds);
                    }
                }
                imageList.Images.Add(image);
            }
        }

        /// <summary>
        /// 저장 형식
        /// </summary>
        private enum SaveType
        {
            저장,
            다른이름으로저장
        }

        /// <summary>
        /// 저장되는 컨테이너의 형식
        /// </summary>
        private enum SavedContainerType
        {
            이벤트집합,
            워크플로우
        }

        private Dictionary<SavedContainerType, string> GstStructureExtension = new Dictionary<SavedContainerType, string>();

        /// <summary>
        /// SaveFileDialog를 호출하는 Method
        /// </summary>
        /// <param name="saveType"></param>
        /// <param name="structureType"></param>
        /// <returns></returns>
        private bool SaveMacroFile(SaveType saveType, SavedContainerType structureType)
        {
            string saveFilePath = "";
            if (saveType == SaveType.저장 && !WorkFlowName.Equals(""))
            {
                saveFilePath = WorkFlowPath;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = string.Format("{0} {1}|{2}", PROGRAM_KEY_WORD, structureType.ToString(), GstStructureExtension[structureType]);
                saveFileDialog.Title = string.Format("{0} {1}", structureType.ToString(), saveType.ToString());
                if (saveFileDialog.ShowDialog() != DialogResult.OK || saveFileDialog.FileName.Equals(""))
                {
                    return false; // Cancle
                }
                saveFilePath = saveFileDialog.FileName;
            }           
            BinaryFormatter serializer = new BinaryFormatter();
            Stream stream = File.Open(saveFilePath, FileMode.Create);
            switch (structureType)
            {
                case SavedContainerType.워크플로우:
                    serializer.Serialize(stream, Nodes);
                    WorkFlowPath = saveFilePath;
                    break;
                case SavedContainerType.이벤트집합: 
                    SerializePrefabs.PrefabsDupCheckSet = PrefabsDupCheckSet;
                    serializer.Serialize(stream, SerializePrefabs);
                    break;
            }            
            stream.Close();            
            isModified = false;
            return true;
        }

        /// <summary>
        /// OpenFileDialog를 호출하는 Method
        /// </summary>
        /// <param name="structureType"></param>
        /// <returns></returns>
        private bool OpenMacroFile(SavedContainerType structureType)
        {
            OpenFileDialog openFileDialig = new OpenFileDialog();
            openFileDialig.Filter = string.Format("{0} {1}|{2}", PROGRAM_KEY_WORD, structureType.ToString(), GstStructureExtension[structureType]);
            openFileDialig.Title = string.Format("{0} 열기", structureType.ToString());
            if (openFileDialig.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            Stream stream = File.Open(openFileDialig.FileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            switch (structureType)
            {
                case SavedContainerType.이벤트집합: 
                    PrefabsSaveFormat openedData = (PrefabsSaveFormat)formatter.Deserialize(stream);
                    Prefabs = openedData.Prefabs;
                    PrefabsDupCheckSet = openedData.PrefabsDupCheckSet;
                    SetNodeList(listView_Prefabs, Prefabs,true);
                    break;
                case SavedContainerType.워크플로우:
                    List<MacroNode> openedWorkflow = (List<MacroNode>)formatter.Deserialize(stream);
                    Nodes = openedWorkflow;
                    SetNodeList(listView_Main, Nodes,false);
                    WorkFlowPath = openFileDialig.FileName;
                    break;
            }
            stream.Close();
            isModified = false;
            return true;
        }

        #endregion

        #region Event Handlers

            #region Field Button Click Event Handlers

        private void btn_PrefabsAdd_Click(object sender, EventArgs e)
        {
            addSuccess = false;
            NodeEditor np = new NodeEditor(PrefabsDupCheckSet, NodeEditor.PopType.NewPrefab);
            np.Owner = this;
            np.ShowDialog();
            if (addSuccess)
            {
                Console.WriteLine("== Save prefab");
                PrefabsDupCheckSet.Add(np.NewNode.tag);
                Prefabs.Add((MacroNode)np.NewNode.Clone());
                listView_Prefabs.Items.Add(GenerateItem(np.NewNode,true));
                np.Close();
                addSuccess = false;
            }
        }

        private void btn_PrefabsDelete_Click(object sender, EventArgs e)
        {
            if (listView_Prefabs.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_Prefabs.SelectedIndices[0];
                Console.WriteLine("== Delete prefab {0}", selectedIndex.ToString());
                Prefabs.RemoveAt(selectedIndex);
                PrefabsDupCheckSet.Remove(listView_Prefabs.Items[selectedIndex].SubItems[2].Text);
                listView_Prefabs.Items[selectedIndex].Remove();
            }
            else
                Console.WriteLine("== Delete Fail");
        }

        private void btn_NodeAdd_Click(object sender, EventArgs e)
        {
            addSuccess = false;
            NodeEditor np = new NodeEditor(NodeEditor.PopType.NewNode);
            np.Owner = this;
            np.ShowDialog();
            if (addSuccess)
            {
                Console.WriteLine("== Save Node");
                Nodes.Add((MacroNode)np.NewNode.Clone());
                listView_Main.Items.Add(GenerateItem(np.NewNode,false));
                np.Close();
                addSuccess = false;
                isModified = true;
                SetListIndex();
            }            
        }

        private void btn_NodeDelete_Click(object sender, EventArgs e)
        {
            if (listView_Main.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_Main.SelectedIndices[0];
                Console.WriteLine("== Delete Node {0}", selectedIndex.ToString());
                Nodes.RemoveAt(selectedIndex);
                listView_Main.Items[selectedIndex].Remove();
                isModified = true;
                SetListIndex();
            }
            else
                Console.WriteLine("== Delete Fail");
        }

        private void button_PrefabToNode_Click(object sender, EventArgs e)
        {
            if (listView_Prefabs.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_Prefabs.SelectedIndices[0];
                Console.WriteLine("== Prefab to Node {0}", selectedIndex.ToString());
                MacroNode mn = (MacroNode)Prefabs[selectedIndex].Clone();
                Nodes.Add(mn);
                listView_Main.Items.Add(GenerateItem(mn,false));
                isModified = true;
                SetListIndex();
            }
            else
                Console.WriteLine("== Fail Prefab to Node");            
        }

        private void button_NodeToPrefab_Click(object sender, EventArgs e)
        {
            if (listView_Main.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView_Main.SelectedIndices[0];
                if (listView_Main.Items[selectedIndex].SubItems[2].Text.Equals("") || PrefabsDupCheckSet.Contains(listView_Main.Items[selectedIndex].SubItems[2].Text))
                {
                    MessageBox.Show("중복되거나 빈 Tag입니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MacroNode mn = (MacroNode)Nodes[selectedIndex].Clone();
                PrefabsDupCheckSet.Add(mn.tag);
                Prefabs.Add(mn);
                listView_Prefabs.Items.Add(GenerateItem(mn, true));
            }
            else
                Console.WriteLine("== Fail Prefab to Node");
        }
             
        #endregion
        
            #region UI Paint Event Handlers

        /// <summary>
        /// MenuStrip의 Hover Color를 변경하기 위한 Custom Renderer
        /// </summary>
        private class renderer : ToolStripProfessionalRenderer
        {
            public renderer() : base(new cols()) { }
        }

        /// <summary>
        /// MenuStrip의 Hover Color를 변경하기 위한 Custom ColorTable
        /// </summary>
        private class cols : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Silver; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Silver; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Silver; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Silver; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(64, 64, 64); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(64, 64, 64); }
            }            
        }

        private void btn_Plus_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Plus_Hover_;
        }

        private void btn_Minus_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Minus_Hover_;
        }

        private void btn_Plus_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Plus;
        }

        private void btn_Minus_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Minus;
        }

        private void btn_RightArrow_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_RightArrow_Hover_;
        }

        private void btn_LeftArrow_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_LeftArrow_Hover_;
        }

        private void btn_RightArrow_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_RightArrow;
        }

        private void btn_LeftArrow_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_LeftArrow;
        }

        private void panel_QuickMenu_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 0), new Point(790, 24), Color.FromArgb(255, 68, 68, 68), Color.FromArgb(255, 89, 89, 89));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 790, 24);
        }

        #endregion

            #region Child Invoke Event Handlers

        private void addPrefabFromImage(object sender, EventArgs e)
        {
            PrefabsDupCheckSet.Add(ImagePointEditor.NewNode.tag);
            Prefabs.Add((MacroNode)ImagePointEditor.NewNode.Clone());
            listView_Prefabs.Items.Add(GenerateItem(ImagePointEditor.NewNode,true));
        }
        
        private void modifyNode(object sender, EventArgs e)
        {
            if (listView_Main.SelectedItems.Count == 1 && nodeEditorOn)
            {
                int selectedIndex = listView_Main.FocusedItem.Index;
                Nodes[selectedIndex] = (MacroNode)NodeModifyer.NewNode.Clone();
                string indexTmp = listView_Main.Items[selectedIndex].SubItems[No_INDEX].Text;
                listView_Main.Items[selectedIndex] = GenerateItem(NodeModifyer.NewNode,false);
                listView_Main.Items[selectedIndex].SubItems[No_INDEX].Text = indexTmp;
            }
        }

        private void LoadEventSetByList(object sender, EventArgs e)
        {
            Prefabs = _EventSetList.eventSetList[_EventSetList.SelectedIndex].Prefabs;
            PrefabsDupCheckSet = _EventSetList.eventSetList[_EventSetList.SelectedIndex].PrefabsDupCheckSet;
            SetNodeList(listView_Prefabs, Prefabs, true);
        }

        private void AddNodesByWorkflowEditorTool(object sender, EventArgs e)
        {
            foreach (MacroNode macronode in workflowEditorTool.Nodes)
            {
                Nodes.Add((MacroNode)macronode.Clone());
                listView_Main.Items.Add(GenerateItem(macronode, false));
            }
            SetListIndex();
            workflowEditorTool.EndInsert();
        }

        #endregion

            #region Menu Strip Event Handlers

        /* Save And Load Event Handlers */

        private void ToolStripMenuClick_내보내기(object sender, EventArgs e)
        {
            SaveMacroFile(SaveType.다른이름으로저장, SavedContainerType.이벤트집합);
        }

        private void ToolStripMenuClick_불러오기(object sender, EventArgs e)
        {
            OpenMacroFile(SavedContainerType.이벤트집합);
        }

        private void ToolStripMenuClick_다른이름으로저장(object sender, EventArgs e)
        {
            SaveMacroFile(SaveType.다른이름으로저장, SavedContainerType.워크플로우);            
        }

        private void ToolStripMenuClick_열기(object sender, EventArgs e)
        {
            if (isModified)
            {
                switch (MessageBox.Show("현재 워크플로우를 저장 하시겠습니까?", "경고", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        SaveMacroFile(SaveType.저장, SavedContainerType.워크플로우);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }        
            }
            OpenMacroFile(SavedContainerType.워크플로우);
        }
        
        private void ToolStripMenuClick_저장(object sender, EventArgs e)
        {
            SaveMacroFile(SaveType.저장, SavedContainerType.워크플로우);
        }

        private void ToolStripMenuClick_새로만들기(object sender, EventArgs e)
        {
            if (isModified)
            {
                switch (MessageBox.Show("현재 워크플로우를 저장 하시겠습니까?", "경고", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        if (!SaveMacroFile(SaveType.저장, SavedContainerType.워크플로우))
                            return;     
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            customInitialize(); WorkFlowPath = "";
            WorkFlowPath = "";
        }

        private void ToolStripMenuClick_끝내기(object sender, EventArgs e)
        {
            if (isModified)
            {
                switch (MessageBox.Show("현재 워크플로우를 저장 하시겠습니까?", "경고", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        if (!SaveMacroFile(SaveType.저장, SavedContainerType.워크플로우))
                            return;
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            this.Close();
        }

        

        /* Hot Key Event Handlers */

        private void Hotkey_삭제(object sender, EventArgs e)
        {
            int offset = 0;
            if (listView_Main.Focused && listView_Main.SelectedIndices.Count > 0)
            {
                foreach (int index in listView_Main.SelectedIndices)
                {
                    Nodes.RemoveAt(index - offset);
                    listView_Main.Items.RemoveAt(index - offset++);
                    SetListIndex();
                }
            }
            else if (listView_Prefabs.Focused && listView_Prefabs.SelectedIndices.Count > 0)
            {
                foreach (int index in listView_Prefabs.SelectedIndices)
                {
                    Prefabs.RemoveAt(index - offset);
                    listView_Prefabs.Items.RemoveAt(index - offset++);
                }
            }
        }

        private void Hotkey_복사(object sender, EventArgs e)
        {
            if (listView_Main.Focused && listView_Main.SelectedIndices.Count > 0)
            {
                Clipboard.Clear();
                foreach (int index in listView_Main.SelectedIndices)
                {
                    Clipboard.Add((MacroNode)Nodes[index].Clone());
                }
            }
            else if (listView_Prefabs.Focused && listView_Prefabs.SelectedIndices.Count > 0)
            {
                Clipboard.Clear();
                foreach (int index in listView_Prefabs.SelectedIndices)
                {
                    Clipboard.Add((MacroNode)Prefabs[index].Clone());
                }
            }
        }

        private void Hotkey_붙여넣기(object sender, EventArgs e)
        {
            if (listView_Main.Focused && Clipboard.Count != 0)
            {
                if (listView_Main.SelectedIndices.Count > 0)
                {

                    int index = listView_Main.SelectedIndices[listView_Main.SelectedIndices.Count-1];
                    foreach (MacroNode macroNode in Clipboard)
                    {
                        Nodes.Insert(++index, (MacroNode)macroNode.Clone());
                        listView_Main.Items.Insert(index, GenerateItem((MacroNode)macroNode.Clone(), false));
                    }
                }
                else
                {
                    foreach (MacroNode macroNode in Clipboard)
                    {
                        Nodes.Add((MacroNode)macroNode.Clone());
                        listView_Main.Items.Add(GenerateItem((MacroNode)macroNode.Clone(), false));
                    }
                }
                SetListIndex();
            }
            else if (listView_Prefabs.Focused && Clipboard.Count != 0)
            {
                if (listView_Prefabs.SelectedIndices.Count > 0)
                {
                    int index = listView_Prefabs.SelectedIndices[listView_Prefabs.SelectedIndices.Count - 1];
                    foreach (MacroNode macroNode in Clipboard)
                    {
                        if (!PrefabsDupCheckSet.Contains(macroNode.tag))
                        {
                            Prefabs.Insert(++index, (MacroNode)macroNode.Clone());
                            listView_Prefabs.Items.Insert(index, GenerateItem((MacroNode)macroNode.Clone(), true));
                            PrefabsDupCheckSet.Add(macroNode.tag);
                        }
                    }
                }
                else
                {
                    foreach (MacroNode macroNode in Clipboard)
                    {
                        if (!PrefabsDupCheckSet.Contains(macroNode.tag))
                        {
                            Prefabs.Add((MacroNode)macroNode.Clone());
                            listView_Prefabs.Items.Add(GenerateItem((MacroNode)macroNode.Clone(), true));
                            PrefabsDupCheckSet.Add(macroNode.tag);
                        }
                    }
                }
            }
        }

        private void Hotkey_전체선택(object sender, EventArgs e)
        {
            if (listView_Main.Focused)
            {
                foreach (ListViewItem item in listView_Main.Items)
                {
                    item.Selected = true;
                }
            }
            else if (listView_Prefabs.Focused)
            {
                foreach (ListViewItem item in listView_Prefabs.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void Hotkey_잘라내기(object sender, EventArgs e)
        {
            if (listView_Main.Focused && listView_Main.SelectedIndices.Count > 0)
            {
                Clipboard.Clear();
                foreach (int index in listView_Main.SelectedIndices)
                {
                    Clipboard.Add((MacroNode)Nodes[index].Clone());
                }
            }
            else if (listView_Prefabs.Focused && listView_Prefabs.SelectedIndices.Count > 0)
            {
                Clipboard.Clear();
                foreach (int index in listView_Prefabs.SelectedIndices)
                {
                    Clipboard.Add((MacroNode)Prefabs[index].Clone());
                }
            }

            int offset = 0;
            if (listView_Main.Focused && listView_Main.SelectedIndices.Count > 0)
            {
                foreach (int index in listView_Main.SelectedIndices)
                {
                    Nodes.RemoveAt(index - offset);
                    listView_Main.Items.RemoveAt(index - offset++);
                }
            }
            else if (listView_Prefabs.Focused && listView_Prefabs.SelectedIndices.Count > 0)
            {
                foreach (int index in listView_Prefabs.SelectedIndices)
                {
                    Prefabs.RemoveAt(index - offset);
                    listView_Prefabs.Items.RemoveAt(index - offset++);
                }
            }
        }


        /* Call Popup Event Handlers */

        private void CallPopup_이미지로이벤트추가(object sender, EventArgs e)
        {
            if (!ImagePrefabEditorOn)
            {
                ImagePointEditor = new PopEventFromImage(PrefabsDupCheckSet);
                ImagePointEditor.AddButtonClick += addPrefabFromImage;
                ImagePointEditor.Owner = this;
                ImagePointEditor.Show();
                ImagePrefabEditorOn = true;
            }
        }

        private void CallPopup_이미지로워크플로우추가(object sender, EventArgs e)
        {
            if (!ImageWorkflowEditorOn)
            {
                workflowEditorTool = new PopWorkflowFromImage();
                workflowEditorTool.AddButtonClick += AddNodesByWorkflowEditorTool;
                workflowEditorTool.Owner = this;
                workflowEditorTool.Show();
                ImageWorkflowEditorOn = true;
            }
        }
                        
        private void CallPopup_이벤트집합목록(object sender, EventArgs e)
        {
            if (!EventSetListOn)
            {
                _EventSetList = new EventSetList();
                _EventSetList.Owner = this;
                _EventSetList.SelectEventSet += LoadEventSetByList;
                _EventSetList.Show();
                EventSetListOn = true;
            }
        }
        
        private void CallPopup_도움말(object sender, EventArgs e)
        {
            if (!HelpOn)
            {
                Help newHelp = new Help();
                newHelp.Owner = this;
                newHelp.Show();
                HelpOn = true;
            }
        }

        private void CallPopup_워크플로우열설정(object sender, EventArgs e)
        {
            SetWorkflowColumn swc = new SetWorkflowColumn(MainListColumnFlag);
            swc.Owner = this;
            ColumnFlag BeforeFlag = MainListColumnFlag;
            swc.ShowDialog();
            Console.WriteLine("END");
            if (BeforeFlag != MainListColumnFlag)
            {
                SetWorkflowColumnHeader();
                SetNodeList(listView_Main, Nodes, false);
            }
        }

        /// <summary>
        /// Node Editor를 Edit Mode로 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView_Main.SelectedItems.Count == 1 && !nodeEditorOn)
            {
                NodeModifyer = new NodeEditor(NodeEditor.PopType.EditNode);
                NodeModifyer.AddButtonClick += modifyNode;
                NodeModifyer.Owner = this;
                NodeModifyer.Show();
                NodeModifyer.setEditor(Nodes[listView_Main.FocusedItem.Index]);
                nodeEditorOn = true;
            }
        }

        /// <summary>
        /// Node Editor의 선택 노드 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Main_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView_Main.SelectedItems.Count == 1 && nodeEditorOn)
            {
                NodeModifyer.setEditor(Nodes[listView_Main.FocusedItem.Index]);
            }
        }


        /* Run Test Event Handlers */

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (MacroNode macronode in Nodes)
            {
                RunTest.Run(macronode, false);
            }
            this.Enabled = true;
        }

        private void 시작ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (MacroNode macronode in Nodes)
            {
                RunTest.Run(macronode, true);
            }
            this.Enabled = true;
        }

        #endregion

            #region Mouse Events
            
        private void listView_Prefabs_ItemDragDrop(object sender, ListViewItemDragEventArgs e)
        {
            if (!e.Cancel)
            {
                int before = ((DragableListView.DragableListView)sender).Before;
                int after = e.InsertionIndex;
                Console.WriteLine(string.Format("Before : {0}, After : {1}", before, after));
                MacroNode beforeNode = Prefabs[before];
                Prefabs.RemoveAt(before);
                Prefabs.Insert(after, beforeNode);
            }
        }

        private void listView_Main_ItemDragDrop(object sender, ListViewItemDragEventArgs e)
        {
            if (!e.Cancel)
            {
                int before = ((DragableListView.DragableListView)sender).Before;
                int after = e.InsertionIndex;
                Console.WriteLine(string.Format("Before : {0}, After : {1}",before,after));
                MacroNode beforeNode = Nodes[before];
                Nodes.RemoveAt(before);
                Nodes.Insert(after, beforeNode);
            }
            SetListIndex();
        }

        private void listView_Prefabs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button_PrefabToNode_Click(sender, (EventArgs)e);
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

        #endregion

        #endregion
    }   
}

