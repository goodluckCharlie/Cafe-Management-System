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
    public partial class UC_UpdateItem : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void ItemNameTxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where item_name like '"+itemSearchTxt.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            categoryTxt.Text = category;
            itemNameTxt.Text = name;
            priceTxt.Text = price.ToString();
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            query = "update items set name='" + itemNameTxt.Text + "', category= '" + categoryTxt.Text + "', price=" + priceTxt.Text + " where iid = " + id + "";
            fn.setData(query);
            MessageBox.Show("Item Update Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();

            itemNameTxt.Clear();
            categoryTxt.Clear();
            priceTxt.Clear();
        }

        private void UC_UpdateItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
