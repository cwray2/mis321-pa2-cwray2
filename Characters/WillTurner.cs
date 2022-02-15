using System;
using mis321_pa2_cwray2.Interfaces;
using mis321_pa2_cwray2.Attacks;
using static mis321_pa2_cwray2.CalcUtil;

namespace mis321_pa2_cwray2
{
    public class WillTurner : Character
    {
        public WillTurner() {
            Name = "Will Turner";
            MaxPower = MaxPower();
            Health = 100;
            AttackPower = AttackDefend(MaxPower);
            DefensePower = AttackDefend(MaxPower);
            ab = new SwordAttack();
        }
    }
}