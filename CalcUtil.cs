using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2
{
    public static class CalcUtil
    {
        public static int MaxPower() {  //very unbalanced!
            Random random = new Random();
            return random.Next(1, 101);
        }

        //
        public static int AttackDefend(int MaxPower) {
            var random = new Random();            
            return random.Next(1, MaxPower + 1);
        }

        public static int DamageDealt() {
            return 10;
        }
    }
}