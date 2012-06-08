using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diablo_3_Dmg_Calculator.Operations;
using Diablo_3_Dmg_Calculator.controls;


namespace Diablo_3_Dmg_Calculator
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
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

        public void AddAttribute() 
        {
            string value;
            string Attri;

            Attri = this.contextMenu1.contextMenuAttributeComboBox.SelectedItem.ToString();
            value = this.contextMenu1.contextMenuAttributeValueTextBox.ToString();
        }
    }
}
