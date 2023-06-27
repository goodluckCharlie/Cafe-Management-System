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
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemBtn_Click(object sender, EventArgs e)    
        {
            if (itemNameTxt.Text != "" && categoryTxt.Text != "" && itemPriceTxt.Text != "")
            {
                query = "insert into items(name, category, price) values ('" + itemNameTxt.Text + "', '" + categoryTxt.Text + "', '" + itemPriceTxt.Text + "')";
                fn.setData(query);
                clearAll();
                MessageBox.Show("Item added Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            categoryTxt.SelectedIndex = -1;
            itemNameTxt.Clear();
            itemPriceTxt.Clear();
        }

        private void AddItemBtn_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
