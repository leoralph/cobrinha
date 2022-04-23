using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobrinha
{
    internal class Comida
    {
        public Point Location { get; private set; }
        public void createFood()
        {
            Random random = new Random();
            Location = new Point(random.Next(0, 27), random.Next(0, 27));
        }
    }
}
