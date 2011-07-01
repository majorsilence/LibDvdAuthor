using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibDvdAuthor
{
    public class Buttons
    {
        public string Name { get; set; }
        public int x0 { get; set; }
        public int x1 { get; set; }
        public int y0 { get; set; }
        public int y1 { get; set; }
        public string up { get; set; }
        public string down { get; set; }

        public Buttons()
        {
            Name = "";
            x0 = 0;
            x1 = 0;
            y0 = 0;
            y1 = 0;
            up = "";
            down = "";
        }

    }
}
