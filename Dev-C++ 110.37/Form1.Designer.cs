namespace Dev_C___110._37
{
    partial class BaseForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.MainManu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_MakeNewProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Try = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Running = new System.Windows.Forms.ToolStripMenuItem();
            this.TOP_toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_File = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_openfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_fileOPE = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_make = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_run = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_runOPE = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_end = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip_bottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_CountLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CountLines_Val = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer_Hor = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Ver = new System.Windows.Forms.SplitContainer();
            this.tabControl_LeftBroad = new System.Windows.Forms.TabControl();
            this.tabPage_Project = new System.Windows.Forms.TabPage();
            this.tabPage_Figure = new System.Windows.Forms.TabPage();
            this.tabPage_Debugging = new System.Windows.Forms.TabPage();
            this.tabControl_WriteRigon = new System.Windows.Forms.TabControl();
            this.contextMenuStrip_TabpageWrite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_BottomBroad = new System.Windows.Forms.TabControl();
            this.CompileOutput = new System.Windows.Forms.TabPage();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.MainManu.SuspendLayout();
            this.TOP_toolStrip.SuspendLayout();
            this.statusStrip_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Hor)).BeginInit();
            this.splitContainer_Hor.Panel1.SuspendLayout();
            this.splitContainer_Hor.Panel2.SuspendLayout();
            this.splitContainer_Hor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ver)).BeginInit();
            this.splitContainer_Ver.Panel1.SuspendLayout();
            this.splitContainer_Ver.Panel2.SuspendLayout();
            this.splitContainer_Ver.SuspendLayout();
            this.tabControl_LeftBroad.SuspendLayout();
            this.contextMenuStrip_TabpageWrite.SuspendLayout();
            this.tabControl_BottomBroad.SuspendLayout();
            this.CompileOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainManu
            // 
            this.MainManu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainManu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainManu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Run});
            this.MainManu.Location = new System.Drawing.Point(0, 0);
            this.MainManu.Name = "MainManu";
            this.MainManu.Size = new System.Drawing.Size(1132, 32);
            this.MainManu.TabIndex = 0;
            this.MainManu.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_MakeNewProgram,
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_Save});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(84, 28);
            this.ToolStripMenuItem_File.Text = "文件(F)";
            // 
            // ToolStripMenuItem_MakeNewProgram
            // 
            this.ToolStripMenuItem_MakeNewProgram.Name = "ToolStripMenuItem_MakeNewProgram";
            this.ToolStripMenuItem_MakeNewProgram.Size = new System.Drawing.Size(263, 34);
            this.ToolStripMenuItem_MakeNewProgram.Text = "新建源代码(N)";
            this.ToolStripMenuItem_MakeNewProgram.Click += new System.EventHandler(this.ToolStripMenuItem_MakeNewProgram_Click);
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(263, 34);
            this.ToolStripMenuItem_OpenFile.Text = "打开文件或项目(O)";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_OpenFile_Click);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(263, 34);
            this.ToolStripMenuItem_Save.Text = "保存(S)";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(84, 28);
            this.ToolStripMenuItem_Edit.Text = "编辑(E)";
            // 
            // ToolStripMenuItem_Run
            // 
            this.ToolStripMenuItem_Run.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Try,
            this.ToolStripMenuItem_Running});
            this.ToolStripMenuItem_Run.Name = "ToolStripMenuItem_Run";
            this.ToolStripMenuItem_Run.Size = new System.Drawing.Size(86, 28);
            this.ToolStripMenuItem_Run.Text = "运行(R)";
            // 
            // ToolStripMenuItem_Try
            // 
            this.ToolStripMenuItem_Try.Name = "ToolStripMenuItem_Try";
            this.ToolStripMenuItem_Try.Size = new System.Drawing.Size(170, 34);
            this.ToolStripMenuItem_Try.Text = "编译(C)";
            this.ToolStripMenuItem_Try.Click += new System.EventHandler(this.ToolStripMenuItem_Try_Click);
            // 
            // ToolStripMenuItem_Running
            // 
            this.ToolStripMenuItem_Running.Name = "ToolStripMenuItem_Running";
            this.ToolStripMenuItem_Running.Size = new System.Drawing.Size(170, 34);
            this.ToolStripMenuItem_Running.Text = "运行(R)";
            this.ToolStripMenuItem_Running.Click += new System.EventHandler(this.ToolStripMenuItem_Running_Click);
            // 
            // TOP_toolStrip
            // 
            this.TOP_toolStrip.AutoSize = false;
            this.TOP_toolStrip.BackColor = System.Drawing.Color.White;
            this.TOP_toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TOP_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_File,
            this.toolStripButton_openfile,
            this.toolStripButton_close,
            this.toolStripSeparator_fileOPE,
            this.toolStripButton_save,
            this.toolStripButton_make,
            this.toolStripButton_run,
            this.toolStripSeparator_runOPE,
            this.toolStripButton_help,
            this.toolStripSeparator_end});
            this.TOP_toolStrip.Location = new System.Drawing.Point(0, 32);
            this.TOP_toolStrip.Name = "TOP_toolStrip";
            this.TOP_toolStrip.Size = new System.Drawing.Size(1132, 73);
            this.TOP_toolStrip.TabIndex = 1;
            this.TOP_toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_File
            // 
            this.toolStripButton_File.AutoSize = false;
            this.toolStripButton_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_File.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_File.Image")));
            this.toolStripButton_File.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_File.Name = "toolStripButton_File";
            this.toolStripButton_File.Size = new System.Drawing.Size(60, 75);
            this.toolStripButton_File.Text = "新建源代码";
            this.toolStripButton_File.Click += new System.EventHandler(this.toolStripButton_File_Click);
            // 
            // toolStripButton_openfile
            // 
            this.toolStripButton_openfile.AutoSize = false;
            this.toolStripButton_openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_openfile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openfile.Image")));
            this.toolStripButton_openfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openfile.Name = "toolStripButton_openfile";
            this.toolStripButton_openfile.Size = new System.Drawing.Size(60, 75);
            this.toolStripButton_openfile.Text = "打开文件或项目";
            this.toolStripButton_openfile.Click += new System.EventHandler(this.toolStripButton_openbook_Click);
            // 
            // toolStripButton_close
            // 
            this.toolStripButton_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_close.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_close.Image")));
            this.toolStripButton_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_close.Name = "toolStripButton_close";
            this.toolStripButton_close.Size = new System.Drawing.Size(44, 68);
            this.toolStripButton_close.Text = "关闭";
            this.toolStripButton_close.Click += new System.EventHandler(this.toolStripButton_close_Click);
            // 
            // toolStripSeparator_fileOPE
            // 
            this.toolStripSeparator_fileOPE.Name = "toolStripSeparator_fileOPE";
            this.toolStripSeparator_fileOPE.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.AutoSize = false;
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(60, 75);
            this.toolStripButton_save.Text = "保存";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // toolStripButton_make
            // 
            this.toolStripButton_make.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_make.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_make.Image")));
            this.toolStripButton_make.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_make.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_make.Name = "toolStripButton_make";
            this.toolStripButton_make.Size = new System.Drawing.Size(44, 68);
            this.toolStripButton_make.Text = "编译";
            this.toolStripButton_make.Click += new System.EventHandler(this.toolStripButton_make_Click);
            // 
            // toolStripButton_run
            // 
            this.toolStripButton_run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_run.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_run.Image")));
            this.toolStripButton_run.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_run.Name = "toolStripButton_run";
            this.toolStripButton_run.Size = new System.Drawing.Size(44, 68);
            this.toolStripButton_run.Text = "运行";
            this.toolStripButton_run.Click += new System.EventHandler(this.toolStripButton_run_Click);
            // 
            // toolStripSeparator_runOPE
            // 
            this.toolStripSeparator_runOPE.Name = "toolStripSeparator_runOPE";
            this.toolStripSeparator_runOPE.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButton_help
            // 
            this.toolStripButton_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_help.Image")));
            this.toolStripButton_help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_help.Name = "toolStripButton_help";
            this.toolStripButton_help.Size = new System.Drawing.Size(44, 68);
            this.toolStripButton_help.Text = "帮助";
            this.toolStripButton_help.Click += new System.EventHandler(this.toolStripButton_help_Click);
            // 
            // toolStripSeparator_end
            // 
            this.toolStripSeparator_end.Name = "toolStripSeparator_end";
            this.toolStripSeparator_end.Size = new System.Drawing.Size(6, 73);
            // 
            // statusStrip_bottom
            // 
            this.statusStrip_bottom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_CountLines,
            this.toolStripStatusLabel_CountLines_Val});
            this.statusStrip_bottom.Location = new System.Drawing.Point(0, 610);
            this.statusStrip_bottom.Name = "statusStrip_bottom";
            this.statusStrip_bottom.Size = new System.Drawing.Size(1132, 31);
            this.statusStrip_bottom.TabIndex = 2;
            this.statusStrip_bottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_CountLines
            // 
            this.toolStripStatusLabel_CountLines.Name = "toolStripStatusLabel_CountLines";
            this.toolStripStatusLabel_CountLines.Size = new System.Drawing.Size(73, 24);
            this.toolStripStatusLabel_CountLines.Text = "总行数 :";
            // 
            // toolStripStatusLabel_CountLines_Val
            // 
            this.toolStripStatusLabel_CountLines_Val.Name = "toolStripStatusLabel_CountLines_Val";
            this.toolStripStatusLabel_CountLines_Val.Size = new System.Drawing.Size(21, 24);
            this.toolStripStatusLabel_CountLines_Val.Text = "0";
            // 
            // splitContainer_Hor
            // 
            this.splitContainer_Hor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer_Hor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Hor.Location = new System.Drawing.Point(0, 105);
            this.splitContainer_Hor.Name = "splitContainer_Hor";
            this.splitContainer_Hor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Hor.Panel1
            // 
            this.splitContainer_Hor.Panel1.Controls.Add(this.splitContainer_Ver);
            // 
            // splitContainer_Hor.Panel2
            // 
            this.splitContainer_Hor.Panel2.Controls.Add(this.tabControl_BottomBroad);
            this.splitContainer_Hor.Size = new System.Drawing.Size(1132, 505);
            this.splitContainer_Hor.SplitterDistance = 356;
            this.splitContainer_Hor.TabIndex = 3;
            // 
            // splitContainer_Ver
            // 
            this.splitContainer_Ver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Ver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ver.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ver.Name = "splitContainer_Ver";
            // 
            // splitContainer_Ver.Panel1
            // 
            this.splitContainer_Ver.Panel1.Controls.Add(this.tabControl_LeftBroad);
            // 
            // splitContainer_Ver.Panel2
            // 
            this.splitContainer_Ver.Panel2.Controls.Add(this.tabControl_WriteRigon);
            this.splitContainer_Ver.Size = new System.Drawing.Size(1132, 356);
            this.splitContainer_Ver.SplitterDistance = 152;
            this.splitContainer_Ver.TabIndex = 0;
            // 
            // tabControl_LeftBroad
            // 
            this.tabControl_LeftBroad.Controls.Add(this.tabPage_Project);
            this.tabControl_LeftBroad.Controls.Add(this.tabPage_Figure);
            this.tabControl_LeftBroad.Controls.Add(this.tabPage_Debugging);
            this.tabControl_LeftBroad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_LeftBroad.Location = new System.Drawing.Point(0, 0);
            this.tabControl_LeftBroad.Name = "tabControl_LeftBroad";
            this.tabControl_LeftBroad.SelectedIndex = 0;
            this.tabControl_LeftBroad.Size = new System.Drawing.Size(148, 352);
            this.tabControl_LeftBroad.TabIndex = 0;
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Project.Size = new System.Drawing.Size(140, 320);
            this.tabPage_Project.TabIndex = 0;
            this.tabPage_Project.Text = "项目";
            this.tabPage_Project.UseVisualStyleBackColor = true;
            // 
            // tabPage_Figure
            // 
            this.tabPage_Figure.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Figure.Name = "tabPage_Figure";
            this.tabPage_Figure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Figure.Size = new System.Drawing.Size(140, 320);
            this.tabPage_Figure.TabIndex = 1;
            this.tabPage_Figure.Text = "符号";
            this.tabPage_Figure.UseVisualStyleBackColor = true;
            // 
            // tabPage_Debugging
            // 
            this.tabPage_Debugging.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Debugging.Name = "tabPage_Debugging";
            this.tabPage_Debugging.Size = new System.Drawing.Size(140, 320);
            this.tabPage_Debugging.TabIndex = 2;
            this.tabPage_Debugging.Text = "调试";
            this.tabPage_Debugging.UseVisualStyleBackColor = true;
            // 
            // tabControl_WriteRigon
            // 
            this.tabControl_WriteRigon.ContextMenuStrip = this.contextMenuStrip_TabpageWrite;
            this.tabControl_WriteRigon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_WriteRigon.Location = new System.Drawing.Point(0, 0);
            this.tabControl_WriteRigon.Name = "tabControl_WriteRigon";
            this.tabControl_WriteRigon.SelectedIndex = 0;
            this.tabControl_WriteRigon.Size = new System.Drawing.Size(972, 352);
            this.tabControl_WriteRigon.TabIndex = 0;
            this.tabControl_WriteRigon.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_WriteRigon_Selected);
            // 
            // contextMenuStrip_TabpageWrite
            // 
            this.contextMenuStrip_TabpageWrite.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_TabpageWrite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_close});
            this.contextMenuStrip_TabpageWrite.Name = "contextMenuStrip_TabpageWrite";
            this.contextMenuStrip_TabpageWrite.Size = new System.Drawing.Size(117, 34);
            // 
            // ToolStripMenuItem_close
            // 
            this.ToolStripMenuItem_close.Name = "ToolStripMenuItem_close";
            this.ToolStripMenuItem_close.Size = new System.Drawing.Size(116, 30);
            this.ToolStripMenuItem_close.Text = "关闭";
            // 
            // tabControl_BottomBroad
            // 
            this.tabControl_BottomBroad.Controls.Add(this.CompileOutput);
            this.tabControl_BottomBroad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_BottomBroad.Location = new System.Drawing.Point(0, 0);
            this.tabControl_BottomBroad.Name = "tabControl_BottomBroad";
            this.tabControl_BottomBroad.SelectedIndex = 0;
            this.tabControl_BottomBroad.Size = new System.Drawing.Size(1132, 145);
            this.tabControl_BottomBroad.TabIndex = 0;
            // 
            // CompileOutput
            // 
            this.CompileOutput.Controls.Add(this.richTextBoxOutput);
            this.CompileOutput.Location = new System.Drawing.Point(4, 28);
            this.CompileOutput.Name = "CompileOutput";
            this.CompileOutput.Padding = new System.Windows.Forms.Padding(3);
            this.CompileOutput.Size = new System.Drawing.Size(1124, 113);
            this.CompileOutput.TabIndex = 0;
            this.CompileOutput.Text = "编译信息";
            this.CompileOutput.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.AcceptsTab = true;
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(1118, 107);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 641);
            this.Controls.Add(this.splitContainer_Hor);
            this.Controls.Add(this.statusStrip_bottom);
            this.Controls.Add(this.TOP_toolStrip);
            this.Controls.Add(this.MainManu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainManu;
            this.Name = "BaseForm";
            this.Text = "Dev-C++ 110.37";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.MainManu.ResumeLayout(false);
            this.MainManu.PerformLayout();
            this.TOP_toolStrip.ResumeLayout(false);
            this.TOP_toolStrip.PerformLayout();
            this.statusStrip_bottom.ResumeLayout(false);
            this.statusStrip_bottom.PerformLayout();
            this.splitContainer_Hor.Panel1.ResumeLayout(false);
            this.splitContainer_Hor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Hor)).EndInit();
            this.splitContainer_Hor.ResumeLayout(false);
            this.splitContainer_Ver.Panel1.ResumeLayout(false);
            this.splitContainer_Ver.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ver)).EndInit();
            this.splitContainer_Ver.ResumeLayout(false);
            this.tabControl_LeftBroad.ResumeLayout(false);
            this.contextMenuStrip_TabpageWrite.ResumeLayout(false);
            this.tabControl_BottomBroad.ResumeLayout(false);
            this.CompileOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainManu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStrip TOP_toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_File;
        private System.Windows.Forms.StatusStrip statusStrip_bottom;
        private System.Windows.Forms.SplitContainer splitContainer_Hor;
        private System.Windows.Forms.SplitContainer splitContainer_Ver;
        private System.Windows.Forms.TabControl tabControl_LeftBroad;
        private System.Windows.Forms.TabPage tabPage_Project;
        private System.Windows.Forms.TabPage tabPage_Figure;
        private System.Windows.Forms.TabControl tabControl_WriteRigon;
        private System.Windows.Forms.TabControl tabControl_BottomBroad;
        private System.Windows.Forms.TabPage CompileOutput;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_MakeNewProgram;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_openfile;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Run;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Try;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Running;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TabPage tabPage_Debugging;
        private System.Windows.Forms.ToolStripButton toolStripButton_make;
        private System.Windows.Forms.ToolStripButton toolStripButton_run;
        private System.Windows.Forms.ToolStripButton toolStripButton_close;
        private System.Windows.Forms.ToolStripButton toolStripButton_help;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_TabpageWrite;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_fileOPE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_runOPE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_end;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CountLines;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CountLines_Val;
    }
}

