using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AutoTestStructure;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace AutoTester
{
    public partial class PopWorkflowFromImage : Form
    {
        private List<Image> imgList = new List<Image>();
        private List<MacroNode> nodes = new List<MacroNode>();
        public List<MacroNode> Nodes { get { return nodes; } set { } }
        private double originalWidth = 0;
        private double originalHeight = 0;
        private Size originalSize
        {
            get
            {
                return new Size((int)originalWidth, (int)originalHeight);
            }
            set
            {
                originalWidth = value.Width;
                originalHeight = value.Height;
                label_curPosition.Text = string.Format("(0/{0}, 0/{1})", originalWidth, originalHeight);
            }
        }
        private bool isDoubleClick = false;
        private bool isImageLoad = false;
        public event EventHandler AddButtonClick;

        public PopWorkflowFromImage()        {
            
            InitializeComponent();
            GenerateImages();
        }

        public void EndInsert()
        {
            nodes = new List<MacroNode>();
            listView_WorkFlow.Items.Clear();
        }

        private ListViewItem GenerateItem(MacroNode macroNode)
        {
            ListViewItem listViewItem = new ListViewItem
            {
                ImageIndex = (int)macroNode.state,
                Text = NodeSetter.NodeName(macroNode.state, false)
            };
            listViewItem.SubItems.Add(NodeSetter.NodeName(macroNode.state, true));
            listViewItem.SubItems.Add(macroNode.x.ToString() + ", " + macroNode.y.ToString());
            return listViewItem;
        }

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
        /// 이미지 리스트에 이미지 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog
            {
                Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg|비트맵|*.bmp",
                Multiselect = true
            };
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                foreach(string fileName in openImage.FileNames)
                {
                    using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))               
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                        using (Image tmp = Image.FromStream(memoryStream))
                        imgList.Add((Image)tmp.Clone());
                        listView_Image.Items.Add(new ListViewItem(fileName.Split('\\').Last()));
                    } 
                }     
            }
        }

        /// <summary>
        /// 이미지 리스트에서 이미지 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Image_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imgList.Count > 0 && listView_Image.SelectedIndices.Count > 0)
            {
                int iSelected = listView_Image.SelectedIndices[0];
                pictureBox_ImageArea.BackgroundImage = imgList[iSelected];
                originalSize = imgList[iSelected].Size;
                isImageLoad = true;
                label_ImageTitle.Text = listView_Image.Items[iSelected].Text;
            }
        }

        /// <summary>
        /// PictureBox의 선택 지점에 color색의 십자가를 그려주는 함수
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="color"></param>
        /// <param name="obj"></param>
        private void DrawCross(int X, int Y, Color color, PictureBox obj)
        {
            Graphics g;
            Pen myPen = new Pen(color, 2);
            g = obj.CreateGraphics();
            g.DrawRectangle(myPen, new Rectangle(X - 1, Y - 5, 1, 9));
            g.DrawRectangle(myPen, new Rectangle(X - 5, Y - 1, 9, 1));
        }

        private Point DownPoint = new Point(0,0);
        private bool isMouseDown = false;
        private MouseButtons CurMouseType;
        private List<MacroNode> NodeList = new List<MacroNode>();
        private void RemoveLastNode()
        {
            listView_WorkFlow.Items.RemoveAt(listView_WorkFlow.Items.Count - 1);
            Nodes.RemoveAt(Nodes.Count-1);
        }
        private void AddNodeLast(MacroNode macronode)
        {
            macronode.interval = 800;
            listView_WorkFlow.Items.Add(GenerateItem(macronode));
            Nodes.Add(macronode);
        }


        private void pictureBox_ImageArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isMouseDown && isImageLoad)
            {
                int X = (int)(e.Location.X * (originalWidth / pictureBox_ImageArea.Size.Width));
                int Y = (int)(e.Location.Y * (originalHeight / pictureBox_ImageArea.Size.Height));
                CurMouseType = e.Button;
                MacroNode newNode = new MacroNode
                {
                    state = NodeStates.마우스_이동,
                    x = X,
                    y = Y
                };
                listView_WorkFlow.Items.Add(GenerateItem(newNode));
                Nodes.Add(newNode);

                DownPoint = new Point(e.Location.X, e.Location.Y);
                pictureBox_ImageArea.Refresh();
                DrawCross(e.Location.X, e.Location.Y, Color.Red, (PictureBox)sender);
                isMouseDown = true;
            }
        }

        private void pictureBox_ImageArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (CurMouseType == e.Button && isImageLoad)
            {
                if (isDoubleClick)
                {
                    isDoubleClick = false;
                }
                else
                {
                    MacroNode newNode = new MacroNode();
                    int X = (int)(e.Location.X * (originalWidth / pictureBox_ImageArea.Size.Width));
                    int Y = (int)(e.Location.Y * (originalHeight / pictureBox_ImageArea.Size.Height));
                    if (DownPoint.Equals(new Point(e.Location.X, e.Location.Y)))
                    {
                        switch (e.Button)
                        {
                            case MouseButtons.Left:
                                RemoveLastNode();
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_이동_후_왼쪽클릭 ,x = X, y = Y});
                                break;

                            case MouseButtons.Right:
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_오른쪽클릭 });
                                break;

                            case MouseButtons.Middle:
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_휠클릭 });
                                break;
                        }
                    }
                    else
                    {                        
                        switch (e.Button)
                        {
                            case MouseButtons.Left:
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_누르기_왼쪽 });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_이동, x = X, y = Y });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_떼기_왼쪽 });
                                break;

                            case MouseButtons.Right:
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_누르기_오른쪽 });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_이동, x = X, y = Y });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_떼기_오른쪽 });
                                break;

                            case MouseButtons.Middle:
                                AddNodeLast(new MacroNode() { state = NodeStates.마우스_누르기_휠 });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_이동, x = X, y = Y });
                                AddNodeLast(new MacroNode { state = NodeStates.마우스_떼기_휠 });
                                break;
                        }
                        DrawCross(e.Location.X, e.Location.Y, Color.Aqua, (PictureBox)sender);
                    }
                    Console.WriteLine();
                }
                isMouseDown = false;
            }
        }              
        
        private void pictureBox_ImageArea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurMouseType == MouseButtons.Left)
            {
                int X = (int)(e.Location.X * (originalWidth / pictureBox_ImageArea.Size.Width));
                int Y = (int)(e.Location.Y * (originalHeight / pictureBox_ImageArea.Size.Height));
                RemoveLastNode();
                RemoveLastNode();
                AddNodeLast(new MacroNode { state = NodeStates.마우스_이동, x = X, y = Y });           

                AddNodeLast(new MacroNode() { state = NodeStates.마우스_더블클릭 });               
                isDoubleClick = true;
            } 
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isImageLoad)
                label_curPosition.Text = string.Format("({0}/{1}, {2}/{3})", (int)(e.Location.X * (originalWidth / pictureBox_ImageArea.Size.Width)), originalWidth, (int)(e.Location.Y * (originalHeight / pictureBox_ImageArea.Size.Height)), originalHeight);
        }
             
        private void button_AddWorkFlow_Click(object sender, EventArgs e)
        {
            AddWorkflow();
        }

        private void WorkflowEditorTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.Owner).ImageWorkflowEditorOn = false;
        }

        private void button_RemoveAll_Click(object sender, EventArgs e)
        {
            EndInsert();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_WorkFlow.SelectedIndices.Count > 0)
            {
                int offset = 0;
                foreach(int index in listView_WorkFlow.SelectedIndices)
                {
                    Nodes.RemoveAt(index - offset);
                    listView_WorkFlow.Items.RemoveAt(index - offset++);                    
                }                
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddWorkflow();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddWorkflow()
        {
            if (AddButtonClick == null)
            {
                return;
            }
            Invoke(AddButtonClick, null);
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PrefabsClose_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close_Hover;
        }

        private void btn_PrefabsClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Button_Close;
        }


    }
}
