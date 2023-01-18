using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxBinding
{
    internal class Item
    {
        public bool isChecked { get; set; }
        public string name {get; set; }

        public Item(string name)
        {
            this.isChecked = true;
            this.name = name;
        }
    }
}
