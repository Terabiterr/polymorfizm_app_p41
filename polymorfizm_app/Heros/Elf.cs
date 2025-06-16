using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm_app.Heros
{
    public class Elf : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("Elf is attacked ...");
        }
    }
}
