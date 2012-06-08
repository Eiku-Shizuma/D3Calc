namespace Diablo_3_Dmg_Calculator.controls
{
    partial class ContextMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContextMenu));
            this.contextMenuAttributecomboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuAttributeValueTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuAddButtonLabel = new System.Windows.Forms.Label();
            this.contextAddListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // contextMenuAttributecomboBox
            // 
            this.contextMenuAttributecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Strength",
            "Dexterity",
            "Intelligence",
            "Vitality",
            ".",
            ".",
            "."});
            this.contextMenuAttributecomboBox.FormattingEnabled = true;
            this.contextMenuAttributecomboBox.Location = new System.Drawing.Point(3, 3);
            this.contextMenuAttributecomboBox.Name = "contextMenuAttributecomboBox";
            this.contextMenuAttributecomboBox.Size = new System.Drawing.Size(150, 21);
            this.contextMenuAttributecomboBox.TabIndex = 0;
            this.contextMenuAttributecomboBox.Text = "Attribute";
            // 
            // contextMenuAttributeValueTextBox
            // 
            this.contextMenuAttributeValueTextBox.Location = new System.Drawing.Point(3, 30);
            this.contextMenuAttributeValueTextBox.Name = "contextMenuAttributeValueTextBox";
            this.contextMenuAttributeValueTextBox.Size = new System.Drawing.Size(69, 20);
            this.contextMenuAttributeValueTextBox.TabIndex = 1;
            this.contextMenuAttributeValueTextBox.Text = "Value";
            // 
            // contextMenuAddButtonLabel
            // 
            this.contextMenuAddButtonLabel.ForeColor = System.Drawing.Color.White;
            this.contextMenuAddButtonLabel.Image = ((System.Drawing.Image)(resources.GetObject("contextMenuAddButtonLabel.Image")));
            this.contextMenuAddButtonLabel.Location = new System.Drawing.Point(78, 29);
            this.contextMenuAddButtonLabel.Name = "contextMenuAddButtonLabel";
            this.contextMenuAddButtonLabel.Size = new System.Drawing.Size(75, 23);
            this.contextMenuAddButtonLabel.TabIndex = 2;
            this.contextMenuAddButtonLabel.Text = "Add";
            this.contextMenuAddButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextAddListView
            // 
            this.contextAddListView.Location = new System.Drawing.Point(3, 56);
            this.contextAddListView.Name = "contextAddListView";
            this.contextAddListView.Size = new System.Drawing.Size(150, 172);
            this.contextAddListView.TabIndex = 3;
            this.contextAddListView.UseCompatibleStateImageBehavior = false;
            // 
            // ContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.contextAddListView);
            this.Controls.Add(this.contextMenuAddButtonLabel);
            this.Controls.Add(this.contextMenuAttributeValueTextBox);
            this.Controls.Add(this.contextMenuAttributecomboBox);
            this.Name = "ContextMenu";
            this.Size = new System.Drawing.Size(156, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contextMenuAttributecomboBox;
        private System.Windows.Forms.TextBox contextMenuAttributeValueTextBox;
        private System.Windows.Forms.Label contextMenuAddButtonLabel;
        private System.Windows.Forms.ListView contextAddListView;
    }
}
