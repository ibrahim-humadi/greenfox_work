using System;
using System.Collections.Generic;
using System.Text;

namespace dominoes
{
public class Domino
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return values;
        }
    }
}