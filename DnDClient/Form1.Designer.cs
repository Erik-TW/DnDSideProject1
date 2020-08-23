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
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.EncounterListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ModifierTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HealButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InitiativeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 15;
            this.SearchListBox.Location = new System.Drawing.Point(40, 39);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(330, 274);
            this.SearchListBox.TabIndex = 0;
            // 
            // EncounterListBox
            // 
            this.EncounterListBox.FormattingEnabled = true;
            this.EncounterListBox.ItemHeight = 15;
            this.EncounterListBox.Location = new System.Drawing.Point(437, 39);
            this.EncounterListBox.Name = "EncounterListBox";
            this.EncounterListBox.Size = new System.Drawing.Size(330, 274);
            this.EncounterListBox.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(86, 363);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(177, 23);
            this.SearchTextBox.TabIndex = 1;
            // 
            // ModifierTextBox
            // 
            this.ModifierTextBox.Location = new System.Drawing.Point(482, 362);
            this.ModifierTextBox.Name = "ModifierTextBox";
            this.ModifierTextBox.Size = new System.Drawing.Size(177, 23);
            this.ModifierTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(86, 415);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(188, 415);
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
            this.RemoveButton.Location = new System.Drawing.Point(689, 362);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InitiativeButton
            // 
            this.InitiativeButton.Location = new System.Drawing.Point(689, 415);
            this.InitiativeButton.Name = "InitiativeButton";
            this.InitiativeButton.Size = new System.Drawing.Size(85, 23);
            this.InitiativeButton.TabIndex = 7;
            this.InitiativeButton.Text = "Set Initiative";
            this.InitiativeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InitiativeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ModifierTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.EncounterListBox);
            this.Controls.Add(this.SearchListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.ListBox EncounterListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox ModifierTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button InitiativeButton;
    }
}

