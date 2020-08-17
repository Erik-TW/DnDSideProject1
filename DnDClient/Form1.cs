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
        DBAccess dbConnection = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
           List<Character> monsters =  dbConnection.GetMonsters();
            SearchListBox.DataSource = monsters;
            SearchListBox.DisplayMember = "SearchInfo";
        }
    }
}
