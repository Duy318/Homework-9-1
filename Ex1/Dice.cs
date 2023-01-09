using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Dice
    {
        private int slides;
        public int roll()
        {
            Random random = new Random();
            int n = random.Next(1, 6);
            return n;
        }
    }
}
