namespace ModernFlatUI_FA.Forms
{
    partial class FormOrders
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
            dgvMatrix = new DataGridView();
            dgv2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // dgvMatrix
            // 
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Location = new Point(75, 156);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.RowTemplate.Height = 25;
            dgvMatrix.Size = new Size(240, 150);
            dgvMatrix.TabIndex = 0;
            dgvMatrix.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(355, 156);
            dgv2.Name = "dgv2";
            dgv2.RowTemplate.Height = 25;
            dgv2.Size = new Size(240, 150);
            dgv2.TabIndex = 1;
            dgv2.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv2);
            Controls.Add(dgvMatrix);
            Name = "FormOrders";
            Text = "FormOrders";
            Load += FormOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMatrix;
        private DataGridView dgv2;
    }
}