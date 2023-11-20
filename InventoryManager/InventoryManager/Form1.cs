using System.Data;

namespace InventoryManager
{
    public partial class Form1 : Form
    {

        DataTable inventory = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            skuTxBx.Text = "";
            nameTxBx.Text = "";
            priceTxBx.Text = "";
            descripTxBx.Text = "";
            quantTxBx.Text = "";
            cateCBx.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String sku = skuTxBx.Text;
            String name = nameTxBx.Text;
            String price = priceTxBx.Text;
            String quantity = quantTxBx.Text;
            String descrip = descripTxBx.Text;
            String category = (string)cateCBx.SelectedItem;

            inventory.Rows.Add(sku, name, category, price, descrip, quantity);

            newBtn_Click(sender, e);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception er)
            {
                Console.WriteLine("Delete Error: " + er);
            }
        }

        private void InventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTxBx.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTxBx.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTxBx.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descripTxBx.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantTxBx.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                cateCBx.SelectedIndex = cateCBx.Items.IndexOf(itemToLookFor);
            }
            catch (Exception er)
            {
                Console.WriteLine("Grid Error: " + er);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            InventoryGridView.DataSource = inventory;
        }
    }
}