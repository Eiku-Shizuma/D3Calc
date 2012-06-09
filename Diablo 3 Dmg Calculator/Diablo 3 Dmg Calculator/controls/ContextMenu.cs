using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diablo_3_Dmg_Calculator.Models;
using Diablo_3_Dmg_Calculator.Operations;



namespace Diablo_3_Dmg_Calculator.controls
{
    public partial class ContextMenu : UserControl
    {


        public ContextMenu()
        {
            InitializeComponent();
        }

        private void Readdata(object sender, EventArgs e)
        {
            string attribute;
            double value;
            System.Drawing.Point loc;

            attribute = this.contextMenuAttributeComboBox.Text;
            value = Convert.ToDouble(this.contextMenuAttributeValueTextBox.Text);
            loc = Location;
            this.contextAddListView.Items.Add(Convert.ToString(loc));            
        }

        private void Close(object sender, MouseEventArgs e)
        {
            this.Visible = false;
        }
    }
}
 