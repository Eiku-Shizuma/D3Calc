namespace Diablo_3_Dmg_Calculator
{
    partial class MainBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBar));
            this.mainBarFileLabel = new System.Windows.Forms.Label();
            this.mainBarSaveLabel = new System.Windows.Forms.Label();
            this.mainBarLoadLabel = new System.Windows.Forms.Label();
            this.mainBarCreditsLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mainBarFileLabel
            // 
            this.mainBarFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarFileLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarFileLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarFileLabel.Image")));
            this.mainBarFileLabel.Location = new System.Drawing.Point(4, 3);
            this.mainBarFileLabel.Name = "mainBarFileLabel";
            this.mainBarFileLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarFileLabel.TabIndex = 0;
            this.mainBarFileLabel.Text = "New";
            this.mainBarFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBarFileLabel.Click += new System.EventHandler(this.New);
            // 
            // mainBarSaveLabel
            // 
            this.mainBarSaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarSaveLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarSaveLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarSaveLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarSaveLabel.Image")));
            this.mainBarSaveLabel.Location = new System.Drawing.Point(85, 3);
            this.mainBarSaveLabel.Name = "mainBarSaveLabel";
            this.mainBarSaveLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarSaveLabel.TabIndex = 1;
            this.mainBarSaveLabel.Text = "Save";
            this.mainBarSaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBarSaveLabel.Click += new System.EventHandler(this.Save);
            // 
            // mainBarLoadLabel
            // 
            this.mainBarLoadLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarLoadLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarLoadLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarLoadLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarLoadLabel.Image")));
            this.mainBarLoadLabel.Location = new System.Drawing.Point(166, 3);
            this.mainBarLoadLabel.Name = "mainBarLoadLabel";
            this.mainBarLoadLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarLoadLabel.TabIndex = 2;
            this.mainBarLoadLabel.Text = "Load";
            this.mainBarLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBarLoadLabel.Click += new System.EventHandler(this.Open);
            // 
            // mainBarCreditsLabel
            // 
            this.mainBarCreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarCreditsLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarCreditsLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarCreditsLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarCreditsLabel.Image")));
            this.mainBarCreditsLabel.Location = new System.Drawing.Point(247, 3);
            this.mainBarCreditsLabel.Name = "mainBarCreditsLabel";
            this.mainBarCreditsLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarCreditsLabel.TabIndex = 3;
            this.mainBarCreditsLabel.Text = "Credits";
            this.mainBarCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBarCreditsLabel.Click += new System.EventHandler(this.Credits);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.mainBarCreditsLabel);
            this.Controls.Add(this.mainBarLoadLabel);
            this.Controls.Add(this.mainBarSaveLabel);
            this.Controls.Add(this.mainBarFileLabel);
            this.Name = "MainBar";
            this.Size = new System.Drawing.Size(1008, 335);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainBarFileLabel;
        private System.Windows.Forms.Label mainBarSaveLabel;
        private System.Windows.Forms.Label mainBarLoadLabel;
        private System.Windows.Forms.Label mainBarCreditsLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
