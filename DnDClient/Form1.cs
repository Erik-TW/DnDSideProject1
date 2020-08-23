﻿using System;
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
            EncounterListBox.DataSource = characters;
            EncounterListBox.DisplayMember = "CombatInfo";
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
    }
}
