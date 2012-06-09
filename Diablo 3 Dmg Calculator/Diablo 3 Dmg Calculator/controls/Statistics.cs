using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diablo_3_Dmg_Calculator
{
    public partial class Statistics : UserControl
    {
        public MainForm form;

        public Statistics(MainForm main)
        {
            InitializeComponent();
        }

        public void Stats()         
        {
            this.statMainStrLabel.Text = Convert.ToString(form.Character.Str);
            this.statMainDexLabel.Text = Convert.ToString(form.Character.Dex);
            this.statMainIntLabel.Text = Convert.ToString(form.Character.Inte);
            this.StatMainVitLabel.Text = Convert.ToString(form.Character.Vit);        
        }
    }
}
