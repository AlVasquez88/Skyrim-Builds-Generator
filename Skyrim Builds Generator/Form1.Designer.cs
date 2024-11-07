namespace Skyrim_Builds_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxMajorSkills = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxMinorSkills = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxBuildClasses = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxCharacterDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateCharacter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRace);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Race";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.AutoCompleteCustomSource.AddRange(new string[] {
            "Argonian",
            "Altmer",
            "Bosmer",
            "Breton",
            "Dunmer",
            "Imperial",
            "Khajiit",
            "Nord",
            "Orc",
            "Redguard"});
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Argonian",
            "Altmer",
            "Breton",
            "Dunmer",
            "Orc",
            "Bosmer",
            "Nord",
            "Redguard",
            "Khajiit",
            "Imperial"});
            this.comboBoxRace.Location = new System.Drawing.Point(6, 35);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(188, 24);
            this.comboBoxRace.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxMajorSkills);
            this.groupBox2.Location = new System.Drawing.Point(236, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Major Skills";
            // 
            // checkedListBoxMajorSkills
            // 
            this.checkedListBoxMajorSkills.CheckOnClick = true;
            this.checkedListBoxMajorSkills.FormattingEnabled = true;
            this.checkedListBoxMajorSkills.Items.AddRange(new object[] {
            "Alteration",
            "Conjuration",
            "Destruction",
            "Illusion",
            "Restoration",
            "One-Handed",
            "Two-Handed",
            "Heavy Armor",
            "Light Armor",
            "Block",
            "Archery",
            "Sneak",
            "Speechcraft",
            "Alchemy",
            "Smithing",
            "Enchanting"});
            this.checkedListBoxMajorSkills.Location = new System.Drawing.Point(6, 35);
            this.checkedListBoxMajorSkills.Name = "checkedListBoxMajorSkills";
            this.checkedListBoxMajorSkills.Size = new System.Drawing.Size(188, 276);
            this.checkedListBoxMajorSkills.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBoxMinorSkills);
            this.groupBox3.Location = new System.Drawing.Point(489, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 322);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minor Skills";
            // 
            // checkedListBoxMinorSkills
            // 
            this.checkedListBoxMinorSkills.FormattingEnabled = true;
            this.checkedListBoxMinorSkills.Items.AddRange(new object[] {
            "Alteration",
            "Conjuration",
            "Destruction",
            "Illusion",
            "Restoration",
            "One-Handed",
            "Two-Handed",
            "Heavy Armor",
            "Light Armor",
            "Block",
            "Archery",
            "Sneak",
            "Speechcraft",
            "Alchemy",
            "Smithing",
            "Enchanting"});
            this.checkedListBoxMinorSkills.Location = new System.Drawing.Point(6, 35);
            this.checkedListBoxMinorSkills.Name = "checkedListBoxMinorSkills";
            this.checkedListBoxMinorSkills.Size = new System.Drawing.Size(188, 276);
            this.checkedListBoxMinorSkills.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxBuildClasses);
            this.groupBox4.Location = new System.Drawing.Point(734, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 322);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Build Classes";
            // 
            // listBoxBuildClasses
            // 
            this.listBoxBuildClasses.FormattingEnabled = true;
            this.listBoxBuildClasses.ItemHeight = 16;
            this.listBoxBuildClasses.Items.AddRange(new object[] {
            "Acrobat",
            "Agent",
            "Archer",
            "Assassin",
            "Barbarian",
            "Bard",
            "BattleMage",
            "Crusader",
            "Healer",
            "Knight",
            "Mage",
            "Monk",
            "Nightblade",
            "Pilgrim",
            "Rogue",
            "Scout",
            "Sorcerer",
            "Spellsword",
            "Thief",
            "Warrior",
            "Witchhunter"});
            this.listBoxBuildClasses.Location = new System.Drawing.Point(6, 35);
            this.listBoxBuildClasses.Name = "listBoxBuildClasses";
            this.listBoxBuildClasses.Size = new System.Drawing.Size(188, 276);
            this.listBoxBuildClasses.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxName);
            this.groupBox5.Location = new System.Drawing.Point(12, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 80);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // listBoxCharacterDetails
            // 
            this.listBoxCharacterDetails.FormattingEnabled = true;
            this.listBoxCharacterDetails.ItemHeight = 16;
            this.listBoxCharacterDetails.Location = new System.Drawing.Point(19, 516);
            this.listBoxCharacterDetails.Name = "listBoxCharacterDetails";
            this.listBoxCharacterDetails.Size = new System.Drawing.Size(910, 84);
            this.listBoxCharacterDetails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Character Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "The Elder Scrolls V Skyrim Character Build Generator";
            // 
            // buttonCreateCharacter
            // 
            this.buttonCreateCharacter.Location = new System.Drawing.Point(24, 620);
            this.buttonCreateCharacter.Name = "buttonCreateCharacter";
            this.buttonCreateCharacter.Size = new System.Drawing.Size(140, 38);
            this.buttonCreateCharacter.TabIndex = 7;
            this.buttonCreateCharacter.Text = "Create Character";
            this.buttonCreateCharacter.UseVisualStyleBackColor = true;
            this.buttonCreateCharacter.Click += new System.EventHandler(this.buttonCreateCharacter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(198, 621);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 37);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(373, 620);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 37);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(177, 26);
            this.toolStripMenuItemSave.Text = "Save Ctrl + C";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(177, 26);
            this.toolStripMenuItemExit.Text = "Exit Esc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 688);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCreateCharacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCharacterDetails);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Skyrim Builds Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.CheckedListBox checkedListBoxMajorSkills;
        private System.Windows.Forms.CheckedListBox checkedListBoxMinorSkills;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxBuildClasses;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxCharacterDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateCharacter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

