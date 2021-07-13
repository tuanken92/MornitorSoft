using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MornitorSoft.MyLib
{
    public enum eListBox
    {
        LB_BARCODE = 0,
        LB_HEARTBEAT
    }
    public class ColoredItem
    {
        public string Text;
        public Color Color;
    };

    public class MyDefine
    {
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
