using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook: IMagicalItem
    {
        private List<Spell> spells = new List<Spell>();
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }

        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            this.spells.Remove(spell);
        }
    }
}