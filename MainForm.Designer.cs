
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
            this.listView_software = new System.Windows.Forms.ListView();
            this.txt_number_soft = new System.Windows.Forms.TextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_software
            // 
            this.listView_software.HideSelection = false;
            this.listView_software.Location = new System.Drawing.Point(12, 67);
            this.listView_software.Name = "listView_software";
            this.listView_software.Size = new System.Drawing.Size(607, 384);
            this.listView_software.TabIndex = 0;
            this.listView_software.UseCompatibleStateImageBehavior = false;
            // 
            // txt_number_soft
            // 
            this.txt_number_soft.Location = new System.Drawing.Point(635, 67);
            this.txt_number_soft.Name = "txt_number_soft";
            this.txt_number_soft.Size = new System.Drawing.Size(100, 20);
            this.txt_number_soft.TabIndex = 1;
            this.txt_number_soft.Text = "5";
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(635, 105);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(100, 25);
            this.btn_gen.TabIndex = 2;
            this.btn_gen.Text = "Gen";
            this.btn_gen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 455);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.txt_number_soft);
            this.Controls.Add(this.listView_software);
            this.Name = "MainForm";
            this.Text = "Monitor Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_software;
        private System.Windows.Forms.TextBox txt_number_soft;
        private System.Windows.Forms.Button btn_gen;
    }
}

