namespace RaktárMenedzsment
{
    partial class frmPlushDecorateAndOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxEquipments = new System.Windows.Forms.CheckedListBox();
            this.labelOrderPlushName = new System.Windows.Forms.Label();
            this.labelOrderedQuantity = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOrderSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milyen elemeket szeretne a plüss figurához?";
            // 
            // checkedListBoxEquipments
            // 
            this.checkedListBoxEquipments.FormattingEnabled = true;
            this.checkedListBoxEquipments.Location = new System.Drawing.Point(37, 56);
            this.checkedListBoxEquipments.Name = "checkedListBoxEquipments";
            this.checkedListBoxEquipments.Size = new System.Drawing.Size(1254, 124);
            this.checkedListBoxEquipments.TabIndex = 1;
            // 
            // labelOrderPlushName
            // 
            this.labelOrderPlushName.AutoSize = true;
            this.labelOrderPlushName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderPlushName.Location = new System.Drawing.Point(531, 9);
            this.labelOrderPlushName.Name = "labelOrderPlushName";
            this.labelOrderPlushName.Size = new System.Drawing.Size(0, 24);
            this.labelOrderPlushName.TabIndex = 2;
            // 
            // labelOrderedQuantity
            // 
            this.labelOrderedQuantity.AutoSize = true;
            this.labelOrderedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderedQuantity.Location = new System.Drawing.Point(34, 219);
            this.labelOrderedQuantity.Name = "labelOrderedQuantity";
            this.labelOrderedQuantity.Size = new System.Drawing.Size(0, 24);
            this.labelOrderedQuantity.TabIndex = 3;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(487, 325);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(509, 29);
            this.textBoxCustomerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(359, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Megrendelő: ";
            // 
            // buttonOrderSave
            // 
            this.buttonOrderSave.Location = new System.Drawing.Point(433, 586);
            this.buttonOrderSave.Name = "buttonOrderSave";
            this.buttonOrderSave.Size = new System.Drawing.Size(545, 42);
            this.buttonOrderSave.TabIndex = 6;
            this.buttonOrderSave.Text = "Rendelés véglegesítése";
            this.buttonOrderSave.UseVisualStyleBackColor = true;
            this.buttonOrderSave.Click += new System.EventHandler(this.buttonOrderSave_Click);
            // 
            // frmPlushDecorateAndOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 685);
            this.Controls.Add(this.buttonOrderSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelOrderedQuantity);
            this.Controls.Add(this.labelOrderPlushName);
            this.Controls.Add(this.checkedListBoxEquipments);
            this.Controls.Add(this.label1);
            this.Name = "frmPlushDecorateAndOrder";
            this.Text = "Díszítés és rendelés véglegesítése";
            this.Load += new System.EventHandler(this.frmPlushDecorateAndOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipments;
        private System.Windows.Forms.Label labelOrderPlushName;
        private System.Windows.Forms.Label labelOrderedQuantity;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOrderSave;
    }
}