using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Drink
    {
        public int Vol = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъём: {0}", this.Vol);
            return str;

        }
    }
}
