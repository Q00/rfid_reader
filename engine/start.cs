using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public struct rfid_tag_struct
    {
        public string Serial { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class Start
    {
        public List<rfid_tag_struct> start_loop()
        {
            return new List<rfid_tag_struct>();
        }
    }

    
}
