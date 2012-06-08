using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diablo_3_Dmg_Calculator.Operations;


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
            i.X += 10;
            i.Y += 10;

            if (this.contextMenu1.Visible == true)
            {
                this.contextMenu1.Visible = false;
            }
            else 
            {
                this.contextMenu1.Location = i;
                this.contextMenu1.Visible = true;
            }
        }


        private void ShowHeadPanel(object sender, EventArgs e)
        {
            this.headPanel.Visible = true;
        }

        private void HideHeadPanel(object sender, EventArgs e)
        {
            this.headPanel.Visible = false;
        }

        private void ShowAmuletPanel(object sender, EventArgs e)
        {
            this.amuletPanel.Visible = true;
        }

        private void HideAmuletPanel(object sender, EventArgs e)
        {
            this.amuletPanel.Visible = false;
        }

        private void ShowShoulderPanel(object sender, EventArgs e)
        {
            this.shoulderPanel.Visible = true;
        }

        private void HideShoulderPanel(object sender, EventArgs e)
        {
            this.shoulderPanel.Visible = false;
        }

        private void ShowChestPanel(object sender, EventArgs e)
        {
            this.chestPanel.Visible = true;
        }

        private void HideChestPanel(object sender, EventArgs e)
        {
            this.chestPanel.Visible = false;
        }

        private void ShowGlovesPanel(object sender, EventArgs e)
        {
            this.glovesPanel.Visible = true;
        }

        private void HideGlovesPanel(object sender, EventArgs e)
        {
            this.glovesPanel.Visible = false;
        }

        private void ShowBeltPanel(object sender, EventArgs e)
        {
            this.beltPanel.Visible = true;
        }

        private void HideBeltPanel(object sender, EventArgs e)
        {
            this.beltPanel.Visible = false;
        }

        private void ShowBracersPanel(object sender, EventArgs e)
        {
            this.bracersPanel.Visible = true;
        }

        private void HideBracersPanel(object sender, EventArgs e)
        {
            this.bracersPanel.Visible = false;
        }

        private void ShowPantsPanel(object sender, EventArgs e)
        {
            this.pantsPanel.Visible = true;
        }

        private void HidePantsPanel(object sender, EventArgs e)
        {
            this.pantsPanel.Visible = false;
        }

        private void ShowBootsPanel(object sender, EventArgs e)
        {
            this.bootsPanel.Visible = true;
        }

        private void HideBootsPanel(object sender, EventArgs e)
        {
            this.bootsPanel.Visible = false;
        }

        private void ShowMainPanel(object sender, EventArgs e)
        {
            this.mainHandPanel.Visible = true;
        }

        private void HideMainPanel(object sender, EventArgs e)
        {
            this.mainHandPanel.Visible = false;
        }

        private void ShowOffPanel(object sender, EventArgs e)
        {
            this.offHandPanel.Visible = true;
        }

        private void HideOffPanel(object sender, EventArgs e)
        {
            this.offHandPanel.Visible = false;
        }

        private void ShowRing1Panel(object sender, EventArgs e)
        {
            this.ring1Panel.Visible = true;
        }

        private void HideRing1Panel(object sender, EventArgs e)
        {
            this.ring1Panel.Visible = false;
        }

        private void ShowRing2Panel(object sender, EventArgs e)
        {
            this.ring2Panel.Visible = true;
        }

        private void HideRing2Panel(object sender, EventArgs e)
        {
            this.ring2Panel.Visible = false;
        }

        private void ContextMenuControl()
        {

        }
    }
}
