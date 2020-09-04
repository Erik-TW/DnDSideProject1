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
        List<Character> encounterList = new List<Character>();
        public Form1()
        {
            InitializeComponent();
            EncounterListBox.DrawMode = DrawMode.OwnerDrawFixed;
            EncounterListBox.DrawItem += new DrawItemEventHandler(encounterListBox_DrawItem);
        }
        private void RefreshSearchListBox()
        {
            SearchListBox.DataSource = monsters;
            SearchListBox.DisplayMember = "SearchInfo";
        }

        private void RefreshEncounterListBox(List<Character> characters)
        {
            List<Character> selectedPreRepaint = new List<Character>();
            foreach(Character c in EncounterListBox.SelectedItems)
            {
                selectedPreRepaint.Add(c);
            }

            EncounterListBox.DataSource = characters;
            EncounterListBox.DisplayMember = "CombatInfo";
            if(EncounterListBox.Items.Count > 0)
            {
                EncounterListBox.SetSelected(0, false);
            }

            List<Character> selectedPostRepaint = new List<Character>();
            foreach (Character c in EncounterListBox.Items)
            {
                selectedPostRepaint.Add(c);
            }
           List<int> selected = controller.CompareSelectedItems(selectedPreRepaint, selectedPostRepaint);
            foreach(int i in selected)
            {
                EncounterListBox.SetSelected(i, true);
            }
            encounterList = characters;
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
            var selectedItems = EncounterListBox.SelectedIndices.GetEnumerator();
            RefreshEncounterListBox(controller.RemoveFromCombatList(selectedItems));
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
        private void encounterListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            if (encounterList.Count > 0)
            {
                for (int i = 0; i < encounterList.Count; i++)
                {
                    int percentage = (encounterList[i].currentHp * 200 + encounterList[i].maxHp) / (encounterList[i].maxHp * 2);


                    if (percentage >= 75)
                    {
                        g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
                    }
                    else if (percentage < 75 && percentage >= 50)
                    {
                        g.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
                    }
                    else if (percentage < 50 && percentage >= 25)
                    {
                        g.FillRectangle(new SolidBrush(Color.Orange), e.Bounds);
                    }
                    else if (percentage < 25)
                    {
                        g.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                    }
                    g.DrawString(encounterList[i].CombatInfo, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));

                }
                e.DrawFocusRectangle();
            }
        }

    }
}
