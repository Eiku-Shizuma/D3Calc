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
        public Statistics stat;
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

        private void AddLevel(object sender, EventArgs e)
        {
            form.Character.Character = this.invClassComboBox.SelectedIndex + 1;
            form.Character.Lvl = this.invLvlcomboBox.SelectedIndex;

            form.Character.Vit = 9 + form.Character.Lvl * 2;
            if (form.Character.Character < 2)
            {
                form.Character.Str = 10+form.Character.Lvl * 3;
                form.Character.Dex = 8+form.Character.Lvl;
                form.Character.Inte = 8+form.Character.Lvl;
            }
            else if (form.Character.Character > 3)
            {
                form.Character.Str = 8+form.Character.Lvl;
                form.Character.Dex = 8+form.Character.Lvl;
                form.Character.Inte = 10+form.Character.Lvl*3;
            }
            else
            {
                form.Character.Str = 8+form.Character.Lvl;
                form.Character.Dex = 10+form.Character.Lvl*3;
                form.Character.Inte = 8+form.Character.Lvl;
            }
            if (form.Character.Character > 0)
            {
                stat = RefreshStats();
                stat.Stats();
            }
        }

        private Statistics RefreshStats()
        {
            foreach (var item in form.Controls)
            {
                if (item.GetType() == typeof(Statistics))
                {
                    stat = (Statistics)item;
                }
            }
            return stat;
        }
    }
}
