using MornitorSoft.MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace MornitorSoft
{
    public partial class MainForm : Form
    {

        Parameter param = null;

        string mspaint_path = null;
        SoftManager mspaint = null;


        ImageList list_img = null;
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


            listBox_Software.BackColor = Color.Beige;
            listBox_Software.DataSource = param.List_files_exe;


        }

        

        void Init_Variables()
        {
            /*param.List_files_exe = new List<string>();
            param.Folder_path = @"C:\Windows\System32";*/

            //list_files_exe = MyDefine.Filter_Software_Type(MyDefine.Get_All_File_In_Folder(folder_path), ".exe", true);
            mspaint_path = @"C:\Windows\System32\cmd.exe";
            mspaint = null;


            list_img = new ImageList() { ImageSize = new Size(16, 16) };
            list_img.Images.Add(new Bitmap(MyDefine.pictureDirectory + "\\error.ico"));
            list_img.Images.Add(new Bitmap(MyDefine.pictureDirectory + "\\stop.ico"));
            list_img.Images.Add(new Bitmap(MyDefine.pictureDirectory + "\\run.ico"));


            if (param == null)
                param = new Parameter();

            if (MyDefine.File_Is_Exist(MyDefine.file_config))
            {
                param = Storage_Parameter.Load_Parameter(param, MyDefine.file_config) as Parameter;
            }
            else
            {
                MessageBox.Show($"Not found {MyDefine.file_config}");
            }


        }

        void Create_Item()
        {
            ListViewItem listViewItem = new ListViewItem();
            //Name
            //Label label_name = new Label();
            //label_name.Text = "Hello";
            //ListViewSubItem listViewSubItem_name = new ListViewSubItem(label_name, "test");
            listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "cmd.exe" });
            listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "cmd.exe" });
            //Button
            //1.btn Start
            //2.btn Stop
            //3.btn Reset

            //Status
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
                        var x = @"G:/THH";

                        fbd.SelectedPath = x;
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            param.Folder_path = fbd.SelectedPath;
                            label_folder_path.Text = param.Folder_path;


                            param.List_files_exe = MyDefine.Filter_Software_Type(MyDefine.Get_All_File_In_Folder(param.Folder_path), ".exe", true);
                            Add_Log("----------------------");
                            foreach (var file_exe in param.List_files_exe)
                            {
                                Add_Log(file_exe);
                                param.List_soft.Add(new SoftManager(file_exe, eSoftStatus.Soft_Stop, false));
                            }
                            Add_Log("----------------------");
                        }
                        else
                        {
                            label_folder_path.Text = "Not yet select folder";
                        }
                    }
                    break;
                case "btnSoftPath":
                    
                    if(txt_soft_path.Text.Contains("\""))
                    {
                        mspaint_path = txt_soft_path.Text.Replace("\"", "");
                    }
                    else
                    {
                        mspaint_path = txt_soft_path.Text.Trim();
                    }

                    Console.WriteLine(mspaint_path);
                    mspaint = new SoftManager(mspaint_path);
                    mspaint.Error_Event += Mspaint_Error_Event;
                    mspaint.Output_Event += Mspaint_Output_Event;
                    break;
                case "btnRun":
                    if(mspaint == null)
                    {
                        mspaint = new SoftManager(mspaint_path);
                        mspaint.Error_Event += Mspaint_Error_Event; 
                        mspaint.Output_Event += Mspaint_Output_Event;
                    }
                    mspaint.Run_Soft();
                    break;

                case "btnStop":
                    if(mspaint != null)
                        mspaint.Stop_Soft();
                    break;

                case "btnRestart":
                    if (mspaint != null)
                        mspaint.Restart_Soft();
                    /*Thread th = new Thread(test_start_stop);
                    th.Start();*/
                    break;

                case "btnSaveParam":
                    //Get_Common_Param();
                    if (MyDefine.File_Is_Exist(MyDefine.file_config))
                    {
                        Storage_Parameter.Save_Parameter(param, MyDefine.file_config);
                    }
                    else
                    {
                        //create folder
                        FileInfo fileInfo = new FileInfo(MyDefine.file_config);

                        if (!fileInfo.Exists)
                            Directory.CreateDirectory(fileInfo.Directory.FullName);

                        //create file
                        FileStream f = File.Create(MyDefine.file_config);
                        f.Close();
                        Console.WriteLine($"Create file {MyDefine.file_config}");

                        //save param to file
                        Storage_Parameter.Save_Parameter(param, MyDefine.file_config);
                    }
                    break;
                case "btnLoadParam":
                    //Get_Common_Param();
                    //Storage_Parameter.Load_Parameter(param, MyDefine.file_config);

                    //config format string
                    if(param == null)
                        param = new Parameter();

                    if (MyDefine.File_Is_Exist(MyDefine.file_config))
                    {
                        param = Storage_Parameter.Load_Parameter(param, MyDefine.file_config) as Parameter;
                    }
                    else
                    {
                        MessageBox.Show($"Not found {MyDefine.file_config}");
                    }

                    break;

            }
        }

        private void Mspaint_Output_Event(object sender, OutputChangeEventArgs e)
        {
            if (e.Output == null)
                return;

            Console.WriteLine($"output = {e.Output}");
            Add_Log(string.IsNullOrEmpty(e.Output) ? "OK" : e.Output, Color.Green);
        }

        private void Mspaint_Error_Event(object sender, OutputChangeEventArgs e)
        {
            if (e.Output == null)
                return;
            Console.WriteLine($"error = {e.Output}");
            Add_Log(string.IsNullOrEmpty(e.Output)?"OK":e.Output, Color.DarkRed);
            if(e.Output.Contains("Exception"))
            {
                Add_Log($"{mspaint.File_name} error", Color.Blue);
                Add_Log($"{mspaint.File_name} -> restart", Color.Blue);
                mspaint.Restart_Soft();

            }
        }

        void test_start_stop()
        {
           for(int i = 0; i < 100; i++)
            {
                mspaint.Run_Soft();
                Thread.Sleep(100);
                mspaint.Stop_Soft();
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
                    listBox_Software.Items.Insert(0, coloredItem);
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

        private void ListBox_Software_DrawItem(object sender, DrawItemEventArgs e)
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
