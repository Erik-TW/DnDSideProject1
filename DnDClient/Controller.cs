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
            List<Character> temp = new List<Character>();
            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }

        public List<Character> RemoveFromCombatList(int characterIndex)
        {
            combatList.RemoveAt(characterIndex);
            List<Character> temp = new List<Character>();
            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }

        public List<Character> DealDamage(int characterIndex, int damage)
        {
            List<Character> temp = new List<Character>();
            Character character = combatList[characterIndex];
            int currentHp = character.CurrentHp - damage;
            character.CurrentHp = currentHp;

            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }
    }
}
