using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diablo_3_Dmg_Calculator.Models;


namespace Diablo_3_Dmg_Calculator
{
    public partial class Inventory : UserControl
    {
        public MainForm form;
        public Inventory(MainForm main)
        {
            form = main;
            InitializeComponent();
        }

        private void ContextMenuControl(object sender, MouseEventArgs e) 
        {
            Panel panel = (Panel)sender;
            System.Drawing.Point i = panel.Location;

            i.X += panel.Size.Width;

            this.contextMenu1.Visible = false;
            if (i.Y > 271) { i.Y = 271; }
            this.contextMenu1.Location = i;
            this.contextMenu1.Visible = true;

        }

        private void AddName() 
        {
            form.Character.Name = Convert.ToString(this.inventoryCharNameTextBox);
        }

        private void AddClass()
        {
            form.Character.Character = this.invClassComboBox.SelectedIndex;
            if (form.Character.Character < 2) 
            { 
            }
            else if(form.Character.Character > 3)
            {

            }
            else
            form.Character.Str = 9;

        }

        private void AddLevel()
        {
            form.Character.Lvl = Convert.ToInt32(this.invLvlcomboBox);
        }
    }
}
