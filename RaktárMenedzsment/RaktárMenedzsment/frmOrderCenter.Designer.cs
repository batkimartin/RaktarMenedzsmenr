namespace RaktárMenedzsment
{
    partial class frmOrderCenter
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
            this.dataGridViewAvailableOrderPlush = new System.Windows.Forms.DataGridView();
            this.btnDecoratePlush = new System.Windows.Forms.Button();
            this.numericUpDownOrderQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableOrderPlush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableOrderPlush
            // 
            this.dataGridViewAvailableOrderPlush.AllowUserToAddRows = false;
            this.dataGridViewAvailableOrderPlush.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableOrderPlush.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableOrderPlush.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewAvailableOrderPlush.MultiSelect = false;
            this.dataGridViewAvailableOrderPlush.Name = "dataGridViewAvailableOrderPlush";
            this.dataGridViewAvailableOrderPlush.ReadOnly = true;
            this.dataGridViewAvailableOrderPlush.Size = new System.Drawing.Size(1260, 586);
            this.dataGridViewAvailableOrderPlush.TabIndex = 0;
            // 
            // btnDecoratePlush
            // 
            this.btnDecoratePlush.Location = new System.Drawing.Point(1103, 12);
            this.btnDecoratePlush.Name = "btnDecoratePlush";
            this.btnDecoratePlush.Size = new System.Drawing.Size(169, 23);
            this.btnDecoratePlush.TabIndex = 1;
            this.btnDecoratePlush.Text = "Kiválasztott sor díszítése";
            this.btnDecoratePlush.UseVisualStyleBackColor = true;
            this.btnDecoratePlush.Click += new System.EventHandler(this.btnDecoratePlush_Click);
            // 
            // numericUpDownOrderQuantity
            // 
            this.numericUpDownOrderQuantity.Location = new System.Drawing.Point(922, 12);
            this.numericUpDownOrderQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrderQuantity.Name = "numericUpDownOrderQuantity";
            this.numericUpDownOrderQuantity.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownOrderQuantity.TabIndex = 2;
            this.numericUpDownOrderQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmOrderCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.numericUpDownOrderQuantity);
            this.Controls.Add(this.btnDecoratePlush);
            this.Controls.Add(this.dataGridViewAvailableOrderPlush);
            this.Name = "frmOrderCenter";
            this.Text = "Rendelés központ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableOrderPlush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableOrderPlush;
        private System.Windows.Forms.Button btnDecoratePlush;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderQuantity;
    }
}