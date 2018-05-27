using System;

namespace BK
{
    class CombatEventArgs: EventArgs
    {
        public BodyComponents attackedPart { get; set; }
        public Actor actor { get; set; }
        public int currentHP { get; set; }
        public Random randomGenerator { get; set; }

        public CombatEventArgs(Actor actor,BodyComponents attackedPart, int currentHP, Random randomGenerator)
        {
            this.actor = actor;
            this.attackedPart = attackedPart;
            this.currentHP = currentHP;
            this.randomGenerator = randomGenerator;
        }
    }
}
