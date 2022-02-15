using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2.Defends
{
    public class Parry : IDefendBehavior
    {
        public void Defend()
        {
            Console.WriteLine("Parry used");
        }
    }
}