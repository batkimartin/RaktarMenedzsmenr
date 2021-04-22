namespace RaktárMenedzsment
{
    partial class frmStorageManagementMain
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
            this.buttonWarehouseInventory = new System.Windows.Forms.Button();
            this.buttonAllOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWarehouseInventory
            // 
            this.buttonWarehouseInventory.Location = new System.Drawing.Point(446, 54);
            this.buttonWarehouseInventory.Name = "buttonWarehouseInventory";
            this.buttonWarehouseInventory.Size = new System.Drawing.Size(455, 63);
            this.buttonWarehouseInventory.TabIndex = 0;
            this.buttonWarehouseInventory.Text = "Raktár készlet / Áru rendelés";
            this.buttonWarehouseInventory.UseVisualStyleBackColor = true;
            this.buttonWarehouseInventory.Click += new System.EventHandler(this.buttonWarehouseInventory_Click);
            // 
            // buttonAllOrders
            // 
            this.buttonAllOrders.Location = new System.Drawing.Point(446, 159);
            this.buttonAllOrders.Name = "buttonAllOrders";
            this.buttonAllOrders.Size = new System.Drawing.Size(455, 63);
            this.buttonAllOrders.TabIndex = 1;
            this.buttonAllOrders.Text = "Rendelések";
            this.buttonAllOrders.UseVisualStyleBackColor = true;
            this.buttonAllOrders.Click += new System.EventHandler(this.buttonAllOrders_Click);
            // 
            // frmStorageManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 589);
            this.Controls.Add(this.buttonAllOrders);
            this.Controls.Add(this.buttonWarehouseInventory);
            this.Name = "frmStorageManagementMain";
            this.Text = "Raktár kezelés";
            this.Load += new System.EventHandler(this.frmStorageManagementMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWarehouseInventory;
        private System.Windows.Forms.Button buttonAllOrders;
    }
}