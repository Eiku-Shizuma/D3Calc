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
            this.mainBarEditLabel = new System.Windows.Forms.Label();
            this.mainBarHelpLabel = new System.Windows.Forms.Label();
            this.mainBarCreditsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainBarFileLabel
            // 
            this.mainBarFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarFileLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarFileLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarFileLabel.Image")));
            this.mainBarFileLabel.Location = new System.Drawing.Point(4, 3);
            this.mainBarFileLabel.Name = "mainBarFileLabel";
            this.mainBarFileLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarFileLabel.TabIndex = 0;
            this.mainBarFileLabel.Text = "File";
            this.mainBarFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainBarEditLabel
            // 
            this.mainBarEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarEditLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarEditLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarEditLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarEditLabel.Image")));
            this.mainBarEditLabel.Location = new System.Drawing.Point(85, 3);
            this.mainBarEditLabel.Name = "mainBarEditLabel";
            this.mainBarEditLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarEditLabel.TabIndex = 1;
            this.mainBarEditLabel.Text = "Edit";
            this.mainBarEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainBarHelpLabel
            // 
            this.mainBarHelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarHelpLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarHelpLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarHelpLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarHelpLabel.Image")));
            this.mainBarHelpLabel.Location = new System.Drawing.Point(166, 3);
            this.mainBarHelpLabel.Name = "mainBarHelpLabel";
            this.mainBarHelpLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarHelpLabel.TabIndex = 2;
            this.mainBarHelpLabel.Text = "Help";
            this.mainBarHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainBarCreditsLabel
            // 
            this.mainBarCreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarCreditsLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarCreditsLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarCreditsLabel.Image = ((System.Drawing.Image)(resources.GetObject("mainBarCreditsLabel.Image")));
            this.mainBarCreditsLabel.Location = new System.Drawing.Point(247, 3);
            this.mainBarCreditsLabel.Name = "mainBarCreditsLabel";
            this.mainBarCreditsLabel.Size = new System.Drawing.Size(75, 23);
            this.mainBarCreditsLabel.TabIndex = 3;
            this.mainBarCreditsLabel.Text = "Credits";
            this.mainBarCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainBarCreditsLabel);
            this.Controls.Add(this.mainBarHelpLabel);
            this.Controls.Add(this.mainBarEditLabel);
            this.Controls.Add(this.mainBarFileLabel);
            this.Name = "MainBar";
            this.Size = new System.Drawing.Size(1008, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainBarFileLabel;
        private System.Windows.Forms.Label mainBarEditLabel;
        private System.Windows.Forms.Label mainBarHelpLabel;
        private System.Windows.Forms.Label mainBarCreditsLabel;
    }
}
