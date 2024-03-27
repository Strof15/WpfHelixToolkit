using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHelixToolkit
{
    public class Bogyo
    {
        int x;
        int y;
        int z;
        int e;

        public Bogyo(String sor)
        {
            string [] adatok = sor.Split(";");
            this.X = int.Parse(adatok[0]);
            this.Y = int.Parse(adatok[1]);
            this.Z = int.Parse(adatok[2]);
            this.E = int.Parse(adatok[3]);
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int E { get => e; set => e = value; }
    }
}
