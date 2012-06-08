namespace Diablo_3_Dmg_Calculator
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.invHeadPanel = new System.Windows.Forms.Panel();
            this.invGlovesPanel = new System.Windows.Forms.Panel();
            this.invChestPanel = new System.Windows.Forms.Panel();
            this.invBracersPanel = new System.Windows.Forms.Panel();
            this.invRing1Panel = new System.Windows.Forms.Panel();
            this.invBeltPanel = new System.Windows.Forms.Panel();
            this.invRing2Panel = new System.Windows.Forms.Panel();
            this.invPantsPanel = new System.Windows.Forms.Panel();
            this.invMainPanel = new System.Windows.Forms.Panel();
            this.invBootPanel = new System.Windows.Forms.Panel();
            this.invOffPanel = new System.Windows.Forms.Panel();
            this.invShoulderPanel = new System.Windows.Forms.Panel();
            this.invNeckPanel = new System.Windows.Forms.Panel();
            this.inventoryCharNameTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.amuletPanel = new System.Windows.Forms.Panel();
            this.beltPanel = new System.Windows.Forms.Panel();
            this.chestPanel = new System.Windows.Forms.Panel();
            this.bracersPanel = new System.Windows.Forms.Panel();
            this.glovesPanel = new System.Windows.Forms.Panel();
            this.ring1Panel = new System.Windows.Forms.Panel();
            this.ring2Panel = new System.Windows.Forms.Panel();
            this.mainHandPanel = new System.Windows.Forms.Panel();
            this.bootsPanel = new System.Windows.Forms.Panel();
            this.pantsPanel = new System.Windows.Forms.Panel();
            this.shoulderPanel = new System.Windows.Forms.Panel();
            this.contextMenu1 = new Diablo_3_Dmg_Calculator.controls.ContextMenu();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barbarian",
            "Monk",
            "Demon Hunter",
            "Wizard",
            "Witch Doctor"});
            this.comboBox1.Location = new System.Drawing.Point(10, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Class";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboBox2.Location = new System.Drawing.Point(135, 44);
            this.comboBox2.MaxDropDownItems = 1;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Level";
            // 
            // invHeadPanel
            // 
            this.invHeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invHeadPanel.Location = new System.Drawing.Point(340, 10);
            this.invHeadPanel.Name = "invHeadPanel";
            this.invHeadPanel.Size = new System.Drawing.Size(70, 90);
            this.invHeadPanel.TabIndex = 2;
            this.invHeadPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invHeadPanel.MouseLeave += new System.EventHandler(this.HideHeadPanel);
            this.invHeadPanel.MouseHover += new System.EventHandler(this.ShowHeadPanel);
            // 
            // invGlovesPanel
            // 
            this.invGlovesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invGlovesPanel.Location = new System.Drawing.Point(220, 160);
            this.invGlovesPanel.Name = "invGlovesPanel";
            this.invGlovesPanel.Size = new System.Drawing.Size(80, 100);
            this.invGlovesPanel.TabIndex = 3;
            this.invGlovesPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invGlovesPanel.MouseLeave += new System.EventHandler(this.HideGlovesPanel);
            this.invGlovesPanel.MouseHover += new System.EventHandler(this.ShowGlovesPanel);
            // 
            // invChestPanel
            // 
            this.invChestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invChestPanel.Location = new System.Drawing.Point(335, 115);
            this.invChestPanel.Name = "invChestPanel";
            this.invChestPanel.Size = new System.Drawing.Size(80, 120);
            this.invChestPanel.TabIndex = 4;
            this.invChestPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invChestPanel.MouseLeave += new System.EventHandler(this.HideChestPanel);
            this.invChestPanel.MouseHover += new System.EventHandler(this.ShowChestPanel);
            // 
            // invBracersPanel
            // 
            this.invBracersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invBracersPanel.Location = new System.Drawing.Point(450, 160);
            this.invBracersPanel.Name = "invBracersPanel";
            this.invBracersPanel.Size = new System.Drawing.Size(80, 100);
            this.invBracersPanel.TabIndex = 4;
            this.invBracersPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invBracersPanel.MouseLeave += new System.EventHandler(this.HideBracersPanel);
            this.invBracersPanel.MouseHover += new System.EventHandler(this.ShowBracersPanel);
            // 
            // invRing1Panel
            // 
            this.invRing1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invRing1Panel.Location = new System.Drawing.Point(250, 281);
            this.invRing1Panel.Name = "invRing1Panel";
            this.invRing1Panel.Size = new System.Drawing.Size(40, 40);
            this.invRing1Panel.TabIndex = 4;
            this.invRing1Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invRing1Panel.MouseLeave += new System.EventHandler(this.HideRing1Panel);
            this.invRing1Panel.MouseHover += new System.EventHandler(this.ShowRing1Panel);
            // 
            // invBeltPanel
            // 
            this.invBeltPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invBeltPanel.Location = new System.Drawing.Point(335, 250);
            this.invBeltPanel.Name = "invBeltPanel";
            this.invBeltPanel.Size = new System.Drawing.Size(80, 30);
            this.invBeltPanel.TabIndex = 5;
            this.invBeltPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invBeltPanel.MouseLeave += new System.EventHandler(this.HideBeltPanel);
            this.invBeltPanel.MouseHover += new System.EventHandler(this.ShowBeltPanel);
            // 
            // invRing2Panel
            // 
            this.invRing2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invRing2Panel.Location = new System.Drawing.Point(460, 281);
            this.invRing2Panel.Name = "invRing2Panel";
            this.invRing2Panel.Size = new System.Drawing.Size(40, 40);
            this.invRing2Panel.TabIndex = 4;
            this.invRing2Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invRing2Panel.MouseLeave += new System.EventHandler(this.HideRing2Panel);
            this.invRing2Panel.MouseHover += new System.EventHandler(this.ShowRing2Panel);
            // 
            // invPantsPanel
            // 
            this.invPantsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invPantsPanel.Location = new System.Drawing.Point(340, 295);
            this.invPantsPanel.Name = "invPantsPanel";
            this.invPantsPanel.Size = new System.Drawing.Size(70, 90);
            this.invPantsPanel.TabIndex = 6;
            this.invPantsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invPantsPanel.MouseLeave += new System.EventHandler(this.HidePantsPanel);
            this.invPantsPanel.MouseHover += new System.EventHandler(this.ShowPantsPanel);
            // 
            // invMainPanel
            // 
            this.invMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invMainPanel.Location = new System.Drawing.Point(220, 350);
            this.invMainPanel.Name = "invMainPanel";
            this.invMainPanel.Size = new System.Drawing.Size(80, 120);
            this.invMainPanel.TabIndex = 5;
            this.invMainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            // 
            // invBootPanel
            // 
            this.invBootPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invBootPanel.Location = new System.Drawing.Point(340, 400);
            this.invBootPanel.Name = "invBootPanel";
            this.invBootPanel.Size = new System.Drawing.Size(70, 90);
            this.invBootPanel.TabIndex = 7;
            this.invBootPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invBootPanel.MouseLeave += new System.EventHandler(this.HideBootsPanel);
            this.invBootPanel.MouseHover += new System.EventHandler(this.ShowBootsPanel);
            // 
            // invOffPanel
            // 
            this.invOffPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invOffPanel.Location = new System.Drawing.Point(450, 350);
            this.invOffPanel.Name = "invOffPanel";
            this.invOffPanel.Size = new System.Drawing.Size(80, 120);
            this.invOffPanel.TabIndex = 7;
            this.invOffPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            // 
            // invShoulderPanel
            // 
            this.invShoulderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invShoulderPanel.Location = new System.Drawing.Point(250, 55);
            this.invShoulderPanel.Name = "invShoulderPanel";
            this.invShoulderPanel.Size = new System.Drawing.Size(70, 90);
            this.invShoulderPanel.TabIndex = 8;
            this.invShoulderPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invShoulderPanel.MouseLeave += new System.EventHandler(this.HideShoulderPanel);
            this.invShoulderPanel.MouseHover += new System.EventHandler(this.ShowShoulderPanel);
            // 
            // invNeckPanel
            // 
            this.invNeckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invNeckPanel.Location = new System.Drawing.Point(440, 65);
            this.invNeckPanel.Name = "invNeckPanel";
            this.invNeckPanel.Size = new System.Drawing.Size(60, 60);
            this.invNeckPanel.TabIndex = 9;
            this.invNeckPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContextMenuControl);
            this.invNeckPanel.MouseLeave += new System.EventHandler(this.HideAmuletPanel);
            this.invNeckPanel.MouseHover += new System.EventHandler(this.ShowAmuletPanel);
            // 
            // inventoryCharNameTextBox
            // 
            this.inventoryCharNameTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryCharNameTextBox.Location = new System.Drawing.Point(10, 10);
            this.inventoryCharNameTextBox.Name = "inventoryCharNameTextBox";
            this.inventoryCharNameTextBox.Size = new System.Drawing.Size(180, 24);
            this.inventoryCharNameTextBox.TabIndex = 10;
            this.inventoryCharNameTextBox.Text = "Char Name";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "78"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 97);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(180, 116);
            this.checkedListBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Passiv Skills";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(10, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Protection Shrine";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(10, 246);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 21);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Frenzie Shrine";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(10, 273);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(109, 21);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Fortune Shrine";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(10, 300);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(134, 21);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Enlightment Shrine";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(560, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "DPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(560, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(560, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Min Dmg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Max Dmg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(560, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Armor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(622, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(622, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(622, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(622, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(622, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "label11";
            // 
            // headPanel
            // 
            this.headPanel.AutoSize = true;
            this.headPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headPanel.BackColor = System.Drawing.Color.Transparent;
            this.headPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headPanel.ForeColor = System.Drawing.Color.Cyan;
            this.headPanel.Location = new System.Drawing.Point(410, 10);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(0, 0);
            this.headPanel.TabIndex = 32;
            this.headPanel.Visible = false;
            // 
            // amuletPanel
            // 
            this.amuletPanel.AutoSize = true;
            this.amuletPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.amuletPanel.BackColor = System.Drawing.Color.Transparent;
            this.amuletPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.amuletPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amuletPanel.ForeColor = System.Drawing.Color.Cyan;
            this.amuletPanel.Location = new System.Drawing.Point(500, 65);
            this.amuletPanel.Name = "amuletPanel";
            this.amuletPanel.Size = new System.Drawing.Size(0, 0);
            this.amuletPanel.TabIndex = 34;
            this.amuletPanel.Visible = false;
            // 
            // beltPanel
            // 
            this.beltPanel.AutoSize = true;
            this.beltPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.beltPanel.BackColor = System.Drawing.Color.Transparent;
            this.beltPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beltPanel.ForeColor = System.Drawing.Color.Cyan;
            this.beltPanel.Location = new System.Drawing.Point(415, 250);
            this.beltPanel.Name = "beltPanel";
            this.beltPanel.Size = new System.Drawing.Size(0, 0);
            this.beltPanel.TabIndex = 35;
            this.beltPanel.Visible = false;
            // 
            // chestPanel
            // 
            this.chestPanel.AutoSize = true;
            this.chestPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chestPanel.BackColor = System.Drawing.Color.Transparent;
            this.chestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chestPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestPanel.ForeColor = System.Drawing.Color.Cyan;
            this.chestPanel.Location = new System.Drawing.Point(415, 115);
            this.chestPanel.Name = "chestPanel";
            this.chestPanel.Size = new System.Drawing.Size(0, 0);
            this.chestPanel.TabIndex = 36;
            this.chestPanel.Visible = false;
            // 
            // bracersPanel
            // 
            this.bracersPanel.AutoSize = true;
            this.bracersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bracersPanel.BackColor = System.Drawing.Color.Transparent;
            this.bracersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bracersPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracersPanel.ForeColor = System.Drawing.Color.Cyan;
            this.bracersPanel.Location = new System.Drawing.Point(530, 160);
            this.bracersPanel.Name = "bracersPanel";
            this.bracersPanel.Size = new System.Drawing.Size(0, 0);
            this.bracersPanel.TabIndex = 37;
            this.bracersPanel.Visible = false;
            // 
            // glovesPanel
            // 
            this.glovesPanel.AutoSize = true;
            this.glovesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glovesPanel.BackColor = System.Drawing.Color.Transparent;
            this.glovesPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glovesPanel.ForeColor = System.Drawing.Color.Cyan;
            this.glovesPanel.Location = new System.Drawing.Point(300, 160);
            this.glovesPanel.Name = "glovesPanel";
            this.glovesPanel.Size = new System.Drawing.Size(0, 0);
            this.glovesPanel.TabIndex = 38;
            this.glovesPanel.Visible = false;
            // 
            // ring1Panel
            // 
            this.ring1Panel.AutoSize = true;
            this.ring1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ring1Panel.BackColor = System.Drawing.Color.Transparent;
            this.ring1Panel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ring1Panel.ForeColor = System.Drawing.Color.Cyan;
            this.ring1Panel.Location = new System.Drawing.Point(290, 281);
            this.ring1Panel.Name = "ring1Panel";
            this.ring1Panel.Size = new System.Drawing.Size(0, 0);
            this.ring1Panel.TabIndex = 39;
            this.ring1Panel.Visible = false;
            // 
            // ring2Panel
            // 
            this.ring2Panel.AutoSize = true;
            this.ring2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ring2Panel.BackColor = System.Drawing.Color.Transparent;
            this.ring2Panel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ring2Panel.ForeColor = System.Drawing.Color.Cyan;
            this.ring2Panel.Location = new System.Drawing.Point(500, 281);
            this.ring2Panel.Name = "ring2Panel";
            this.ring2Panel.Size = new System.Drawing.Size(0, 0);
            this.ring2Panel.TabIndex = 40;
            this.ring2Panel.Visible = false;
            // 
            // mainHandPanel
            // 
            this.mainHandPanel.AutoSize = true;
            this.mainHandPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainHandPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainHandPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHandPanel.ForeColor = System.Drawing.Color.Cyan;
            this.mainHandPanel.Location = new System.Drawing.Point(300, 350);
            this.mainHandPanel.Name = "mainHandPanel";
            this.mainHandPanel.Size = new System.Drawing.Size(0, 0);
            this.mainHandPanel.TabIndex = 41;
            this.mainHandPanel.Visible = false;
            // 
            // bootsPanel
            // 
            this.bootsPanel.AutoSize = true;
            this.bootsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootsPanel.BackColor = System.Drawing.Color.Transparent;
            this.bootsPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootsPanel.ForeColor = System.Drawing.Color.Cyan;
            this.bootsPanel.Location = new System.Drawing.Point(410, 400);
            this.bootsPanel.Name = "bootsPanel";
            this.bootsPanel.Size = new System.Drawing.Size(0, 0);
            this.bootsPanel.TabIndex = 43;
            this.bootsPanel.Visible = false;
            // 
            // pantsPanel
            // 
            this.pantsPanel.AutoSize = true;
            this.pantsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pantsPanel.BackColor = System.Drawing.Color.Transparent;
            this.pantsPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantsPanel.ForeColor = System.Drawing.Color.Cyan;
            this.pantsPanel.Location = new System.Drawing.Point(410, 295);
            this.pantsPanel.Name = "pantsPanel";
            this.pantsPanel.Size = new System.Drawing.Size(0, 0);
            this.pantsPanel.TabIndex = 44;
            this.pantsPanel.Visible = false;
            // 
            // shoulderPanel
            // 
            this.shoulderPanel.AutoSize = true;
            this.shoulderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shoulderPanel.BackColor = System.Drawing.Color.Transparent;
            this.shoulderPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoulderPanel.ForeColor = System.Drawing.Color.Cyan;
            this.shoulderPanel.Location = new System.Drawing.Point(320, 55);
            this.shoulderPanel.Name = "shoulderPanel";
            this.shoulderPanel.Size = new System.Drawing.Size(0, 0);
            this.shoulderPanel.TabIndex = 33;
            this.shoulderPanel.Visible = false;
            // 
            // contextMenu1
            // 
            this.contextMenu1.BackColor = System.Drawing.Color.Silver;
            this.contextMenu1.Location = new System.Drawing.Point(551, 236);
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(156, 231);
            this.contextMenu1.TabIndex = 45;
            this.contextMenu1.Visible = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.contextMenu1);
            this.Controls.Add(this.pantsPanel);
            this.Controls.Add(this.bootsPanel);
            this.Controls.Add(this.mainHandPanel);
            this.Controls.Add(this.ring2Panel);
            this.Controls.Add(this.ring1Panel);
            this.Controls.Add(this.glovesPanel);
            this.Controls.Add(this.bracersPanel);
            this.Controls.Add(this.chestPanel);
            this.Controls.Add(this.beltPanel);
            this.Controls.Add(this.amuletPanel);
            this.Controls.Add(this.shoulderPanel);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.inventoryCharNameTextBox);
            this.Controls.Add(this.invNeckPanel);
            this.Controls.Add(this.invShoulderPanel);
            this.Controls.Add(this.invOffPanel);
            this.Controls.Add(this.invBootPanel);
            this.Controls.Add(this.invMainPanel);
            this.Controls.Add(this.invPantsPanel);
            this.Controls.Add(this.invRing2Panel);
            this.Controls.Add(this.invBeltPanel);
            this.Controls.Add(this.invRing1Panel);
            this.Controls.Add(this.invBracersPanel);
            this.Controls.Add(this.invChestPanel);
            this.Controls.Add(this.invGlovesPanel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.invHeadPanel);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(710, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel invHeadPanel;
        private System.Windows.Forms.Panel invGlovesPanel;
        private System.Windows.Forms.Panel invChestPanel;
        private System.Windows.Forms.Panel invBracersPanel;
        private System.Windows.Forms.Panel invRing1Panel;
        private System.Windows.Forms.Panel invBeltPanel;
        private System.Windows.Forms.Panel invRing2Panel;
        private System.Windows.Forms.Panel invPantsPanel;
        private System.Windows.Forms.Panel invMainPanel;
        private System.Windows.Forms.Panel invBootPanel;
        private System.Windows.Forms.Panel invOffPanel;
        private System.Windows.Forms.Panel invShoulderPanel;
        private System.Windows.Forms.Panel invNeckPanel;
        private System.Windows.Forms.TextBox inventoryCharNameTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel amuletPanel;
        private System.Windows.Forms.Panel beltPanel;
        private System.Windows.Forms.Panel chestPanel;
        private System.Windows.Forms.Panel bracersPanel;
        private System.Windows.Forms.Panel glovesPanel;
        private System.Windows.Forms.Panel ring1Panel;
        private System.Windows.Forms.Panel ring2Panel;
        private System.Windows.Forms.Panel mainHandPanel;
        private System.Windows.Forms.Panel bootsPanel;
        private System.Windows.Forms.Panel pantsPanel;
        private System.Windows.Forms.Panel shoulderPanel;
        private controls.ContextMenu contextMenu1;
    }
}
