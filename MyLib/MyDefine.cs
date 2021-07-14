using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MornitorSoft.MyLib
{
    public enum eListBox
    {
        LB_BARCODE = 0,
        LB_HEARTBEAT
    }

    public enum eSoftStatus
    {
        Soft_Stop,
        Soft_Running,
        Soft_Error,
        Soft_Restarting
    }


    public class OutputChangeEventArgs : EventArgs
    {
        public string Output { get; set; }
        public OutputChangeEventArgs(string output)
        {
            Output = output;
        }
    }

    public class SoftManager
    {
        eSoftStatus status;
        bool isActive;
        string file_name;
        string output_error;
        string output_soft;
        int PID;
        Process p;
        Thread thread_handle_error;
        bool hadErrors;

        public SoftManager()
        {
            this.status = eSoftStatus.Soft_Stop;
            this.isActive = false;
            this.file_name = null;
            this.Output_error = null;
            this.PID = 0;
            this.p = null;
            this.thread_handle_error = null;
            this.hadErrors = false;
        }

        public SoftManager(string file_name, eSoftStatus status = eSoftStatus.Soft_Stop, bool isActive = true)
        {
            this.status = status;
            this.isActive = isActive;
            this.file_name = file_name;
            this.PID = 0;
            this.thread_handle_error = null;
            this.Output_error = null;
            this.p = null;
            this.hadErrors = false;
        }

        void Run_And_Handle()
        {
            try
            {
                // To avoid deadlocks, always read the output stream first and then wait.
                if (this.p != null)
                {
                    p.BeginErrorReadLine();
                    p.BeginOutputReadLine();
                    
                    p.WaitForExit();

                    
                    Console.WriteLine($"stdout stream:");

                    if (p.ExitCode != 0 || hadErrors)
                    {
                        
                        Console.WriteLine($"Error xxx: {Output_error}");
                    }

                    Stop_Soft();
                }
                else
                {
                    Console.WriteLine($"Process = null");
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Exception message: {0}", e.Message);
            }

            Console.WriteLine("Thread --- end---");
        }

        public int Run_Soft()
        {
            int pid = 0;
            if(p == null)
            {
                p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = this.file_name;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                Console.WriteLine("p.StartInfo.WorkingDirectory = " + p.StartInfo.WorkingDirectory);
                string x = Directory.GetParent(this.file_name).ToString();
                p.StartInfo.WorkingDirectory = x;
                Console.WriteLine("p.StartInfo.WorkingDirectory = " + x);
                p.EnableRaisingEvents = true;

                // capture normal output
                p.OutputDataReceived += P_OutputDataReceived;

                // Capture error output
                p.ErrorDataReceived += P_ErrorDataReceived;

                
            }

            

            bool b = p.Start();
            this.status = b ? eSoftStatus.Soft_Running : eSoftStatus.Soft_Error;

            Console.WriteLine($"Run {this.file_name} = {b}, process id = {p.ProcessName}, {p.Id}");

            if (thread_handle_error == null)
            {
                thread_handle_error = new Thread(Run_And_Handle);
                thread_handle_error.IsBackground = true;
                thread_handle_error.Name = p.ProcessName;
                thread_handle_error.Start();
                Console.WriteLine($"Run thread handle error {this.file_name} = {b}, process id = {p.ProcessName}, {p.Id}");
            }


            this.PID = p.Id;
            pid = p.Id;


            return pid;
            
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!hadErrors)
            {
                hadErrors = !String.IsNullOrEmpty(e.Data);
            }
            Output_error = e.Data;
            Console.WriteLine($"Error soft: {e.Data}");

        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
                Output_soft = e.Data;
                Console.WriteLine($"Output soft: {e.Data}");
            
        }

        public bool Stop_Soft()
        {
            if(thread_handle_error != null)
            {
                //thread_handle_error.Abort();
                thread_handle_error = null;
                
                Console.WriteLine($"Stop thread handle error {this.file_name}, process id = {p.ProcessName}, {p.Id}");
            }
           
            if(this.status == eSoftStatus.Soft_Running)
            {
                p.CancelErrorRead();
                p.CancelOutputRead();
                this.status = eSoftStatus.Soft_Stop;
                MyDefine.KillProcessAndChildren(this.PID);
            }
            
            
            return true;
        }


        public bool Restart_Soft()
        {
            Stop_Soft();

            return Run_Soft() > 0 ? true : false;
        }

        public eSoftStatus Status { get => status; set => status = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string File_name { get => file_name; set => file_name = value; }
        public string Output_error { get => output_error; set { output_error = value; ErrorChanged(value); } }

        public string Output_soft { get => output_soft; set { output_soft = value; OutputChanged(value); } }

        //error string
        private event EventHandler<OutputChangeEventArgs> error_event;
        public event EventHandler<OutputChangeEventArgs> Error_Event
        {
            add
            {
                error_event += value;
            }
            remove
            {
                error_event -= value;
            }
        }

        void ErrorChanged(string name)
        {
            if (error_event != null)
            {
                error_event(this, new OutputChangeEventArgs(name));
            }
        }

        //output string
        private event EventHandler<OutputChangeEventArgs> output_event;
        public event EventHandler<OutputChangeEventArgs> Output_Event
        {
            add
            {
                output_event += value;
            }
            remove
            {
                output_event -= value;
            }
        }

        void OutputChanged(string name)
        {
            if (output_event != null)
            {
                output_event(this, new OutputChangeEventArgs(name));
            }
        }


    }


    public class ColoredItem
    {
        public string Text;
        public Color Color;
    };

    public class MyDefine
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public static readonly string workspaceDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        public static readonly string pictureDirectory = String.Format($"{workingDirectory}\\Pictures");

        public static readonly string file_config = String.Format($"{workingDirectory}\\Data\\configs\\config_param.json");
        public static readonly string file_config_format_data = String.Format($"{workingDirectory}\\Data\\configs\\format_data.json");
        public static readonly string file_config_common_param = String.Format($"{workingDirectory}\\Data\\configs\\common_param.json");
        public static readonly string file_config_filter_window = String.Format($"{workingDirectory}\\Data\\configs\\filter_window.json");
        public static readonly string path_load_img_database = @"C:\Program Files\Cognex\VisionPro\Images";
        public static readonly string path_load_vpp_file = @"C:\Users\Admin\Desktop\Vpp_file";
        public static readonly string path_save_images = String.Format("{0}\\Images", projectDirectory);

        /// <summary>
        /// Kill a process, and all of its children, grandchildren, etc.
        /// </summary>
        /// <param name="pid">Process ID.</param>
        public static bool KillProcessAndChildren(int pid)
        {
            bool is_killed = false;
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return is_killed;
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();

            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
                is_killed = true;
            }
            catch (Exception e)
            {
                // Process already exited.
                is_killed = false;
                Console.WriteLine($"Exception = {e.Message}");
            }

            return is_killed;
        }

        public static List<string> Get_All_File_In_Folder(string path, bool debug = false)
        {
            List<string> list_files = new List<string>();
            
            try
            {
                //1. find files in foder
                string[] files2 = Directory.GetFiles(path);
                if (files2.Length > 0)
                {
                    list_files.AddRange(files2);
                }

                //2. find subfolder
                string[] folders = Directory.GetDirectories(path);
                if (folders.Length > 0)
                {
                    //2.1. find files in subfolder
                    foreach (var fd in folders)
                    {
                        try
                        {
                            string[] files = Directory.GetFiles(fd);
                            if (files.Length > 0)
                            {
                                list_files.AddRange(files);
                            }
                        }
                        catch{}
                        
                    }
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
                

            

            if(debug)
            {
                foreach(var file in list_files)
                {
                    Console.WriteLine(file);
                }
            }
            return list_files;
        }

        public static List<string> Filter_Software_Type(List<string> list_files, string type, bool debug = false)
        {
            List<string> list_files_filter = new List<string>();
            Regex regex = new Regex($"{type}$");

            foreach (var file in list_files)
            {
                Match match = regex.Match(file);
                if (match.Success)
                {
                    list_files_filter.Add(file);
                }
            }

            if (debug)
            {
                foreach (var file in list_files_filter)
                {
                    Console.WriteLine(file);
                }
            }
            return list_files_filter;
        }
    }
}
