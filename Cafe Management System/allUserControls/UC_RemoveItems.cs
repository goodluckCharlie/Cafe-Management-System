using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.allUserControls
{
    public partial class UC_RemoveItems : UserControl
    {
        function fn = new function();
        string query;

        public UC_RemoveItems()
        {
            InitializeComponent();
        }   

        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            deleteLabel.Text = "How to DELETE?";
            deleteLabel.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void SearchItemTxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + searchItemTxt.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
           
        }

        private void Guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Items?", "Delete Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where iid =" + id + "";
                fn.setData(query);
                loadData();
            }
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {
            deleteLabel.ForeColor = Color.Red;
            deleteLabel.Text = "*Double click cell to delete the item..";
        }

        private void UC_RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
