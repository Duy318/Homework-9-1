using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Song
    {
        public Song(string type_list, string name, string time)
        {
            this.type_list = type_list;
            this.name = name;
            this.time = time;
        }
        public String type_list { get; set; }
        public String name { get; set; }
        public String time { get; set; }
    }
}
