using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDClient
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        List<Character> monsters = new List<Character>();
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshSearchListBox()
        {
            SearchListBox.DataSource = monsters;
            SearchListBox.DisplayMember = "SearchInfo";
        }

        private void RefreshEncounterListBox(List<Character> characters)
        {
            var index = EncounterListBox.SelectedIndex;
            EncounterListBox.DataSource = characters;
            EncounterListBox.DisplayMember = "CombatInfo";
            EncounterListBox.SelectedIndex = Math.Min(index, characters.Count - 1);
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;
            monsters =  controller.Search(searchText);
            RefreshSearchListBox();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Character markedCharacter = (Character)SearchListBox.SelectedItem;
            RefreshEncounterListBox(controller.AddToCombatList(CopyCharacter(markedCharacter)));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RefreshEncounterListBox(controller.RemoveFromCombatList(EncounterListBox.SelectedIndex));

        }

        private void DamageButton_Click(object sender, EventArgs e)

        {
            int damage = 0;
            if (Int32.TryParse(ModifierTextBox.Text, out damage))
            {
                RefreshEncounterListBox(controller.DealDamage(EncounterListBox.SelectedIndex, damage));
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

           
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            int heal = 0;
            if (Int32.TryParse(ModifierTextBox.Text, out heal))
            {
                RefreshEncounterListBox(controller.HealCharacter(EncounterListBox.SelectedIndex, heal));
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void RollInitiativeButton_Click(object sender, EventArgs e)
        {
            RefreshEncounterListBox(controller.RollInitiative());

        }

        private Character CopyCharacter(Character character) 
        {
            Character newchar = new Character();

            return new Character
            {
                Id = character.Id,
                Name = character.Name,
                MaxHp = character.MaxHp,
                AC = character.AC,
                InitiativeBonus = character.InitiativeBonus,
                PC = character.PC,
                Type = character.Type,
                CR = character.CR,
                Initiative = character.Initiative,
                CurrentHp = character.CurrentHp
            };
        }

        private void InitiativeButton_Click(object sender, EventArgs e)
        {


            int initiative = 0;
            if (Int32.TryParse(ModifierTextBox.Text, out initiative))
            {
                RefreshEncounterListBox(controller.SetInitiative(EncounterListBox.SelectedIndex, initiative));
            }
            else
            {
                MessageBox.Show("Invalid input");
            }


        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            RefreshEncounterListBox(controller.ResetEncounter());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
