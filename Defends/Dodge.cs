using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2.Defends
{
    public class Dodge : IDefendBehavior
    {
        public void Defend()
        {
            Console.WriteLine("Dodge used");
        }
    }
}