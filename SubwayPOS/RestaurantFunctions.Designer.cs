namespace SubwayPOS
{
    partial class RestaurantFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantFunctions));
            btnReprintReceipt = new System.Windows.Forms.Button();
            btnMinCashIn = new System.Windows.Forms.Button();
            lblUserNamelabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnReprintReceipt
            // 
            btnReprintReceipt.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnReprintReceipt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReprintReceipt.ForeColor = System.Drawing.Color.White;
            btnReprintReceipt.Location = new System.Drawing.Point(62, 125);
            btnReprintReceipt.Name = "btnReprintReceipt";
            btnReprintReceipt.Size = new System.Drawing.Size(126, 55);
            btnReprintReceipt.TabIndex = 0;
            btnReprintReceipt.Text = "Reprint Receipt";
            btnReprintReceipt.UseVisualStyleBackColor = false;
            btnReprintReceipt.Click += btnReprintReceipt_Click;
            // 
            // btnMinCashIn
            // 
            btnMinCashIn.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnMinCashIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMinCashIn.ForeColor = System.Drawing.Color.White;
            btnMinCashIn.Location = new System.Drawing.Point(274, 125);
            btnMinCashIn.Name = "btnMinCashIn";
            btnMinCashIn.Size = new System.Drawing.Size(126, 55);
            btnMinCashIn.TabIndex = 1;
            btnMinCashIn.Text = "Minute Cash In";
            btnMinCashIn.UseVisualStyleBackColor = false;
            btnMinCashIn.Click += btnMinCashIn_Click;
            // 
            // lblUserNamelabel
            // 
            lblUserNamelabel.AutoSize = true;
            lblUserNamelabel.Location = new System.Drawing.Point(67, 56);
            lblUserNamelabel.Name = "lblUserNamelabel";
            lblUserNamelabel.Size = new System.Drawing.Size(62, 15);
            lblUserNamelabel.TabIndex = 3;
            lblUserNamelabel.Text = "UserName";
            // 
            // RestaurantFunctions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(456, 303);
            Controls.Add(lblUserNamelabel);
            Controls.Add(btnMinCashIn);
            Controls.Add(btnReprintReceipt);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "RestaurantFunctions";
            Text = "Subway POS";
            Load += RestaurantFunctions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnReprintReceipt;
        private System.Windows.Forms.Button btnMinCashIn;

        private System.Windows.Forms.Label lblUserNamelabel;
    }
}