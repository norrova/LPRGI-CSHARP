using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
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

        public static async Task CopyDirectory(String p_source, String p_dest)
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

        public static async Task SearchNumber(string p_source, List<string> p_numbers)
        {
            String[] v_lines = await File.ReadAllLinesAsync(p_source);
            String v_text = String.Join(';', v_lines);
            string v_pattern = @"[\w]*;[\w]*;";

            List<Task<string>> v_tasks = new List<Task<string>>();
            foreach(string v_number in p_numbers)
            {
                v_tasks.Add(Task<string>.Run(() =>
                {
                    return Regex.Match(v_text, $"{v_pattern}{v_number}").Value;
                }));
            }
            await Task.WhenAll(v_tasks);
            foreach (Task<string> v_person in v_tasks)
            {
                Console.WriteLine(v_person.Result);
            }
        }

        public async static void Run()
        {
            List<string> v_numbers = new List<string>
            {
                "06 96 03 71 94",
                "06 50 83 54 38",
                "06 58 08 11 26",
                "06 95 78 68 37",
                "06 94 24 87 21",
                "06 48 75 46 94",
                "06 11 67 13 02",
                "06 78 37 93 41",
                "07 06 49 85 57",
                "07 97 06 30 58",
                "06 23 52 30 76",
                "06 90 21 84 00",
                "06 60 78 25 29"
            };

            await Asynchrone.CopyDirectory(
                "/Users/valentinnorro/Documents/LPRGI/LPRGI-CSHARP/Test Déplacement/Source",
                "/Users/valentinnorro/Documents/LPRGI/LPRGI-CSHARP/Test Déplacement/Dest"
            );
            await Asynchrone.SearchNumber("/Users/valentinnorro/Documents/LPRGI/LPRGI-CSHARP/Test Déplacement/data.csv", v_numbers);
        }
    }
}
