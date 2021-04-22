namespace RaktárMenedzsment
{
    partial class frmOrderManagement
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
            this.dataGridViewActiveOrders = new System.Windows.Forms.DataGridView();
            this.OrderStatusUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActiveOrders
            // 
            this.dataGridViewActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderStatusUpdate});
            this.dataGridViewActiveOrders.Location = new System.Drawing.Point(20, 29);
            this.dataGridViewActiveOrders.Name = "dataGridViewActiveOrders";
            this.dataGridViewActiveOrders.Size = new System.Drawing.Size(1267, 607);
            this.dataGridViewActiveOrders.TabIndex = 0;
            this.dataGridViewActiveOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActiveOrders_CellContentClick);
            // 
            // OrderStatusUpdate
            // 
            this.OrderStatusUpdate.HeaderText = "Következő státusz";
            this.OrderStatusUpdate.Name = "OrderStatusUpdate";
            this.OrderStatusUpdate.Text = "Következő";
            this.OrderStatusUpdate.UseColumnTextForButtonValue = true;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 666);
            this.Controls.Add(this.dataGridViewActiveOrders);
            this.Name = "frmOrderManagement";
            this.Text = "frmOrderManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActiveOrders;
        private System.Windows.Forms.DataGridViewButtonColumn OrderStatusUpdate;
    }
}