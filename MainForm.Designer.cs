
namespace MornitorSoft
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "item1",
            "status",
            "Description 1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "item2",
            "status",
            "Description 2"}, -1);
            this.listView_Software = new System.Windows.Forms.ListView();
            this.columnHeader_SoftName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DeSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_soft_path = new System.Windows.Forms.TextBox();
            this.btnSoftPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label_folder_path = new System.Windows.Forms.Label();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_regex_software = new System.Windows.Forms.TextBox();
            this.btnSaveParam = new System.Windows.Forms.Button();
            this.btnLoadParam = new System.Windows.Forms.Button();
            this.listBox_Software = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Software
            // 
            this.listView_Software.CheckBoxes = true;
            this.listView_Software.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_SoftName,
            this.columnHeader_Status,
            this.columnHeader_Description});
            this.listView_Software.ContextMenuStrip = this.contextMenuStrip;
            this.listView_Software.FullRowSelect = true;
            this.listView_Software.GridLines = true;
            this.listView_Software.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Software.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.listView_Software.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView_Software.Location = new System.Drawing.Point(3, 3);
            this.listView_Software.Name = "listView_Software";
            this.listView_Software.Size = new System.Drawing.Size(817, 241);
            this.listView_Software.TabIndex = 0;
            this.listView_Software.UseCompatibleStateImageBehavior = false;
            this.listView_Software.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_SoftName
            // 
            this.columnHeader_SoftName.Text = "Name";
            this.columnHeader_SoftName.Width = 100;
            // 
            // columnHeader_Status
            // 
            this.columnHeader_Status.Text = "Status";
            this.columnHeader_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Status.Width = 100;
            // 
            // columnHeader_Description
            // 
            this.columnHeader_Description.Text = "Description";
            this.columnHeader_Description.Width = 400;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SelectAll,
            this.toolStripMenuItem_DeSelectAll,
            this.toolStripMenuItem_Restart,
            this.toolStripMenuItem_ClearLog});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 92);
            // 
            // toolStripMenuItem_SelectAll
            // 
            this.toolStripMenuItem_SelectAll.Name = "toolStripMenuItem_SelectAll";
            this.toolStripMenuItem_SelectAll.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem_SelectAll.Text = "Select All";
            // 
            // toolStripMenuItem_DeSelectAll
            // 
            this.toolStripMenuItem_DeSelectAll.Name = "toolStripMenuItem_DeSelectAll";
            this.toolStripMenuItem_DeSelectAll.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem_DeSelectAll.Text = "Deselect All";
            // 
            // toolStripMenuItem_Restart
            // 
            this.toolStripMenuItem_Restart.Name = "toolStripMenuItem_Restart";
            this.toolStripMenuItem_Restart.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem_Restart.Text = "Restart";
            // 
            // toolStripMenuItem_ClearLog
            // 
            this.toolStripMenuItem_ClearLog.Name = "toolStripMenuItem_ClearLog";
            this.toolStripMenuItem_ClearLog.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem_ClearLog.Text = "Clear Log";
            // 
            // txt_soft_path
            // 
            this.txt_soft_path.Location = new System.Drawing.Point(92, 54);
            this.txt_soft_path.Name = "txt_soft_path";
            this.txt_soft_path.Size = new System.Drawing.Size(589, 20);
            this.txt_soft_path.TabIndex = 1;
            this.txt_soft_path.Text = "D:\\MU_Server\\Server1\\GameDBServer\\GameDBServer.exe";
            // 
            // btnSoftPath
            // 
            this.btnSoftPath.Location = new System.Drawing.Point(8, 53);
            this.btnSoftPath.Name = "btnSoftPath";
            this.btnSoftPath.Size = new System.Drawing.Size(75, 23);
            this.btnSoftPath.TabIndex = 2;
            this.btnSoftPath.Text = "File";
            this.btnSoftPath.UseVisualStyleBackColor = true;
            this.btnSoftPath.Click += new System.EventHandler(this.button_click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(8, 21);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button_click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(708, 25);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Test Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button_click);
            // 
            // label_folder_path
            // 
            this.label_folder_path.AutoSize = true;
            this.label_folder_path.Location = new System.Drawing.Point(89, 27);
            this.label_folder_path.Name = "label_folder_path";
            this.label_folder_path.Size = new System.Drawing.Size(67, 13);
            this.label_folder_path.TabIndex = 5;
            this.label_folder_path.Text = "Folder\'s path";
            // 
            // listBox_Log
            // 
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.HorizontalScrollbar = true;
            this.listBox_Log.Location = new System.Drawing.Point(3, 250);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(817, 147);
            this.listBox_Log.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(708, 54);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Test Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button_click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(708, 83);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Test Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button_click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 428);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listView_Software);
            this.tabPage1.Controls.Add(this.listBox_Log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manager";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AsyncFile";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(823, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convert";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.listBox_Software);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.btnLoadParam);
            this.tabPage4.Controls.Add(this.btnSaveParam);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(823, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_folder_path);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.txt_regex_software);
            this.groupBox1.Controls.Add(this.txt_soft_path);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.btnSoftPath);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RegEx";
            // 
            // txt_regex_software
            // 
            this.txt_regex_software.Location = new System.Drawing.Point(92, 80);
            this.txt_regex_software.Name = "txt_regex_software";
            this.txt_regex_software.Size = new System.Drawing.Size(589, 20);
            this.txt_regex_software.TabIndex = 1;
            // 
            // btnSaveParam
            // 
            this.btnSaveParam.Location = new System.Drawing.Point(741, 373);
            this.btnSaveParam.Name = "btnSaveParam";
            this.btnSaveParam.Size = new System.Drawing.Size(75, 23);
            this.btnSaveParam.TabIndex = 2;
            this.btnSaveParam.Text = "Save";
            this.btnSaveParam.UseVisualStyleBackColor = true;
            this.btnSaveParam.Click += new System.EventHandler(this.button_click);
            // 
            // btnLoadParam
            // 
            this.btnLoadParam.Location = new System.Drawing.Point(660, 373);
            this.btnLoadParam.Name = "btnLoadParam";
            this.btnLoadParam.Size = new System.Drawing.Size(75, 23);
            this.btnLoadParam.TabIndex = 2;
            this.btnLoadParam.Text = "Load";
            this.btnLoadParam.UseVisualStyleBackColor = true;
            this.btnLoadParam.Click += new System.EventHandler(this.button_click);
            // 
            // listBox_Software
            // 
            this.listBox_Software.FormattingEnabled = true;
            this.listBox_Software.HorizontalScrollbar = true;
            this.listBox_Software.Location = new System.Drawing.Point(3, 145);
            this.listBox_Software.Name = "listBox_Software";
            this.listBox_Software.Size = new System.Drawing.Size(817, 147);
            this.listBox_Software.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Monitor Software";
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Software;
        private System.Windows.Forms.TextBox txt_soft_path;
        private System.Windows.Forms.Button btnSoftPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label_folder_path;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DeSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Restart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ClearLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ColumnHeader columnHeader_SoftName;
        private System.Windows.Forms.ColumnHeader columnHeader_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Description;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_regex_software;
        private System.Windows.Forms.Button btnSaveParam;
        private System.Windows.Forms.Button btnLoadParam;
        private System.Windows.Forms.ListBox listBox_Software;
    }
}

