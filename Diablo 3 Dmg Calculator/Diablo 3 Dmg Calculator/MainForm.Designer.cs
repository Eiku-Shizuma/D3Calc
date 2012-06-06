namespace Diablo_3_Dmg_Calculator
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statistics1 = new Diablo_3_Dmg_Calculator.Statistics();
            this.mainBar1 = new Diablo_3_Dmg_Calculator.MainBar();
            this.inventory1 = new Diablo_3_Dmg_Calculator.Inventory();
            this.SuspendLayout();
            // 
            // statistics1
            // 
            this.statistics1.BackColor = System.Drawing.Color.Transparent;
            this.statistics1.Location = new System.Drawing.Point(710, 30);
            this.statistics1.Name = "statistics1";
            this.statistics1.Size = new System.Drawing.Size(302, 502);
            this.statistics1.TabIndex = 2;
            // 
            // mainBar1
            // 
            this.mainBar1.BackColor = System.Drawing.Color.Transparent;
            this.mainBar1.Location = new System.Drawing.Point(0, 0);
            this.mainBar1.Name = "mainBar1";
            this.mainBar1.Size = new System.Drawing.Size(1008, 30);
            this.mainBar1.TabIndex = 1;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.Transparent;
            this.inventory1.Location = new System.Drawing.Point(0, 30);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(710, 502);
            this.inventory1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 530);
            this.Controls.Add(this.statistics1);
            this.Controls.Add(this.mainBar1);
            this.Controls.Add(this.inventory1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Diablo 3 Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Inventory inventory1;
        private MainBar mainBar1;
        private Statistics statistics1;




    }
}

