namespace BK
{
    class Actor
    {
        public BodyComponents Blocked { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }

        public delegate void CombatHandler(object sender, CombatEventArgs e);
        public event CombatHandler Block;
        public event CombatHandler Wound;
        public event CombatHandler Death;

        public bool GetHit(BodyComponents attackedPart)
        {
            if ((Blocked & attackedPart) != 0)
            {
                return false;
            }
            return true;
        }

        public void TryBlock(BodyComponents attackedPart, CombatEventArgs e)
        {
            if (!GetHit(attackedPart))
            {
                Block?.Invoke(this, e);
            }
            else
            {
                int damage = e.randomGenerator.Next(2, 20);
                e.currentHP = HP - damage;
                HP = e.currentHP;
                if (HP > 0)
                {
                    Wound?.Invoke(this, e);
                }
                else
                {
                    Death?.Invoke(this, e);
                }
            }
        }

        public void SetBlock(BodyComponents blockedPart)
        {
            Blocked = blockedPart;
        }
        
        public Actor(string Name)
        {
            this.Name = Name;
            Blocked = BodyComponents.NONE;
            HP = 100;
        }
    }
}
