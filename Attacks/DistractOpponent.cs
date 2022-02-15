using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2.Attacks
{
    public class DistractOpponent : IAttackBehavior
    {
        public void Attack() {
            Console.WriteLine("Distract opponent used");
        }
    }
}