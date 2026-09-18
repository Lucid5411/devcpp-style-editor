using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_C___110._37
{
    public partial class BaseForm : Form
    {
        const int MAXLIM = 11037;
        int PagesCount = 0;
        string[] PagesPath = new string[MAXLIM];
        string[]PagesText=new string[MAXLIM];
        int[,] NowPageBracket = new int[MAXLIM,2];
        int[] NumOfBracket = new int[MAXLIM];
        [DllImport("user32.dll ", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
        private void Textbox_WhenTextChange(object sender, EventArgs e)
        {
            if (tabControl_WriteRigon.SelectedTab.Controls[0].Text != PagesText[tabControl_WriteRigon.SelectedIndex])
                tabControl_WriteRigon.SelectedTab.Text = "[*]" + tabControl_WriteRigon.SelectedTab.Name;
            else
                tabControl_WriteRigon.SelectedTab.Text = tabControl_WriteRigon.SelectedTab.Name;
            if(tabControl_WriteRigon.SelectedTab!=null)
            {
                RichTextBox richtextbox = (RichTextBox)tabControl_WriteRigon.SelectedTab.Controls[0];
                toolStripStatusLabel_CountLines_Val.Text= (richtextbox.GetLineFromCharIndex(richtextbox.TextLength)+1).ToString();
            }
        }
        private void tabControl_WriteRigon_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl_WriteRigon.SelectedTab!=null)
            {
                RichTextBox richtextbox = (RichTextBox)tabControl_WriteRigon.SelectedTab.Controls[0];
                toolStripStatusLabel_CountLines_Val.Text = (richtextbox.GetLineFromCharIndex(richtextbox.TextLength) + 1).ToString();
            }
            else
                toolStripStatusLabel_CountLines_Val.Text ="0";
        }
        void NowPage_BracketMakePair()
        {
            int NumTOT_Bracket = 0;
            Stack<int>HalfBracket = new Stack<int>();
            string text = tabControl_WriteRigon.SelectedTab.Controls[0].Text;
            for(int i=0;i<text.Length;i++) 
            {
                if (text[i] == '{')
                {
                    NumTOT_Bracket++;
                    NumOfBracket[NumTOT_Bracket] = i;
                    HalfBracket.Push(NumTOT_Bracket);
                }
                else if(text[i] == '}')
                {
                    if(HalfBracket.Count>0)
                    {
                        NumTOT_Bracket++;
                        NumOfBracket[NumTOT_Bracket] = i;
                        int NowLeftBracket = HalfBracket.Pop();
                        NowPageBracket[NumTOT_Bracket, 0] = NowLeftBracket;
                        NowPageBracket[NumTOT_Bracket, 1] = HalfBracket.Count;
                        NowPageBracket[NowLeftBracket, 0] = NumTOT_Bracket;
                        NowPageBracket[NowLeftBracket, 1] = HalfBracket.Count;
                    }
                    else
                    {
                        NowPageBracket[NumTOT_Bracket, 0] = -1;
                        NowPageBracket[NumTOT_Bracket, 1] = HalfBracket.Count;
                    }
                }
            }
            while (HalfBracket.Count > 0)
            {
                int NowLeftBracket = HalfBracket.Pop();
                NowPageBracket[NowLeftBracket, 0] = -1;
                NowPageBracket[NumTOT_Bracket, 1] = HalfBracket.Count;
            }
        }
        private void Textbox_BracketPair(object sender, KeyPressEventArgs e)
        {
            RichTextBox now_richtextbox = (RichTextBox)tabControl_WriteRigon.SelectedTab.Controls[0];
            int dis = now_richtextbox.SelectionStart;
            if (e.KeyChar == '{')
            {
                now_richtextbox.Text += "}";
                now_richtextbox.SelectionStart = dis;
                NowPage_BracketMakePair();
            }
            else if (e.KeyChar == '}')
            {
                if (dis-1>=0&&now_richtextbox.Text[dis - 1] == '{' && now_richtextbox.Text[dis] == '}')
                {
                    e.Handled = true;
                    ((RichTextBox)tabControl_WriteRigon.SelectedTab.Controls[0]).SelectionStart=dis+1;
                }
                NowPage_BracketMakePair();
            }
        }
        private void CreateNewPage()
        {
            TabPage tabpage = new TabPage();
            RichTextBox textbox = new RichTextBox(); 
            textbox.Dock = DockStyle.Fill;
            textbox.Multiline = true;
            textbox.AcceptsTab = true;
            textbox.ContextMenuStrip = contextMenuStrip_TabpageWrite;
            textbox.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            textbox.TextChanged += new EventHandler(Textbox_WhenTextChange);
            textbox.KeyPress += new KeyPressEventHandler(Textbox_BracketPair);
            PagesCount++;
            tabpage.Text = "NewFile" + PagesCount.ToString();
            tabpage.Name = "NewFile" + PagesCount.ToString();
            tabpage.Controls.Add(textbox);
            tabControl_WriteRigon.Controls.Add(tabpage);
            tabControl_WriteRigon.SelectedTab = tabpage;
        }
        private void OpenMyFile()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "all files(*.*)|*.*";
            openfiledialog.FilterIndex = 1;
            openfiledialog.RestoreDirectory = false;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string GetPath = openfiledialog.FileName;
                if (tabControl_WriteRigon.SelectedTab == null)
                {
                    TabPage tabpage = new TabPage();
                    RichTextBox textbox = new RichTextBox();
                    textbox.Dock = DockStyle.Fill;
                    textbox.Multiline = true;
                    textbox.AcceptsTab = true;
                    textbox.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
                    textbox.ContextMenuStrip = contextMenuStrip_TabpageWrite;
                    textbox.TextChanged += new EventHandler(Textbox_WhenTextChange);
                    textbox.KeyPress += new KeyPressEventHandler(Textbox_BracketPair);
                    textbox.Text = File.ReadAllText(GetPath);
                    tabpage.Text = Path.GetFileNameWithoutExtension(GetPath);
                    tabpage.Name = tabpage.Text;
                    tabpage.Controls.Add(textbox);
                    tabControl_WriteRigon.Controls.Add(tabpage);
                    tabControl_WriteRigon.SelectedTab = tabpage;
                }
                else
                {
                    tabControl_WriteRigon.SelectedTab.Controls[0].Text = File.ReadAllText(GetPath);
                    tabControl_WriteRigon.SelectedTab.Text = Path.GetFileNameWithoutExtension(GetPath);
                    tabControl_WriteRigon.SelectedTab.Name = tabControl_WriteRigon.SelectedTab.Text;
                }
                PagesPath[tabControl_WriteRigon.SelectedIndex] = GetPath;
                PagesText[tabControl_WriteRigon.SelectedIndex] = tabControl_WriteRigon.SelectedTab.Controls[0].Text;
            }
        }
        private bool SaveSelectPage()
        {
            if (tabControl_WriteRigon.SelectedTab != null)
            {
                if (PagesPath[tabControl_WriteRigon.SelectedIndex] == null)
                {
                    SaveFileDialog savefiledialog = new SaveFileDialog();
                    string GetText = tabControl_WriteRigon.SelectedTab.Controls[0].Text;
                    savefiledialog.FileName = tabControl_WriteRigon.SelectedTab.Name + ".cpp";
                    savefiledialog.Filter = "all files(*.*)|*.*";
                    savefiledialog.FilterIndex = 1;
                    savefiledialog.RestoreDirectory = false;
                    if (savefiledialog.ShowDialog() == DialogResult.OK)
                    {
                        string GetPath = savefiledialog.FileName;
                        PagesPath[tabControl_WriteRigon.SelectedIndex] = GetPath;
                        PagesText[tabControl_WriteRigon.SelectedIndex] = GetText;
                        File.WriteAllText(GetPath, GetText);
                    }
                    else
                        return false;
                }
                else
                {
                    string GetPath = PagesPath[tabControl_WriteRigon.SelectedIndex];
                    string GetText = tabControl_WriteRigon.SelectedTab.Controls[0].Text;
                    File.WriteAllText(GetPath, GetText);
                    PagesText[tabControl_WriteRigon.SelectedIndex] = GetText;
                }
            }
            else
                return false;
            tabControl_WriteRigon.SelectedTab.Text = tabControl_WriteRigon.SelectedTab.Name;
            return true;
        }
        private string Get_Compile_Output()
        {
            if (PagesText[tabControl_WriteRigon.SelectedIndex] != tabControl_WriteRigon.SelectedTab.Controls[0].Text)
                if (SaveSelectPage() == false)
                    return "\n编译失败。原因：\n取消编译。\n";
            if (PagesPath[tabControl_WriteRigon.SelectedIndex]!=null)
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                string FullName = PagesPath[tabControl_WriteRigon.SelectedIndex];
                string PrePath;
                int idx = FullName.Length - 1;
                while (FullName[idx] != '.')
                    idx--;
                PrePath = FullName.Substring(0, idx);
                p.StartInfo.FileName = "g++.exe";
                p.StartInfo.Arguments = FullName + " -g -o" + PrePath;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string outputError = p.StandardError.ReadToEnd();
                if (outputError == "")
                    return "\n编译成功！\n";
                else
                    return "\n编译失败。原因：\n"+outputError+"\n";
            }
            return null;
        }
        private string Get_Run_Output()
        {
            string GetError = Get_Compile_Output();
            if (GetError == "\n编译成功！\n")
            {
                string FullName = PagesPath[tabControl_WriteRigon.SelectedIndex];
                string PrePath, GetText, PauseText;
                int MainIndex, LeftHalf;
                int idx = FullName.Length - 1;
                GetText = tabControl_WriteRigon.SelectedTab.Controls[0].Text;
                MainIndex = GetText.IndexOf(" main(");
                if (MainIndex == -1)
                    MainIndex = GetText.IndexOf(" main ");
                while (GetText[MainIndex] != '{')
                    MainIndex++;
                MainIndex++;
                LeftHalf = 1;
                for (; MainIndex < GetText.Length; MainIndex++)
                {
                    if (GetText[MainIndex] == '{')
                        LeftHalf++;
                    else if (GetText[MainIndex] == '}')
                        LeftHalf--;
                    if (LeftHalf == 0)
                        break;
                }
                PauseText = GetText.Substring(0, MainIndex) + "\ngetchar(),getchar();\n" + GetText.Substring(MainIndex, GetText.Length - MainIndex);
                File.WriteAllText(FullName, PauseText);
                Get_Compile_Output();
                while (FullName[idx] != '.')
                    idx--;
                PrePath = FullName.Substring(0, idx);
                Process RunProcess = new Process();
                RunProcess.StartInfo.FileName = PrePath + ".exe";
                RunProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                RunProcess.Start();
                System.Threading.Thread.Sleep(1000);//100如果效果没有就继续加大
                ShowWindow(RunProcess.MainWindowHandle, 5);
                File.WriteAllText(FullName, GetText);
            }
            else
                return null;
            return null;
        }
        public BaseForm()
        {
            InitializeComponent();
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            CreateNewPage();
            for (int i = 0; i < MAXLIM; i++)
                PagesText[i] = "";
        }
        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveSelectPage();
        }
        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            SaveSelectPage();
        }
        private void ToolStripMenuItem_OpenFile_Click(object sender, EventArgs e)
        {
            OpenMyFile();
        }
        private void toolStripButton_openbook_Click(object sender, EventArgs e)
        {
            OpenMyFile();
        }
        private void ToolStripMenuItem_MakeNewProgram_Click(object sender, EventArgs e)
        {
            CreateNewPage();
        }
        private void toolStripButton_File_Click(object sender, EventArgs e)
        {
            CreateNewPage();
        }
        private void ToolStripMenuItem_Try_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text+= Get_Compile_Output();
            richTextBoxOutput.Focus();
            richTextBoxOutput.Select(richTextBoxOutput.TextLength, 0);
            richTextBoxOutput.ScrollToCaret();
        }
        private void toolStripButton_make_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text += Get_Compile_Output();
            richTextBoxOutput.Focus();
            richTextBoxOutput.Select(richTextBoxOutput.TextLength,0);
            richTextBoxOutput.ScrollToCaret();
        }
        private void ToolStripMenuItem_Running_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text += Get_Run_Output();
            richTextBoxOutput.Focus();
            richTextBoxOutput.Select(richTextBoxOutput.TextLength, 0);
            richTextBoxOutput.ScrollToCaret();
        }
        private void toolStripButton_run_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text += Get_Run_Output();
            richTextBoxOutput.Focus();
            richTextBoxOutput.Select(richTextBoxOutput.TextLength, 0);
            richTextBoxOutput.ScrollToCaret();
        }
        private void toolStripButton_close_Click(object sender, EventArgs e)
        {
            if (tabControl_WriteRigon.TabPages.Count>0)
            {
                for (int i = tabControl_WriteRigon.SelectedIndex + 1; i < tabControl_WriteRigon.TabCount; i++)
                {
                    PagesPath[i - 1] = PagesPath[i];
                    PagesText[i - 1] = PagesText[i];
                }
                tabControl_WriteRigon.TabPages.Remove(tabControl_WriteRigon.SelectedTab);
            }
        }
        private void toolStripButton_help_Click(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            richTextBoxOutput.Text += "哦弄！";
        }
    }
}