using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace FileProvider.Model
{
    public class TwoModel
    {
        public readonly IFileProvider fileProvider;

        public string path;

        public TwoModel(IFileProvider file) 
        {
            fileProvider = file;
        }

        public void ConsoDicretory(DirectoryInfo directory) 
        {
            //获取文件内容
            FileInfo[] directory1 = directory.GetFiles();
            foreach(var i in directory1) { }
            foreach (var j in directory.GetDirectories()) 
            {
                ConsoDicretory(j);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetFileName(string text) 
        {
            //var dd = fileProvider
            var stream = fileProvider.GetDirectoryContents(text).Where(x => !x.IsDirectory).FirstOrDefault().CreateReadStream();
            byte[] vs = new byte[stream.Length];
            stream.Read(vs, 0, (int)stream.Length);
            return Encoding.Default.GetString(vs);
        }
    }
}
