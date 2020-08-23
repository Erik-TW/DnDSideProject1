using System;
using System.Collections.Generic;
using System.Text;

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
            foreach (Character character in combatList)
            {
                character.Initiative = rand.Next(1, 20) + character.InitiativeBonus;
            }

            return GenerateTempList();
        }

        private List<Character> GenerateTempList()
        {
            List<Character> temp = new List<Character>();
            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }
    }
}
