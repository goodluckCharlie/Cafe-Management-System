using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Cafe_Management_System
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        string query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void Guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string category = categoryCombo.Text;
            query = "select name from items where category= '" + category + "'";
            showItemList(query);
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            string category = categoryCombo.Text;
            query = "select name from items where category= '" + category + "' and item_name like '"+ searchTxt.Text+"%'" ;
            showItemList(query);
        }
        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityTxtUpDown.ResetText();
            totalTxt.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            itemTxt.Text = text;
            query = "select price from items where name= '"+text+"'";
            DataSet ds = fn.getData(query);

            try
            {
                priceTxt.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }

        }

        private void QuantityTxtUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(quantityTxtUpDown.Value.ToString());
            Int64 price = Int64.Parse(priceTxt.Text);
            totalTxt.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (totalTxt.Text != "0" && totalTxt.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = itemTxt.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = priceTxt.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = quantityTxtUpDown.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = totalTxt.Text;

                total += int.Parse(totalTxt.Text);
                totalAmountTxt.Text = "SDG. " + total;
            }
            else
            {
                MessageBox.Show("The minimum number has to be 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

     
        }
        int amount;

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            totalAmountTxt.Text = "SDG. " + total;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount" + totalAmountTxt.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            totalAmountTxt.Text = "SDG. " + total;

        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }
    }
}
