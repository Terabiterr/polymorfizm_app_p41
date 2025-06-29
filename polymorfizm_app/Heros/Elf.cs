﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm_app.Heros
{
    public class Elf : Hero
    {
        public Elf(string? name) : base(name)
        {
        }

        public override string? Name { get; set; }

        public override void Attack()
        {
            Console.WriteLine($"Hero: {Name} attacked ...");
        }
    }
}
