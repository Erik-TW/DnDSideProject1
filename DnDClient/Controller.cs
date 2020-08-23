using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnDClient
{
    class Controller
    {
        DBAccess dbAccess = new DBAccess();
        List<Character> combatList = new List<Character>();
        public List<Character> Search(string search)
        {
            return dbAccess.GetMonsters(search);
        }

        public List<Character> AddToCombatList(Character character)
        {
            combatList.Add(character);
            character.CurrentHp = character.MaxHp;
            return GenerateTempList();
        }

        public List<Character> RemoveFromCombatList(int characterIndex)
        {
            combatList.RemoveAt(characterIndex);
            return GenerateTempList();
        }

        public List<Character> DealDamage(int characterIndex, int damage)
        {
            Character character = combatList[characterIndex];
            int currentHp = character.CurrentHp - damage;
            character.CurrentHp = currentHp;
            return GenerateTempList();
        }

        public List<Character> HealCharacter(int characterIndex, int heal)
        {
            Character character = combatList[characterIndex];
            character.CurrentHp = character.CurrentHp + heal;
            if (character.CurrentHp > character.MaxHp)
            {
                character.CurrentHp = character.MaxHp;
            }

            return GenerateTempList();
        }

        public List<Character> RollInitiative()
        {
            Random rand = new Random();
            for (int i = 0; i < combatList.Count; i++)
            {
                if (!combatList[i].PC)
                {
                    combatList[i].Initiative = rand.Next(0, 20) + combatList[i].InitiativeBonus;
                }
            }
            return GenerateTempList();
        }

        public List<Character> SetInitiative(int index, int initiative)
        {
            combatList[index].Initiative = initiative;
            return GenerateTempList();
        }

        private List<Character> GenerateTempList()
        {
            combatList = combatList.OrderByDescending(o => o.Initiative).ToList();
            List<Character> temp = new List<Character>();
            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }
    }
}
