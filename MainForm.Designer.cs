
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
            this.listView_Software = new System.Windows.Forms.ListView();
            this.txt_number_soft = new System.Windows.Forms.TextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_folder_path = new System.Windows.Forms.Label();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DeSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Software
            // 
            this.listView_Software.HideSelection = false;
            this.listView_Software.Location = new System.Drawing.Point(12, 67);
            this.listView_Software.Name = "listView_Software";
            this.listView_Software.Size = new System.Drawing.Size(662, 258);
            this.listView_Software.TabIndex = 0;
            this.listView_Software.UseCompatibleStateImageBehavior = false;
            // 
            // txt_number_soft
            // 
            this.txt_number_soft.Location = new System.Drawing.Point(478, 22);
            this.txt_number_soft.Name = "txt_number_soft";
            this.txt_number_soft.Size = new System.Drawing.Size(100, 20);
            this.txt_number_soft.TabIndex = 1;
            this.txt_number_soft.Text = "5";
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(584, 19);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(90, 25);
            this.btn_gen.TabIndex = 2;
            this.btn_gen.Text = "Gen";
            this.btn_gen.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 17);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_folder_path
            // 
            this.label_folder_path.AutoSize = true;
            this.label_folder_path.Location = new System.Drawing.Point(93, 26);
            this.label_folder_path.Name = "label_folder_path";
            this.label_folder_path.Size = new System.Drawing.Size(67, 13);
            this.label_folder_path.TabIndex = 5;
            this.label_folder_path.Text = "Folder\'s path";
            // 
            // listBox_Log
            // 
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.HorizontalScrollbar = true;
            this.listBox_Log.Location = new System.Drawing.Point(12, 331);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(662, 121);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 455);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.label_folder_path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.txt_number_soft);
            this.Controls.Add(this.listView_Software);
            this.Name = "MainForm";
            this.Text = "Monitor Software";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Software;
        private System.Windows.Forms.TextBox txt_number_soft;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_folder_path;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DeSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Restart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ClearLog;
    }
}

