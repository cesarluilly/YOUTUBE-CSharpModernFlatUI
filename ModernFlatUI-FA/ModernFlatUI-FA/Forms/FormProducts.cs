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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            materialListView1.Columns.Add("Col1", 200);
            materialListView1.Columns.Add("Col2", 200);
            materialListView1.Columns.Add("Col3", 200);
            materialListView1.Columns.Add("Col4", 200);
            materialListView1.Columns.Add("Col5", 200);

            //                                              //Take each intNumRow
            for (int intNumRow = 0; intNumRow < 5; intNumRow++)
            {
                ListViewItem item = new ListViewItem();
                //                                              //Take each intNumColumn
                for (int intNumColumn = 0; intNumColumn < 5; intNumColumn++)
                {
                    item.SubItems[0].Text = $"{intNumRow} - {intNumColumn}";
                    //item.SubItems.Add($"{intNumRow} - {intNumColumn}");
                }

                materialListView1.Items.Add(item);
            }
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
