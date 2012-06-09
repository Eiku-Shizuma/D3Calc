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
            this.contextMenuAttributeValueTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuAddButtonLabel = new System.Windows.Forms.Label();
            this.contextAddListView = new System.Windows.Forms.ListView();
            this.Attributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextClosePanel = new System.Windows.Forms.Panel();
            this.contextMenuAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.contextMenuAddButtonLabel.Click += new System.EventHandler(this.Readdata);
            // 
            // contextAddListView
            // 
            this.contextAddListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Attributes});
            this.contextAddListView.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAddListView.Location = new System.Drawing.Point(3, 56);
            this.contextAddListView.Name = "contextAddListView";
            this.contextAddListView.Size = new System.Drawing.Size(150, 172);
            this.contextAddListView.TabIndex = 3;
            this.contextAddListView.UseCompatibleStateImageBehavior = false;
            // 
            // contextClosePanel
            // 
            this.contextClosePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextClosePanel.BackgroundImage")));
            this.contextClosePanel.Location = new System.Drawing.Point(133, 4);
            this.contextClosePanel.Name = "contextClosePanel";
            this.contextClosePanel.Size = new System.Drawing.Size(20, 20);
            this.contextClosePanel.TabIndex = 4;
            this.contextClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close);
            // 
            // contextMenuAttributeComboBox
            // 
            this.contextMenuAttributeComboBox.FormattingEnabled = true;
            this.contextMenuAttributeComboBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Intelligence",
            "Vitality",
            ".",
            ".",
            "."});
            this.contextMenuAttributeComboBox.Location = new System.Drawing.Point(3, 3);
            this.contextMenuAttributeComboBox.Name = "contextMenuAttributeComboBox";
            this.contextMenuAttributeComboBox.Size = new System.Drawing.Size(125, 21);
            this.contextMenuAttributeComboBox.TabIndex = 0;
            this.contextMenuAttributeComboBox.Text = "Attribute";
            // 
            // ContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.contextClosePanel);
            this.Controls.Add(this.contextAddListView);
            this.Controls.Add(this.contextMenuAddButtonLabel);
            this.Controls.Add(this.contextMenuAttributeValueTextBox);
            this.Controls.Add(this.contextMenuAttributeComboBox);
            this.Name = "ContextMenu";
            this.Size = new System.Drawing.Size(156, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox contextMenuAttributeValueTextBox;
        public System.Windows.Forms.Label contextMenuAddButtonLabel;
        public System.Windows.Forms.ListView contextAddListView;
        private System.Windows.Forms.ColumnHeader Attributes;
        private System.Windows.Forms.Panel contextClosePanel;
        public System.Windows.Forms.ComboBox contextMenuAttributeComboBox;

    }
}
