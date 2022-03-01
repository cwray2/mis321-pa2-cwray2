using System;
using mis321_pa2_cwray2.Interfaces;
using static mis321_pa2_cwray2.Utils;

namespace mis321_pa2_cwray2
{
    public abstract class Character
    {
        //instance variables
        public IAttackBehavior ab { get; set; }
        public IDefendBehavior db { get; set; }
        public string Name { get; set; }
        public int MaxPower { get; set; }
        public double Health { get; set; }
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        public Random r = new Random();

        //Constructor
        public Character()
        {
            MaxPower = SetMaxPower();
            Health = 100;
            AttackPower = AttackDefend(MaxPower);
            DefensePower = AttackDefend(MaxPower);
        }

        //character can heal random amount between 1 and 10
        public void Heal()
        {
            //+= heal number
            Health += r.Next(1, 10);
            if (Health > 100)
            {
                Health = 100;
            }
        }

        public int SetMaxPower()
        {  //very unbalanced!
            return r.Next(1, 101);
        }

        public int AttackDefend(int mp)
        {
            return r.Next(1, mp + 1);
        }

        public void Parry()
        {
            //Perry logic
        }

        public void TakeDamage(Character enemyPlayer)
        {
            if (Name == "Will Turner" && enemyPlayer.Name == "Jack Sparrow")
            {
                if (enemyPlayer.AttackPower <= DefensePower)
                {
                    Health -= 10;
                }
                else
                {
                    Health -= enemyPlayer.AttackPower - DefensePower * 1.2;
                }
            }
            else if (Name == "Davy Jones" && enemyPlayer.Name == "Will Turner")
            {
                if (enemyPlayer.AttackPower <= DefensePower)
                {
                    Health -= 10;
                }
                else
                {
                    Health -= enemyPlayer.AttackPower - DefensePower * 1.2;
                }
            }
            else if (Name == "Jack Sparrow" && enemyPlayer.Name == "Davy Jones")
            {
                if (enemyPlayer.AttackPower <= DefensePower)
                {
                    Health -= 10;
                }
                else
                {
                    Health -= enemyPlayer.AttackPower - DefensePower * 1.2;
                }
            }
            else
            {
                if (enemyPlayer.AttackPower <= DefensePower)
                {
                    Health -= 10;
                }
                else
                {
                    Health -= enemyPlayer.AttackPower - DefensePower * 1;
                }
            }
            if (Health > 100)
            {
                Health = 100;
            }
        }

    }
}