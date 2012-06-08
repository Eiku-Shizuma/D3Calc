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
            this.inventory1 = new Diablo_3_Dmg_Calculator.Inventory();
            this.SuspendLayout();
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.Silver;
            this.inventory1.Location = new System.Drawing.Point(0, 30);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(710, 502);
            this.inventory1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 530);
            this.Controls.Add(this.inventory1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Diablo 3 Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Inventory inventory1;









    }
}

