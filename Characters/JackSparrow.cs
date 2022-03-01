using System;
using mis321_pa2_cwray2.Interfaces;
using mis321_pa2_cwray2.Attacks;
using mis321_pa2_cwray2.Defends;
using static mis321_pa2_cwray2.Utils;

namespace mis321_pa2_cwray2
{
    public class JackSparrow : Character
    {
        public JackSparrow() {
            Name = "Jack Sparrow";
            ab = new DistractOpponent();
            db = new Dodge();
        }
    }
}