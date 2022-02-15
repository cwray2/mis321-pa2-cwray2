using System;
using mis321_pa2_cwray2.Interfaces;

namespace mis321_pa2_cwray2.Defends
{
    public class Block : IDefendBehavior
    {
        public void Defend()
        {
            Console.WriteLine("Block used");
        }
    }
}