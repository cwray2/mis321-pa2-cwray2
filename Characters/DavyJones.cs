using System;
using mis321_pa2_cwray2.Interfaces;
using mis321_pa2_cwray2.Attacks;
using mis321_pa2_cwray2.Defends;
using static mis321_pa2_cwray2.Utils;

namespace mis321_pa2_cwray2
{
    public class DavyJones : Character
    {
        public DavyJones() {
            Name = "Davy Jones";
            ab = new CannonAttack();
            db = new Block();
        }

        // public void SetAttackBehavior(IAttackBehavior ab) {
        //     this.ab = ab;
        // }
        // public void SetDefendBehavior(IDefendBehavior db) {
        //     this.db = db;
        // }
        //Joe Calamusa
    }
}