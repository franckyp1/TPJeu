﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class De
    {
        private Random random;

        public De()
        {
            random = new Random();
        }

        public int LanceLeDe()
        {
            return random.Next(1,7) ;
        }

        public int LanceLeDe(int val)
        {
            return random.Next(1, val);
        }
    }
}
