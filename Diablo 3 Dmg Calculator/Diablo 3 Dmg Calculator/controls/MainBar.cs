using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diablo_3_Dmg_Calculator.Xml;
using Diablo_3_Dmg_Calculator.Models;

namespace Diablo_3_Dmg_Calculator
{
    public partial class MainBar : UserControl
    {
        public MainForm form;
        public MainBar(MainForm main)
        {
            InitializeComponent();
        }

        private void New() 
        { 
        
        }

        private void Save() 
        {
            string path = null;
            Xml.SaveXML.SaveCharacter(path, form.Character);        
        }
    }
}
