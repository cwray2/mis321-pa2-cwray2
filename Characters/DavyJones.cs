using System;
using mis321_pa2_cwray2.Interfaces;
using mis321_pa2_cwray2.Attacks;
using static mis321_pa2_cwray2.CalcUtil;

namespace mis321_pa2_cwray2
{
    public class DavyJones : Character
    {
        public DavyJones() {
            Name = "Davy Jones";
            MaxPower = MaxPower();
            Health = 100;
            AttackPower = AttackDefend(MaxPower);
            DefensePower = AttackDefend(MaxPower);
            ab = new CannonAttack();
        }

        public void SetAttackBehavior(IAttackBehavior ab) {
            this.ab = ab;
        }
        //Joe Calamusa
    }
}