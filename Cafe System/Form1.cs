using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset button
            //Reset Drinks
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtMacchiato.Text = "0";
            txtCappuccino.Text = "0";
            txtColdCoffee.Text = "0";
            txtTea.Text = "0";
            txtHotChocolate.Text = "0";

            checkBoxLatte.Checked = false;
            checkBoxEspresso.Checked = false;
            checkBoxMacchiato.Checked = false;
            checkBoxCappuccino.Checked = false;
            checkBoxColdCoffee.Checked = false;
            checkBoxTea.Checked = false;
            checkBoxHotChocolate.Checked = false;


            //Reset Desserts
            txtCheesecake.Text = "0";
            txtChocolateCake.Text = "0";
            txtNutellaCake.Text = "0";
            txtFruitCake.Text = "0";
            txtTiramisu.Text = "0";
            txtChocolateTart.Text = "0";
            txtVanillaCupcakes.Text = "0";

            checkBoxCheesecake.Checked = false;
            checkBoxChocolateCake.Checked = false;
            checkBoxNutellaCake.Checked = false;
            checkBoxFruitCake.Checked = false;
            checkBoxTiramisu.Checked = false;
            checkBoxChocolateTart.Checked = false;
            checkBoxVanillaCupcake.Checked = false;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            double latteprice = 1.2;
            double espressoprice = 1.0;
            double Macchiatoprice = 1.5;
            double Cappuccinoprice = 1.3;
            double ColdCoffeeprice = 1.0;
            double Teaprice = 2.2;
            double HotChocolateprice = 3;
            double Taxprice = 0.2;
            double costofdrinks = 0;
            double costofdessert = 0;
            double servicecost = 1.25;
            double subtotal = 0;
            double total = 0;
            double Cheesecakeprice = 3.0;
            double ChocolateCakeprice = 2.5;
            double NutellaCakeprice = 2.5;
            double FruitCakeprice = 2.0;
            double Tiramisuprice = 3.0;
            double ChocolateTartprice = 2.3;
            double VanillaCupcakeprice = 2.0;


            costofdrinks = ((double.Parse(txtLatte.Text) * latteprice) + (double.Parse(txtEspresso.Text) * espressoprice) + (double.Parse(txtMacchiato.Text) * Macchiatoprice)
                + (double.Parse(txtCappuccino.Text) * Cappuccinoprice) + (double.Parse(txtColdCoffee.Text) * ColdCoffeeprice) +
                (double.Parse(txtTea.Text) * Teaprice) + (double.Parse(txtHotChocolate.Text) * HotChocolateprice));

            costofdessert = ((double.Parse(txtCheesecake.Text) * Cheesecakeprice) + (double.Parse(txtChocolateCake.Text) * ChocolateCakeprice) +
                (double.Parse(txtNutellaCake.Text) * NutellaCakeprice) + (double.Parse(txtFruitCake.Text) * FruitCakeprice) + (double.Parse(txtTiramisu.Text) * Tiramisuprice)
                + (double.Parse(txtChocolateTart.Text) * ChocolateTartprice) + (double.Parse(txtVanillaCupcakes.Text) * VanillaCupcakeprice));

            subtotal = costofdrinks + costofdessert + servicecost;
            txtTax.Text = "20 %";
            double Tax = subtotal * Taxprice;
            total = subtotal + Tax;


            txtTotal.Text = total.ToString();
            txtSubTotal.Text = subtotal.ToString();
            txtCostOfDrinks.Text = costofdrinks.ToString();
            txtCostOfDessert.Text = costofdessert.ToString();

 
        }

        private void checkBoxLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLatte.Checked == true)
            {
                txtLatte.Text = "0";
                txtLatte.Enabled = true;
            }
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void checkBoxEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEspresso.Checked == true)
            {
                txtEspresso.Text = "0";
                txtEspresso.Enabled = true;
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void checkBoxMacchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMacchiato.Checked == true)
            {
                txtMacchiato.Text = "0";
                txtMacchiato.Enabled = true;
            }
            else
            {
                txtMacchiato.Enabled = false;
                txtMacchiato.Text = "0";
            }
        }

        private void checkBoxCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCappuccino.Checked == true)
            {
                txtCappuccino.Text = "0";
                txtCappuccino.Enabled = true;
            }
            else
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void checkBoxColdCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxColdCoffee.Checked == true)
            {
                txtColdCoffee.Text = "0";
                txtColdCoffee.Enabled = true;
            }
            else
            {
                txtColdCoffee.Enabled = false;
                txtColdCoffee.Text = "0";
            }
        }

        private void checkBoxTea_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTea.Checked == true)
            {
                txtTea.Text = "0";
                txtTea.Enabled = true;
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void checkBoxHotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHotChocolate.Checked == true)
            {
                txtHotChocolate.Text = "0";
                txtHotChocolate.Enabled = true;
            }
            else
            {
                txtHotChocolate.Enabled = false;
                txtHotChocolate.Text = "0";
            }
        }

        private void checkBoxCheesecake_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCheesecake.Checked == true)
            {
                txtCheesecake.Text = "0";
                txtCheesecake.Enabled = true;
            }
            else
            {
                txtCheesecake.Enabled = false;
                txtCheesecake.Text = "0";
            }
        }

        private void checkBoxChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxChocolateCake.Checked == true)
            {
                txtChocolateCake.Text = "0";
                txtChocolateCake.Enabled = true;
            }
            else
            {
                txtChocolateCake.Enabled = false;
                txtChocolateCake.Text = "0";
            }
        }

        private void checkBoxNutellaCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNutellaCake.Checked == true)
            {
                txtNutellaCake.Text = "0";
                txtNutellaCake.Enabled = true;
            }
            else
            {
                txtNutellaCake.Enabled = false;
                txtNutellaCake.Text = "0";
            }
        }

        private void checkBoxFruitCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFruitCake.Checked == true)
            {
                txtFruitCake.Text = "0";
                txtFruitCake.Enabled = true;
            }
            else
            {
                txtFruitCake.Enabled = false;
                txtFruitCake.Text = "0";
            }
        }

        private void checkBoxTiramisu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTiramisu.Checked == true)
            {
                txtTiramisu.Text = "0";
                txtTiramisu.Enabled = true;
            }
            else
            {
                txtTiramisu.Enabled = false;
                txtTiramisu.Text = "0";
            }
        }

        private void checkBoxChocolateTart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChocolateTart.Checked == true)
            {
                txtChocolateTart.Text = "0";
                txtChocolateTart.Enabled = true;
            }
            else
            {
                txtChocolateTart.Enabled = false;
                txtChocolateTart.Text = "0";
            }
        }

        private void checkBoxVanillaCupcake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVanillaCupcake.Checked == true)
            {
                txtVanillaCupcakes.Text = "0";
                txtVanillaCupcakes.Enabled = true;
            }
            else
            {
                txtVanillaCupcakes.Enabled = false;
                txtVanillaCupcakes.Text = "0";
            }
        }

       
    }
}
