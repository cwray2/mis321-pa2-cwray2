using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2
{
    public class SwordAttack : IAttackBehavior
    {
        public void Attack() {
            Console.WriteLine("Sword attack used");
        }
    }
}