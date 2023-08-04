namespace SubwayPOS
{
    partial class SalesInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInfo));
            dataGridSalesInfo = new System.Windows.Forms.DataGridView();
            btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSalesInfo).BeginInit();
            SuspendLayout();
            // 
            // dataGridSalesInfo
            // 
            dataGridSalesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSalesInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridSalesInfo.Location = new System.Drawing.Point(0, 0);
            dataGridSalesInfo.Name = "dataGridSalesInfo";
            dataGridSalesInfo.RowTemplate.Height = 25;
            dataGridSalesInfo.Size = new System.Drawing.Size(657, 412);
            dataGridSalesInfo.TabIndex = 2;
            dataGridSalesInfo.CellContentClick += dataGridSalesInfo_CellContentClick;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnPrint.Location = new System.Drawing.Point(257, 346);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(88, 45);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // SalesInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(657, 412);
            Controls.Add(btnPrint);
            Controls.Add(dataGridSalesInfo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SalesInfo";
            Text = "Subway POS";
            Load += SalesInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSalesInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridSalesInfo;
        private System.Windows.Forms.Button btnPrint;
    }
}