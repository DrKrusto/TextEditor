using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class TextFile
    {
        public string FileName { get; set; }
        public bool isSaved { get; set; }
        public bool Exists { get; set; }
    }
}
