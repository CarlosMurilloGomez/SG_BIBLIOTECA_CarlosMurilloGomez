using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    public class ComboItem
    {
        public int value { get; set; }
        public string name { get; set; }
        public ComboItem(int codPeli, string titulo)
        {
            this.value = codPeli;
            this.name = titulo;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
