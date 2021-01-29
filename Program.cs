using System;
using System.IO;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                > Consepts:-
                ===========
                \ >> Escape(Skip) Character => (\n, \t)
                -------------------------------
                raw Absolute Path >> D:\theSession\project >> (@)
                -------------------------------------------------
                Namespace >> (Static System.Console, System.IO)
                -----------------------------------------------
                What is An Array ?
                    ->How To Declare An Array
                    ->How To Deal Arrays (get)
                    ->foreach(){} loop sturcture
                -------------------------------------------
                => File Management
                    ->Directory
                    ->file
                -----------------
            */

           string path = @"D:\theSession\Files";
            foreach(string f in Directory.GetFiles(path)){
                string FileName = f.Substring(path.Length + 1);
                // Console.WriteLine(FileName);
                if(f.EndsWith(".txt") || f.EndsWith(".doc")){
                // Console.WriteLine(f);
                    string tpath = path + @"\text";
                    if(!Directory.Exists(tpath))
                        Directory.CreateDirectory(tpath);
                   File.Move(f, Path.Combine(tpath, FileName));
                    
                }
                if(f.EndsWith(".jpg") || f.EndsWith(".png")){
                // Console.WriteLine(f);
                    string tpath = path + @"\Images";
                    if(!Directory.Exists(tpath))
                        Directory.CreateDirectory(tpath);
                   File.Move(f, Path.Combine(tpath, FileName));
                    
                }
                if(f.EndsWith(".mp3")){
                // Console.WriteLine(f);
                    string tpath = path + @"\Audio";
                    if(!Directory.Exists(tpath))
                        Directory.CreateDirectory(tpath);
                   File.Move(f, Path.Combine(tpath, FileName));
                    
                }
                if(f.EndsWith(".mp4") || f.EndsWith(".mkv")){
                // Console.WriteLine(f);
                    string tpath = path + @"\Video";
                    if(!Directory.Exists(tpath))
                        Directory.CreateDirectory(tpath);
                   File.Move(f, Path.Combine(tpath, FileName));
                    
                }
                if(f.EndsWith(".rar") || f.EndsWith(".zip")){
                // Console.WriteLine(f);
                    string tpath = path + @"\Compressed Files";
                    if(!Directory.Exists(tpath))
                        Directory.CreateDirectory(tpath);
                   File.Move(f, Path.Combine(tpath, FileName));
                    
                }
            }
        }
    }
}
