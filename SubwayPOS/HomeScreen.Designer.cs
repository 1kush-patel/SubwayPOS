namespace  SubwayPOS

{
    partial class HomeScreen
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
            button1 = new System.Windows.Forms.Button();
            btnRestaurantFunction = new System.Windows.Forms.Button();
            btnSalesInfo = new System.Windows.Forms.Button();
            btnRingSales = new System.Windows.Forms.Button();
            lblUsername = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(82, 60);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Time Clock";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRestaurantFunction
            // 
            btnRestaurantFunction.Location = new System.Drawing.Point(82, 117);
            btnRestaurantFunction.Name = "btnRestaurantFunction";
            btnRestaurantFunction.Size = new System.Drawing.Size(75, 41);
            btnRestaurantFunction.TabIndex = 1;
            btnRestaurantFunction.Text = "Restaurant Function";
            btnRestaurantFunction.UseVisualStyleBackColor = true;
            btnRestaurantFunction.Click += btnRestaurantFunction_Click;
            // 
            // btnSalesInfo
            // 
            btnSalesInfo.Location = new System.Drawing.Point(82, 190);
            btnSalesInfo.Name = "btnSalesInfo";
            btnSalesInfo.Size = new System.Drawing.Size(75, 23);
            btnSalesInfo.TabIndex = 2;
            btnSalesInfo.Text = "SalesInfo";
            btnSalesInfo.UseVisualStyleBackColor = true;
            btnSalesInfo.Click += btnSalesInfo_Click;
            // 
            // btnRingSales
            // 
            btnRingSales.Location = new System.Drawing.Point(268, 88);
            btnRingSales.Name = "btnRingSales";
            btnRingSales.Size = new System.Drawing.Size(75, 88);
            btnRingSales.TabIndex = 3;
            btnRingSales.Text = "Ring Sales";
            btnRingSales.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(64, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(0, 15);
            lblUsername.TabIndex = 4;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(441, 284);
            Controls.Add(lblUsername);
            Controls.Add(btnRingSales);
            Controls.Add(btnSalesInfo);
            Controls.Add(btnRestaurantFunction);
            Controls.Add(button1);
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRestaurantFunction;
        private System.Windows.Forms.Button btnSalesInfo;
        private System.Windows.Forms.Button btnRingSales;
        private System.Windows.Forms.Label lblUsername;
    }
}