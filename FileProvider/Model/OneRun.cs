using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileProvider.Model
{
    public class OneRun
    {
        public readonly IFileProvider fileProvider;

        public string Path = "";
        public OneRun(IFileProvider file) 
        {
            fileProvider = file;
        }

        public void Conso() 
        {
            ConsoPath(Path);
        }
        

        /// <summary>
        /// 
        /// </summary>
        public void ConsoPath(string path) 
        {
            //var ui = fileProvider.get
            //var ty = fileProvider.GetDirectoryContents(path);
            foreach (var i in fileProvider.GetDirectoryContents(path)) 
            {
                Console.WriteLine("\t" + i.Name);
                if (i.IsDirectory) 
                {
                    ConsoPath(@$"{path}\{i.Name}");
                }
            }
        }
    }
}
