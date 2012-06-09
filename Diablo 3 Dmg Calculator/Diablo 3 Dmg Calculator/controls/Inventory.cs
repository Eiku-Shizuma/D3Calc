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

            foreach (var item in form.Controls)
            {
                if (item.GetType() == typeof(Statistics))
                {
                    stat = (Statistics)item;
                }
            }

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

        private void AddClass(object sender, EventArgs e)
        {
            stat.Stats();
            form.Character.Character = this.invClassComboBox.SelectedIndex;
            if (form.Character.Character < 2) 
            {
                form.Character.Str = 10;
                form.Character.Dex = 8;
                form.Character.Inte = 8;
            }
            else if (form.Character.Character > 3)
            {
                form.Character.Str = 8;
                form.Character.Dex = 8;
                form.Character.Inte = 10;
            }
            else 
            {
                form.Character.Str = 8;
                form.Character.Dex = 10;
                form.Character.Inte = 8;
            }
            form.Character.Vit = 9;

        }

        private void AddLevel()
        {
            stat.Stats();
            form.Character.Lvl = Convert.ToInt32(this.invLvlcomboBox);
            form.Character.Vit += form.Character.Lvl * 2;
            if (form.Character.Character < 2)
            {
                form.Character.Str += form.Character.Lvl * 3;
                form.Character.Dex += form.Character.Lvl;
                form.Character.Inte += form.Character.Lvl;
            }
            else if (form.Character.Character > 3)
            {
                form.Character.Str += form.Character.Lvl;
                form.Character.Dex += form.Character.Lvl;
                form.Character.Inte += form.Character.Lvl*3;
            }
            else
            {
                form.Character.Str += form.Character.Lvl;
                form.Character.Dex += form.Character.Lvl*3;
                form.Character.Inte += form.Character.Lvl;
            }
        }

        private void AddClass()
        {

        }
    }
}
