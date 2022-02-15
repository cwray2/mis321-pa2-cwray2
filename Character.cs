using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2
{
    public class Character
    {
        //instance variables
        // public IHealthBehavior hb { get; set; }
        public IAttackBehavior ab { get; set; }  //implemented via a "has-a" relationship
        public IDefendBehavior db { get; set; }
        //variables
        //public int mp { get; set; }
        public string Name { get; set; }
        public int MaxPower { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }

        //constructors... not really necessary
        public void SetDefenseBehavior(IDefendBehavior db) {
            this.db = db;
        }

        // public void SetHealthBehavior(IHealthBehavior hb) {
        //     this.hb = hb;
        // }
    }
}