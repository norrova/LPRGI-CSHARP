using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Project
{
    public static class Asynchrone
    {
        public static async Task CopyFile(String p_source, String p_dest)
        {
            Stream source = File.Open(p_source, FileMode.Open);
            Stream destination = File.Create(p_dest);
            source.CopyToAsync(destination);
        }

        public static async void CopyDirectory(String p_source, String p_dest)
        {
            if (!Directory.Exists(p_source))
            {
                throw new ArgumentException("Source not found");
            }
            if (!Directory.Exists(p_dest))
            {
                Directory.CreateDirectory(p_dest);
            }
            List<Task> v_wait = new List<Task>();
            var v_files = Directory.EnumerateFiles(p_source, "*.*");
            foreach (string filename in v_files)
            {
                String v_dest = $"{p_dest}/{Path.GetFileName(filename)}";
                if (!File.Exists(v_dest))
                {
                    v_wait.Add(CopyFile(filename, v_dest));
                }
            }
            await Task.WhenAll(v_wait);
        }
    }
}
