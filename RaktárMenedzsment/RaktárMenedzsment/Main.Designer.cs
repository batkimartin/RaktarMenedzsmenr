namespace RaktárMenedzsment
{
    partial class Main
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
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(349, 23);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(618, 61);
            this.btnAdministration.TabIndex = 0;
            this.btnAdministration.Text = "Adminisztráció / Raktár kezelés";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(349, 150);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(618, 61);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Rendelés";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 586);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAdministration);
            this.Name = "Main";
            this.Text = "Főmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Button btnOrder;
    }
}

