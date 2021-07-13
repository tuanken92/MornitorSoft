using MornitorSoft.MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MornitorSoft
{
    public partial class MainForm : Form
    {

        List<string> list_files_exe;
        string folder_path;

        

        public MainForm()
        {
            InitializeComponent();
            Init_Variables();
            Init_GUI();
        }

        private void Init_GUI()
        {

            listView_Software.BackColor = Color.Beige;
            listBox_Log.BackColor = Color.Beige;
            listBox_Log.DrawMode = DrawMode.OwnerDrawFixed;
            listBox_Log.DrawItem += ListBox_Log_DrawItem;
            //listBox_Log.DataSource = list_files_exe;
            

        }

        

        void Init_Variables()
        {
            list_files_exe = new List<string>();
            folder_path = @"C:\Windows\System32";

            //list_files_exe = MyDefine.Filter_Software_Type(MyDefine.Get_All_File_In_Folder(folder_path), ".exe", true);
        }

        private void button_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Console.WriteLine(button.Name);
            switch(button.Name)
            {
                case "btnSelectFolder":
                    using (var fbd = new FolderBrowserDialog())
                    {
                        fbd.Description = "Select Folder";
                        fbd.RootFolder = Environment.SpecialFolder.Windows;
                        
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            folder_path = fbd.SelectedPath;
                            label_folder_path.Text = folder_path;


                            list_files_exe = MyDefine.Filter_Software_Type(MyDefine.Get_All_File_In_Folder(folder_path), ".exe", true);
                            foreach(var file_exe in list_files_exe)
                            {
                                Add_Log(file_exe);
                            }
                        }
                        else
                        {
                            label_folder_path.Text = "Not yet select folder";
                        }
                    }
                    break;
            }
        }

        private delegate void SafeCallDelegate3(String text, Color? color = null, eListBox lb = eListBox.LB_HEARTBEAT);
        void Add_Log(String text, Color? color = null, eListBox lb = eListBox.LB_HEARTBEAT)
        {
            if (listBox_Log.InvokeRequired)
            {
                var d = new SafeCallDelegate3(Add_Log);
                listBox_Log.Invoke(d, new object[] { text, color, lb });
            }
            else
            {

                text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ":\t" + text;
                ColoredItem coloredItem = new ColoredItem { Color = color ?? Color.Green, Text = text };
                if (lb == eListBox.LB_BARCODE)
                    listBox_Log.Items.Insert(0, coloredItem);
                else if (lb == eListBox.LB_HEARTBEAT)
                    listBox_Log.Items.Insert(0, coloredItem);
            }

        }

        private void btnClear_log(object sender, EventArgs e)
        {
            listBox_Log.Items.Clear();
        }

        private void ListBox_Log_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            var item = ((ListBox)sender).Items[e.Index] as ColoredItem;

            if (item != null)
            {
                e.Graphics.DrawString(
                    item.Text,
                    e.Font,
                    new SolidBrush(item.Color),
                    e.Bounds);
            }
        }
    }
}
