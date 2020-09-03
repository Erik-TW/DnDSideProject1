using System;
using System.Collections;
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
            if (character != null)
            {
                var tempChar = CopyCharacter(character);
                int index = 0;
                for (int i = 0; i < combatList.Count; i++)
                {
                    if (combatList[i].id == tempChar.id)
                    {
                        if (index < combatList[i].Index)
                        {
                            index = combatList[i].Index;
                        }
                    }
                }
                index++;
                tempChar.Index = index;
                combatList.Add(tempChar);
                tempChar.currentHp = tempChar.maxHp;
            }
            return GenerateTempList();
        }

        public List<Character> RemoveFromCombatList(IEnumerator selectedItems)
        {
            List<int> temp = new List<int>();
            while(selectedItems.MoveNext())
            {
                temp.Add((int)selectedItems.Current);
            }

            for(int i = temp.Count - 1; i >= 0; i--)
            {
                combatList.RemoveAt(temp[i]);
            }
            return GenerateTempList();
        }

        public List<Character> DealDamage(IEnumerator selectedItems, int damage)
        {
            while(selectedItems.MoveNext())
            {
                var selectedItem = (Character)selectedItems.Current;
                selectedItem.currentHp -= damage;
            }
            return GenerateTempList();
        }

        public List<Character> HealCharacter(IEnumerator selectedItems, int heal)
        {
            while (selectedItems.MoveNext())
            {
                var selectedItem = (Character)selectedItems.Current;
                selectedItem.currentHp += heal;
                if(selectedItem.currentHp > selectedItem.maxHp)
                {
                    selectedItem.currentHp = selectedItem.maxHp;
                }
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
                    combatList[i].initiative = rand.Next(0, 20) + combatList[i].initiativeBonus;
                }
            }
            return GenerateTempList();
        }

        public List<Character> SetInitiative(IEnumerator selectedItems, int initiative)
        {
            while (selectedItems.MoveNext())
            {
                var selectedItem = (Character)selectedItems.Current;
                selectedItem.initiative = initiative;
                
            }
            return GenerateTempList();
        }

        private List<Character> GenerateTempList()
        {
            combatList = combatList.OrderByDescending(o => o.initiative).ToList();
            List<Character> temp = new List<Character>();
            for (int i = 0; i < combatList.Count; i++)
            {
                temp.Add(combatList[i]);
            }
            return temp;
        }

        public List<Character> ResetEncounter()
        {
            combatList.Clear();
            return GenerateTempList();
        }

        private Character CopyCharacter(Character character)
        {
            Character newchar = new Character();

            return new Character
            {
                id = character.id,
                name = character.name,
                maxHp = character.maxHp,
                AC = character.AC,
                initiativeBonus = character.initiativeBonus,
                PC = character.PC,
                type = character.type,
                CR = character.CR,
                initiative = character.initiative,
                currentHp = character.currentHp
            };
        }

        public Boolean AddToDatabase(String[] values)
        {
            if (values[4].ToUpper().Equals("Y"))
            {
                values[4] = "1";
            } 
            else if (values[4].ToUpper().Equals("N"))
            {
                values[4] = "0";
            }
            else
            {
                return false;
            }

            string name = values[0];
            int maxHp = Convert.ToInt32(values[1]);
            int AC = Convert.ToInt32(values[2]);
            int initiativeBonus = Convert.ToInt32(values[3]);
            bool PC = Convert.ToBoolean(Convert.ToInt32(values[4]));
            string type = values[5];
            float CR = Convert.ToSingle(values[6]);

            Character character = new Character(name, maxHp, AC, initiativeBonus, PC, type, CR);

            return dbAccess.InsertInto(character);
        }
    }
}
