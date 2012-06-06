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
            this.mainBarFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainBarFileLabel.AutoSize = true;
            this.mainBarFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBarFileLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarFileLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarFileLabel.Location = new System.Drawing.Point(15, 5);
            this.mainBarFileLabel.Name = "mainBarFileLabel";
            this.mainBarFileLabel.Size = new System.Drawing.Size(29, 19);
            this.mainBarFileLabel.TabIndex = 0;
            this.mainBarFileLabel.Text = "File";
            this.mainBarFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainBarEditLabel
            // 
            this.mainBarEditLabel.AutoSize = true;
            this.mainBarEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarEditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBarEditLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarEditLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarEditLabel.Location = new System.Drawing.Point(58, 5);
            this.mainBarEditLabel.Name = "mainBarEditLabel";
            this.mainBarEditLabel.Size = new System.Drawing.Size(32, 19);
            this.mainBarEditLabel.TabIndex = 1;
            this.mainBarEditLabel.Text = "Edit";
            // 
            // mainBarHelpLabel
            // 
            this.mainBarHelpLabel.AutoSize = true;
            this.mainBarHelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarHelpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBarHelpLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarHelpLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarHelpLabel.Location = new System.Drawing.Point(104, 5);
            this.mainBarHelpLabel.Name = "mainBarHelpLabel";
            this.mainBarHelpLabel.Size = new System.Drawing.Size(36, 19);
            this.mainBarHelpLabel.TabIndex = 2;
            this.mainBarHelpLabel.Text = "Help";
            // 
            // mainBarCreditsLabel
            // 
            this.mainBarCreditsLabel.AutoSize = true;
            this.mainBarCreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainBarCreditsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBarCreditsLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBarCreditsLabel.ForeColor = System.Drawing.Color.White;
            this.mainBarCreditsLabel.Location = new System.Drawing.Point(154, 5);
            this.mainBarCreditsLabel.Name = "mainBarCreditsLabel";
            this.mainBarCreditsLabel.Size = new System.Drawing.Size(49, 19);
            this.mainBarCreditsLabel.TabIndex = 3;
            this.mainBarCreditsLabel.Text = "Credits";
            // 
            // MainBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainBarCreditsLabel);
            this.Controls.Add(this.mainBarHelpLabel);
            this.Controls.Add(this.mainBarEditLabel);
            this.Controls.Add(this.mainBarFileLabel);
            this.Name = "MainBar";
            this.Size = new System.Drawing.Size(1006, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainBarFileLabel;
        private System.Windows.Forms.Label mainBarEditLabel;
        private System.Windows.Forms.Label mainBarHelpLabel;
        private System.Windows.Forms.Label mainBarCreditsLabel;
    }
}
