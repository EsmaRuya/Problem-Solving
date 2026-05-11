using System.ComponentModel;

namespace _002_TextBox_CheckBox_CheckListBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float _TotalPizzaPrice()
        {
            int price = 0;

            if (cbPizzaSize.Text == "Small")
                price = 30;
            if (cbPizzaSize.Text == "Medium")
                price = 50;
            if (cbPizzaSize.Text == "Large")
                price = 70;

            if (ckBox_Cheese.Checked)
            {
                if (int.TryParse(ckBox_Cheese.Tag.ToString(), out int result))
                    price += result;
            }

            if (ckListBox_Topping.CheckedItems.Count > 0)
            {
                foreach (object item in ckListBox_Topping.CheckedItems)
                {
                    if (int.TryParse(ckListBox_Topping.Tag.ToString(), out int result))
                        price += result;
                }
            }

            return price;
        }

        private string _GetToppingItems()
        {
            //string strItems = "";
            //foreach (object item in ckListBox_Topping.CheckedItems)
            //{
            //       strItems += item + " - "; 
            //}
            //return strItems;

            return string.Join(" - ", ckListBox_Topping.CheckedItems.Cast<object>());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmptyFields_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            cbPizzaSize.SelectedItem = null;
            ckBox_Cheese.Checked = false;
            for(int i = 0; i < ckListBox_Topping.Items.Count; i++)
            {
                ckListBox_Topping.SetItemChecked(i, false);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
                MessageBox.Show("Please enter your name");

            MessageBox.Show("Customer : " + txtBoxName.Text + "\n" +
                            "Size     : " + cbPizzaSize.SelectedItem + "\n" +
                            "Extra cheese : " + (ckBox_Cheese.Checked ? "Yes" : "No") + "\n" +
                            "Toppings     : " + _GetToppingItems() + "\n" +
                            "Total price  : " + _TotalPizzaPrice(),
                            "Order");
        }

    }
}
