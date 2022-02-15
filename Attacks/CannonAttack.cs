using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2.Attacks
{
    public class CannonAttack : IAttackBehavior
    {
        public void Attack() {
            Console.WriteLine($"Cannon Attack used");
        }
        
        
    }
}