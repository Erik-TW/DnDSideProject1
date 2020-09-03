namespace DnDClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncounterListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ModifierTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HealButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InitiativeButton = new System.Windows.Forms.Button();
            this.RollInitiativeButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.addTab = new System.Windows.Forms.TabPage();
            this.DBCRTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DBTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBPCTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBInitiativeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DBACTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DBMaxHpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DBNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddToDBButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncounterListBox
            // 
            this.EncounterListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncounterListBox.FormattingEnabled = true;
            this.EncounterListBox.ItemHeight = 25;
            this.EncounterListBox.Location = new System.Drawing.Point(12, 157);
            this.EncounterListBox.Name = "EncounterListBox";
            this.EncounterListBox.Size = new System.Drawing.Size(762, 179);
            this.EncounterListBox.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(32, 386);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(177, 23);
            this.SearchTextBox.TabIndex = 1;
            // 
            // ModifierTextBox
            // 
            this.ModifierTextBox.Location = new System.Drawing.Point(482, 386);
            this.ModifierTextBox.Name = "ModifierTextBox";
            this.ModifierTextBox.Size = new System.Drawing.Size(177, 23);
            this.ModifierTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(32, 415);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(134, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HealButton
            // 
            this.HealButton.Location = new System.Drawing.Point(482, 415);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(75, 23);
            this.HealButton.TabIndex = 4;
            this.HealButton.Text = "Heal";
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.HealButton_Click);
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(588, 415);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(75, 23);
            this.DamageButton.TabIndex = 5;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(678, 385);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InitiativeButton
            // 
            this.InitiativeButton.Location = new System.Drawing.Point(678, 415);
            this.InitiativeButton.Name = "InitiativeButton";
            this.InitiativeButton.Size = new System.Drawing.Size(85, 23);
            this.InitiativeButton.TabIndex = 7;
            this.InitiativeButton.Text = "Set Initiative";
            this.InitiativeButton.UseVisualStyleBackColor = true;
            this.InitiativeButton.Click += new System.EventHandler(this.InitiativeButton_Click);
            // 
            // RollInitiativeButton
            // 
            this.RollInitiativeButton.Location = new System.Drawing.Point(320, 355);
            this.RollInitiativeButton.Name = "RollInitiativeButton";
            this.RollInitiativeButton.Size = new System.Drawing.Size(92, 30);
            this.RollInitiativeButton.TabIndex = 8;
            this.RollInitiativeButton.Text = "Roll Initiative";
            this.RollInitiativeButton.UseVisualStyleBackColor = true;
            this.RollInitiativeButton.Click += new System.EventHandler(this.RollInitiativeButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(381, 447);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(320, 410);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(92, 28);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchTab);
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Location = new System.Drawing.Point(13, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 152);
            this.tabControl1.TabIndex = 11;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.SearchListBox);
            this.searchTab.Location = new System.Drawing.Point(4, 24);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(753, 124);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 15;
            this.SearchListBox.Location = new System.Drawing.Point(-4, 0);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(757, 124);
            this.SearchListBox.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.AddToDBButton);
            this.addTab.Controls.Add(this.label7);
            this.addTab.Controls.Add(this.DBCRTextBox);
            this.addTab.Controls.Add(this.label6);
            this.addTab.Controls.Add(this.DBTypeTextBox);
            this.addTab.Controls.Add(this.label5);
            this.addTab.Controls.Add(this.DBPCTextBox);
            this.addTab.Controls.Add(this.label4);
            this.addTab.Controls.Add(this.DBInitiativeTextBox);
            this.addTab.Controls.Add(this.label3);
            this.addTab.Controls.Add(this.DBACTextBox);
            this.addTab.Controls.Add(this.label2);
            this.addTab.Controls.Add(this.DBMaxHpTextBox);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.DBNameTextBox);
            this.addTab.Location = new System.Drawing.Point(4, 24);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(753, 124);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // DBCRTextBox
            // 
            this.DBCRTextBox.Location = new System.Drawing.Point(639, 18);
            this.DBCRTextBox.Name = "DBCRTextBox";
            this.DBCRTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBCRTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type";
            // 
            // DBTypeTextBox
            // 
            this.DBTypeTextBox.Location = new System.Drawing.Point(533, 18);
            this.DBTypeTextBox.Name = "DBTypeTextBox";
            this.DBTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBTypeTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PC (Y/N)";
            // 
            // DBPCTextBox
            // 
            this.DBPCTextBox.Location = new System.Drawing.Point(427, 18);
            this.DBPCTextBox.Name = "DBPCTextBox";
            this.DBPCTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBPCTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initiative Bonus";
            // 
            // DBInitiativeTextBox
            // 
            this.DBInitiativeTextBox.Location = new System.Drawing.Point(321, 18);
            this.DBInitiativeTextBox.Name = "DBInitiativeTextBox";
            this.DBInitiativeTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBInitiativeTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "AC";
            // 
            // DBACTextBox
            // 
            this.DBACTextBox.Location = new System.Drawing.Point(215, 18);
            this.DBACTextBox.Name = "DBACTextBox";
            this.DBACTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBACTextBox.TabIndex = 4;
            this.DBACTextBox.TextChanged += new System.EventHandler(this.DBACTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max HP";
            // 
            // DBMaxHpTextBox
            // 
            this.DBMaxHpTextBox.Location = new System.Drawing.Point(109, 17);
            this.DBMaxHpTextBox.Name = "DBMaxHpTextBox";
            this.DBMaxHpTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBMaxHpTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // DBNameTextBox
            // 
            this.DBNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.DBNameTextBox.Name = "DBNameTextBox";
            this.DBNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.DBNameTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "CR";
            // 
            // AddToDBButton
            // 
            this.AddToDBButton.Location = new System.Drawing.Point(330, 88);
            this.AddToDBButton.Name = "AddToDBButton";
            this.AddToDBButton.Size = new System.Drawing.Size(75, 23);
            this.AddToDBButton.TabIndex = 14;
            this.AddToDBButton.Text = "Add";
            this.AddToDBButton.UseVisualStyleBackColor = true;
            this.AddToDBButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RollInitiativeButton);
            this.Controls.Add(this.InitiativeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ModifierTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.EncounterListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox EncounterListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox ModifierTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button InitiativeButton;
        private System.Windows.Forms.Button RollInitiativeButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.TextBox DBCRTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DBTypeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DBPCTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBInitiativeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBACTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DBMaxHpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBNameTextBox;
        private System.Windows.Forms.Button AddToDBButton;
        private System.Windows.Forms.Label label7;
    }
}

