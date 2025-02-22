﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
