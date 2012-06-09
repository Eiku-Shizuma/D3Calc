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
            form = main;
            InitializeComponent();
        }

        private void New(object sender, EventArgs e) 
        {
            MessageBox.Show("This should clear the whole form!\nDoes not do that yet though :(");
        }

        private void Save(object sender, EventArgs e) 
        {
            MessageBox.Show("Not yet Implemented!\nStill buggy on Manuels part");
            /*
            saveFileDialog1.Filter = "D3Cals Save File|*.sav";
            saveFileDialog1.Title = "Save a D3Calc File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    Xml.SaveXML.SaveCharacter(saveFileDialog1.FileName, form.Character);
                }
                catch (Exception)
                { 
                    MessageBox.Show("Fehler!");
                }
            }*/
        }

        private void Open(object sender, EventArgs e) 
        {
            MessageBox.Show("Not yet Implemented!\nManuel hasn't finished with the loading stuff");
            /*
            openFileDialog1.Filter = "D3Calc Save File|*.sav";
            openFileDialog1.Title = "Load a D3Calc file";
            openFileDialog1.ShowDialog();
            
            if (openFileDialog1.FileName != "") 
            { 
                //Put XML Loader here
            } 
            */
        }

        private void Credits(object sender, EventArgs e) 
        { 
            MessageBox.Show("There gonna be Credits real soon!"); 
        }
    }
}
