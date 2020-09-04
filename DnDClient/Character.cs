using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDClient
{
    [Table("Character")]
    class Character
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int maxHp{ get; set; }
        public int AC { get; set; }
        public int initiativeBonus { get; set; }
        public bool PC { get; set; }
        public string type { get; set; }
        public float CR { get; set; }
        [Write(false)]
        public int initiative { get; set; }
        [Write(false)]
        public int currentHp { get; set; }
        private int _Index = 1;

        public Character (String name, int maxHp, int AC, int initiativeBonus, bool PC, string type, float CR)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.AC = AC;
            this.initiativeBonus = initiativeBonus;
            this.PC = PC;
            this.type = type;
            this.CR = CR;
        }

        public Character()
        {

        }
        [Write(false)]
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }



        [Write(false)]
        public string CombatInfo
        {
            get 
            { 
                if(PC)
                {
                    return $"{ name } HP: { currentHp } AC: { AC } Initiative: { initiative}";
                }
                return $"{ name } {Index} HP: { currentHp } AC: { AC } Initiative: { initiative}";
            }
        }
        [Write(false)]
        public string SearchInfo
        {
            get { return $"{ name } Max HP: { maxHp } AC: { AC } Initiative: { initiativeBonus} PC: {PC} Type: { type } CR: { CR } "; }
        }
    }
}
