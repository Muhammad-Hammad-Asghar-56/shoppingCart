using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShirts_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtShoesTotal.Text, out double result) && double.TryParse(txtGrandTotal.Text, out double grandresults) && (double.Parse(txtGrandTotal.Text) != 0))
            {
                double grandprice = double.Parse(txtGrandTotal.Text) - double.Parse(txtShoesTotal.Text);
                txtGrandTotal.Text = grandprice.ToString();
            }
            if (int.TryParse(txtShoesQuantity.Text, out int number))
            {
                double price = double.Parse(txtShoesQuantity.Text) * double.Parse(lblShoesPrice.Text.Remove(0, 1));
                txtShoesTotal.Text = price.ToString();
            }
            if (checkBoxShoes.Checked)
            {
                double price = (double.Parse(txtGrandTotal.Text) + double.Parse(txtShoesTotal.Text));
                txtGrandTotal.Text = price.ToString();
            }
        }
        private void txtShirtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtShirtTotal.Text, out double result) && double.TryParse(txtGrandTotal.Text, out double grandresults) && (double.Parse(txtGrandTotal.Text) != 0))
            {
                double grandprice = double.Parse(txtGrandTotal.Text) - double.Parse(txtShirtTotal.Text);
               txtGrandTotal.Text = grandprice.ToString();
            }
            if(int.TryParse(txtShirtQuantity.Text,out int number))
            {
                double price = double.Parse(txtShirtQuantity.Text) * double.Parse(lblShirtPrice.Text.Remove(0, 1));
                txtShirtTotal.Text = price.ToString();
            }
            if(checkboxShirt.Checked)
            {
                double price = (double.Parse(txtGrandTotal.Text) + double.Parse(txtShirtTotal.Text));
                txtGrandTotal.Text = price.ToString();
            }
        }

        private void txtPantsQuantity_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantsTotal.Text, out double result) && double.TryParse(txtGrandTotal.Text, out double grandresults) && (double.Parse(txtGrandTotal.Text) != 0))
            {
                double grandprice = double.Parse(txtGrandTotal.Text) - double.Parse(txtPantsTotal.Text);
                txtGrandTotal.Text = grandprice.ToString();
            }
            if (int.TryParse(txtPantsQuantity.Text, out int number))
            {
                double price = double.Parse(txtPantsQuantity.Text) * double.Parse(lblPantsPrice.Text.Remove(0, 1));
                txtPantsTotal.Text = price.ToString();
            }
            if (checkBoxPants.Checked)
            {
                double price = (double.Parse(txtGrandTotal.Text) + double.Parse(txtPantsTotal.Text));
                txtGrandTotal.Text = price.ToString();
            }
        }
        private void checkBoxShoes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShoes.Checked)
            {
                if (txtShoesTotal.Text != null && txtShoesTotal.Text!="" && double.Parse(txtShoesTotal.Text) != 0)
                {
                    if (txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) + double.Parse(txtShoesTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
            else
            {
                if (txtShoesTotal.Text != null && txtShoesTotal.Text != ""  && double.Parse(txtShoesTotal.Text) != 0)
                {
                    if (txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) - double.Parse(txtShoesTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
        }
        

        private void checkboxShirt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShirt.Checked)
            {
                if (txtShirtTotal.Text != null && txtShirtTotal.Text!="" && double.Parse(txtShirtTotal.Text) != 0)
                {
                    if (txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) + double.Parse(txtShirtTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
            else
            {
                if (txtShirtTotal.Text != null && txtShirtTotal.Text!= ""&& double.Parse(txtShirtTotal.Text) != 0)
                {
                    if (txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) - double.Parse(txtShirtTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
        }

        

        private void checkBoxPants_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBoxPants.Checked)
            {
                if(txtPantsTotal.Text != null && txtPantsTotal.Text!="" && double.Parse(txtPantsTotal.Text)!=0)
                {
                    if(txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) + double.Parse(txtPantsTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
            else
            {
                if (txtPantsTotal.Text != null && txtPantsTotal.Text!="" && double.Parse(txtPantsTotal.Text) != 0)
                {
                    if (txtGrandTotal.Text != null)
                    {
                        double price = double.Parse(txtGrandTotal.Text) - double.Parse(txtPantsTotal.Text);
                        txtGrandTotal.Text = price.ToString();
                    }
                }
            }
        }
    }
}
