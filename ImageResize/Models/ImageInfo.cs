using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Models
{
    public class ImageInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public FileInfo _FileInfo { get; set; }
        public List<string> ToList()
        {
            var array = new List<string>();
            array.Add(Name);
            array.Add(Path);
            array.Add(Size);
            array.Add(Width.ToString());
            array.Add(Height.ToString());
            return array;
        }

    }
}
