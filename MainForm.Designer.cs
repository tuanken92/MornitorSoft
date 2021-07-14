
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "item1",
            "status",
            "Description 1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "item2",
            "status",
            "Description 2"}, -1);
            this.listView_Software = new System.Windows.Forms.ListView();
            this.txt_soft_path = new System.Windows.Forms.TextBox();
            this.btnSoftPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label_folder_path = new System.Windows.Forms.Label();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DeSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.columnHeader_SoftName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip.SuspendLayout();
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
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView_Software.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_Software.Location = new System.Drawing.Point(12, 67);
            this.listView_Software.Name = "listView_Software";
            this.listView_Software.Size = new System.Drawing.Size(662, 218);
            this.listView_Software.TabIndex = 0;
            this.listView_Software.UseCompatibleStateImageBehavior = false;
            this.listView_Software.View = System.Windows.Forms.View.Details;
            // 
            // txt_soft_path
            // 
            this.txt_soft_path.Location = new System.Drawing.Point(96, 41);
            this.txt_soft_path.Name = "txt_soft_path";
            this.txt_soft_path.Size = new System.Drawing.Size(578, 20);
            this.txt_soft_path.TabIndex = 1;
            this.txt_soft_path.Text = "D:\\MU_Server\\Server1\\GameDBServer\\GameDBServer.exe";
            // 
            // btnSoftPath
            // 
            this.btnSoftPath.Location = new System.Drawing.Point(12, 40);
            this.btnSoftPath.Name = "btnSoftPath";
            this.btnSoftPath.Size = new System.Drawing.Size(75, 23);
            this.btnSoftPath.TabIndex = 2;
            this.btnSoftPath.Text = "File";
            this.btnSoftPath.UseVisualStyleBackColor = true;
            this.btnSoftPath.Click += new System.EventHandler(this.button_click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 11);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button_click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(700, 67);
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
            this.label_folder_path.Location = new System.Drawing.Point(93, 17);
            this.label_folder_path.Name = "label_folder_path";
            this.label_folder_path.Size = new System.Drawing.Size(67, 13);
            this.label_folder_path.TabIndex = 5;
            this.label_folder_path.Text = "Folder\'s path";
            // 
            // listBox_Log
            // 
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.HorizontalScrollbar = true;
            this.listBox_Log.Location = new System.Drawing.Point(12, 292);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(662, 160);
            this.listBox_Log.TabIndex = 6;
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
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(700, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Test Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button_click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(700, 125);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Test Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button_click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(700, 429);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClear_log);
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
            this.columnHeader_Description.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 455);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.label_folder_path);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnSoftPath);
            this.Controls.Add(this.txt_soft_path);
            this.Controls.Add(this.listView_Software);
            this.Name = "MainForm";
            this.Text = "Monitor Software";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ColumnHeader columnHeader_SoftName;
        private System.Windows.Forms.ColumnHeader columnHeader_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Description;
    }
}

