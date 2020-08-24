using System;
using System.Collections.Generic;
using System.Text;

namespace DnDClient
{
    class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxHp{ get; set; }
        public int AC { get; set; }
        public int InitiativeBonus { get; set; }
        public bool PC { get; set; }
        public string Type { get; set; }
        public float CR { get; set; }
        public int Initiative { get; set; }
        public int CurrentHp { get; set; }

        private int _Index = 1;

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }




        public string CombatInfo
        {
            get 
            { 
                return $"{ Name } {Index} Current HP: { CurrentHp } AC: { AC } Initiative: { Initiative}";
            }
        }

        public string SearchInfo
        {
            get { return $"{ Name } Max HP: { MaxHp } AC: { AC } Initiative: { InitiativeBonus} PC: {PC} Type: { Type } CR: { CR } "; }
        }


    }
}
