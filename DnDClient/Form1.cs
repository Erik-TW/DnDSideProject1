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
            var indexes = EncounterListBox.SelectedIndices;
            List<int> test = new List<int>();
            foreach(int i in indexes)
            {
                test.Add(i);
            }
            EncounterListBox.DataSource = characters;
            EncounterListBox.DisplayMember = "CombatInfo";
            EncounterListBox.SetSelected(0, false);
            foreach (int i in test)
            {
                EncounterListBox.SetSelected(i, true);
            }
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
                RefreshEncounterListBox(controller.AddToCombatList(markedCharacter));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
                RefreshEncounterListBox(controller.RemoveFromCombatList(EncounterListBox.SelectedIndex));
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            var selectedItems = EncounterListBox.SelectedItems.GetEnumerator();
                int damage = 0;
                if (Int32.TryParse(ModifierTextBox.Text, out damage))
                {
                    RefreshEncounterListBox(controller.DealDamage(selectedItems, damage));
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            var selectedItems = EncounterListBox.SelectedItems.GetEnumerator();
            int heal = 0;
                if (Int32.TryParse(ModifierTextBox.Text, out heal))
                {
                    RefreshEncounterListBox(controller.HealCharacter(selectedItems, heal));
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

        private void InitiativeButton_Click(object sender, EventArgs e)
        {
            var selectedItems = EncounterListBox.SelectedItems.GetEnumerator();
            int initiative = 0;
                if (Int32.TryParse(ModifierTextBox.Text, out initiative))
                {
                    RefreshEncounterListBox(controller.SetInitiative(selectedItems, initiative));
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

        private void DBACTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] values = new String[7];
            values[0] = DBNameTextBox.Text;
            values[1] = DBMaxHpTextBox.Text;
            values[2] = DBACTextBox.Text;
            values[3] = DBInitiativeTextBox.Text;
            values[4] = DBPCTextBox.Text;
            values[5] = DBTypeTextBox.Text;
            values[6] = DBCRTextBox.Text;

           if (!controller.AddToDatabase(values))
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
