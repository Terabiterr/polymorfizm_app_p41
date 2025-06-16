using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm_app.Heros
{
    public class Gnom : Hero
    {
        public void Attack()
        {
            Console.WriteLine("Gnom is attacked ...");
        }
    }
}
