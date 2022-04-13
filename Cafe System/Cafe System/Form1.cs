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


            txtTax.Text = "";
            txtTotal.Text = "";
            txtSubTotal.Text = "";
            txtCostOfDrinks.Text = "";
            txtCostOfDessert.Text = "";

            richTextBoxReceipt.Clear();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

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

            txtLatte.Enabled = false;
            txtEspresso.Enabled = false;
            txtMacchiato.Enabled = false;
            txtCappuccino.Enabled = false;
            txtColdCoffee.Enabled = false;
            txtTea.Enabled = false;
            txtHotChocolate.Enabled = false;


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

            txtCheesecake.Enabled = false;
            txtChocolateCake.Enabled = false;
            txtNutellaCake.Enabled = false;
            txtFruitCake.Enabled = false;
            txtTiramisu.Enabled = false;
            txtChocolateTart.Enabled = false;
            txtVanillaCupcakes.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBoxReceipt.Clear();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBoxReceipt.Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBoxReceipt.Copy();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBoxReceipt.Paste();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                richTextBoxReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Receipt" + labelDate.Text;
            saveFile.Filter = "Text files (*txt) | *.txt | All files(*.*)|*.*";

            if(saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(richTextBoxReceipt.Text);
            }

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            richTextBoxReceipt.Clear();

            richTextBoxReceipt.AppendText("------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richTextBoxReceipt.AppendText("\t\t" + "CAFE" + Environment.NewLine);
            richTextBoxReceipt.AppendText("------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            if(txtLatte.Text != "0")
            {
                richTextBoxReceipt.AppendText("Latte \t\t\t" + txtLatte.Text + Environment.NewLine);
            }
            if(txtEspresso.Text != "0")
            {
                richTextBoxReceipt.AppendText("Espresso \t\t\t" + txtEspresso.Text + Environment.NewLine);
            }
            if(txtMacchiato.Text != "0")
            {
                richTextBoxReceipt.AppendText("Macchiato \t\t" + txtMacchiato.Text + Environment.NewLine);
            }
            if(txtCappuccino.Text != "0")
            {
                richTextBoxReceipt.AppendText("Cappucchino \t\t" + txtCappuccino.Text + Environment.NewLine);
            }
            if(txtColdCoffee.Text != "0")
            {
                richTextBoxReceipt.AppendText("Cold Coffee \t\t" + txtColdCoffee.Text + Environment.NewLine);
            }
            if(txtTea.Text != "0")
            {
                richTextBoxReceipt.AppendText("Tea \t\t\t" + txtTea.Text + Environment.NewLine);
            }
            if(txtHotChocolate.Text != "0")
            {
                richTextBoxReceipt.AppendText("Hot Chocolate \t\t" + txtHotChocolate.Text + Environment.NewLine);
            }
            if(txtCheesecake.Text != "0")
            {
                richTextBoxReceipt.AppendText("Cheesecake \t\t" + txtCheesecake.Text + Environment.NewLine);
            }
            if(txtNutellaCake.Text != "0")
            {
                richTextBoxReceipt.AppendText("Nutella Cake \t\t" + txtNutellaCake.Text + Environment.NewLine);
            }
            if(txtFruitCake.Text != "0")
            {
                richTextBoxReceipt.AppendText("Fruit Cake \t\t" + txtFruitCake.Text + Environment.NewLine);
            }
            if(txtChocolateCake.Text != "0")
            {
                richTextBoxReceipt.AppendText("Chocolate Cake \t\t" + txtChocolateCake.Text + Environment.NewLine);
            }
            if(txtTiramisu.Text != "0")
            {
                richTextBoxReceipt.AppendText("Tiramisu \t\t\t" + txtTiramisu.Text + Environment.NewLine);
            }
            if(txtChocolateTart.Text != "0")
            {
                richTextBoxReceipt.AppendText("Chocolate Tart \t\t" + txtChocolateTart.Text + Environment.NewLine);
            }
            if(txtVanillaCupcakes.Text != "0")
            {
                richTextBoxReceipt.AppendText("Vnilla Cupcake \t\t" + txtVanillaCupcakes.Text + Environment.NewLine);
            }
            richTextBoxReceipt.AppendText("------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richTextBoxReceipt.AppendText("Service Charge \t\t" + txtServiceCharge.Text + Environment.NewLine);
            richTextBoxReceipt.AppendText("------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richTextBoxReceipt.AppendText("TAX: \t\t\t" + txtTax.Text + Environment.NewLine);
            richTextBoxReceipt.AppendText("SUBTOTAL: \t\t" + txtSubTotal.Text + Environment.NewLine);
            richTextBoxReceipt.AppendText("TOTAL: \t\t\t" + txtTotal.Text + Environment.NewLine);
            richTextBoxReceipt.AppendText("------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            richTextBoxReceipt.AppendText(labelTimer.Text + "\t" + labelDate.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}