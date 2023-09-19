using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFlatUI_FA.Forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();

            //**********************************************//Llenar primer DataGrid.
            DataGridViewRow dtgridviewRow = new DataGridViewRow();
            dtgridviewRow.CreateCells(dgvMatrix);

            dgvMatrix.RowCount = 5;
            dgvMatrix.ColumnCount = 5;

            //                                              //Take each intNumRow
            for (int intNumRow = 0; intNumRow < 5; intNumRow++)
            {
                //                                              //Take each intNumColumn
                for (int intNumColumn = 0; intNumColumn < 5; intNumColumn++)
                {
                    dgvMatrix.Rows[intNumRow].Cells[intNumColumn].Value = $"{intNumRow} - {intNumColumn}";
                }
            }

            //**********************************************//Llenar segundo DataGrid.
            DataTable dt = new DataTable();
            dt.Columns.Add("Col1");
            dt.Columns.Add("Col2");
            dt.Columns.Add("Col3");
            dt.Columns.Add("Col4");
            dt.Columns.Add("Col5");

            //                                              //Take each intNumRow
            for (int intNumRow = 0; intNumRow < 5; intNumRow++)
            {
                DataRow dr = dt.NewRow();
                //                                              //Take each intNumColumn
                for (int intNumColumn = 0; intNumColumn < 5; intNumColumn++)
                {
                    dr[intNumColumn] = $"{intNumRow} - {intNumColumn}";
                }

                dt.Rows.Add(dr);
            }

            dgv2.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
