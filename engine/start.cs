using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public struct rfid_tag_struct
    {
        private string serial;
        private string name;
        private string price;

        public rfid_tag_struct(string serial, string name, string price)
        {
            this.serial = serial;
            this.name = name;
            this.price = price;
        }
    }
    public class Start
    {
        public List<List<string>> start_loop()
        {
            return new List<List<string>>();
        }
    }

    
}
