using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15
{
    class Game3 : Game2
    {
        public readonly List<int> story;
        public Game3(params int[] gets):base(gets) 
{
            story = new List<int>();
        }

        public void storya(int val)
        {
            story.Add(val);
        }
        public override bool Shift(int val)
        {
            if (base.Shift(val))
            {
                base.Shift(val);
                try { storya(val); }
                catch { }

            }
            return base.Shift(val);
        }
    }
}
