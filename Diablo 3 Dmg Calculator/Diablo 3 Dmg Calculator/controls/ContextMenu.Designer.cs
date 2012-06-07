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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextBoxAddLabel = new System.Windows.Forms.Label();
            this.contextMenuListView1 = new System.Windows.Forms.ListView();
            this.Delete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Attribute";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Value";
            // 
            // contextBoxAddLabel
            // 
            this.contextBoxAddLabel.ForeColor = System.Drawing.Color.White;
            this.contextBoxAddLabel.Image = ((System.Drawing.Image)(resources.GetObject("contextBoxAddLabel.Image")));
            this.contextBoxAddLabel.Location = new System.Drawing.Point(208, 2);
            this.contextBoxAddLabel.Name = "contextBoxAddLabel";
            this.contextBoxAddLabel.Size = new System.Drawing.Size(75, 23);
            this.contextBoxAddLabel.TabIndex = 2;
            this.contextBoxAddLabel.Text = "Add";
            this.contextBoxAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuListView1
            // 
            this.contextMenuListView1.BackColor = System.Drawing.Color.White;
            this.contextMenuListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contextMenuListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Delete,
            this.Attribute});
            this.contextMenuListView1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuListView1.Location = new System.Drawing.Point(3, 28);
            this.contextMenuListView1.Name = "contextMenuListView1";
            this.contextMenuListView1.Size = new System.Drawing.Size(280, 100);
            this.contextMenuListView1.TabIndex = 3;
            this.contextMenuListView1.UseCompatibleStateImageBehavior = false;
            // 
            // ContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.contextMenuListView1);
            this.Controls.Add(this.contextBoxAddLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ContextMenu";
            this.Size = new System.Drawing.Size(286, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contextBoxAddLabel;
        private System.Windows.Forms.ListView contextMenuListView1;
        private System.Windows.Forms.ColumnHeader Delete;
        private System.Windows.Forms.ColumnHeader Attribute;
    }
}
