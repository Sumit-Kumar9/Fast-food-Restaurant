using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fastfood_resturent
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public  Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

       /*private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void Form_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

        }*/

        private void FriesCB_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCB.Checked == true)
            {
                FriesTB.Enabled = true;
            }
            if(FriesCB.Checked == false)
            {
                FriesTB.Enabled= false;
                FriesTB.Text = "0";
            }
        }

        private void BurgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCB.Checked == true)
            {
                BurgerTB.Enabled = true;
            }
            if (BurgerCB.Checked == false)
            {
                BurgerTB.Enabled = false;
                BurgerTB.Text = "0";
            }
        }

        private void SaladCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCB.Checked == true)
            {
                SaladTB.Enabled = true;
            }
            if (SaladCB.Checked == false)
            {
                SaladTB.Enabled = false;
                SaladTB.Text = "0";
            }
        }

        private void SandwichCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCB.Checked == true)
            {
                SandwichTB.Enabled = true;
            }
            if (SandwichCB.Checked == false)
            {
                SandwichTB.Enabled = false;
                SandwichTB.Text = "0";
            }
        }

        private void ChickenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTB.Enabled = true;
            }
            if (ChickenCB.Checked == false)
            {
                ChickenCB.Enabled = false;
                ChickenTB.Text = "0";
            }
        }

        private void CheeseCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCB.Checked == true)
            {
                CheeseTB.Enabled = true;
            }
            if (CheeseCB.Checked == false)
            {
                CheeseTB.Enabled = false;
                CheeseTB.Text = "0";
            }
        }

        private void TeaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCB.Checked == true)
            {
                TeaTB.Enabled = true;
            }
            if (TeaCB.Checked == false)
            {
                TeaTB.Enabled = false;
                TeaTB.Text = "0";
            }
        }

        private void ColaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCB.Checked == true)
            {
                ColaTB.Enabled = true;
            }
            if (ColaCB.Checked == false)
            {
                ColaTB.Enabled = false;
                ColaTB.Text = "0";
            }
        }

        private void WaterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCB.Checked == true)
            {
                WaterTB.Enabled = true;
            }
            if (WaterCB.Checked == false)
            {
                WaterTB.Enabled = false;
                WaterTB.Text = "0";
            }
        }

        private void CHocolateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CHocolateCB.Checked == true)
            {
                CHocolateTB.Enabled = true;
            }
            if (CHocolateCB.Checked == false)
            {
                CHocolateTB.Enabled = false;
                CHocolateTB.Text = "0";
            }
        }

        private void PancakesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCB.Checked == true)
            {
                PancakesTB.Enabled = true;
            }
            if (PancakesCB.Checked == false)
            {
                PancakesTB.Enabled = false;
                PancakesTB.Text = "0";
            }
        }

        private void OrangeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCB.Checked == true)
            {
                OrangeTB.Enabled = true;
            }
            if (OrangeCB.Checked == false)
            {
                OrangeTB.Enabled = false;
                OrangeTB.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Declare unit price to different meal and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseup = 80,chickenup = 120;
        double waterup = 15, teaup = 15, cocaup = 20, chocolateup = 25, panckesup = 30, orangeup = 25;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*con = new SqlConnection("Data Source=DESKTOP-HPR8H1C\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True");
            con.Open();
            String sql = button4.Text;
            cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-HPR8H1C\\SQLEXPRESS;Initial Catalog=Fastfood;Integrated Security=True");
            con.Open();
            String sql = button3.Text;
            cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text+"Subtotal: "+subtotallbl.Text+"Tax: "+taxlbl.Text+"Grand Total: "+grdtotallbl.Text,new Font("Century Gothic ",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString (ReceiptTb.Text + "Subtotal: " + subtotallbl.Text + "  Tax: " + taxlbl.Text + "  Grand Total: " + grdtotallbl.Text,new Font(" Century Gothic ",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCB.Checked = false;
            BurgerCB.Checked = false;
            SaladCB.Checked = false;
            SandwichCB.Checked = false;
            CheeseCB.Checked = false;
            CHocolateCB.Checked = false;
            TeaCB.Checked = false;  
            ColaCB.Checked = false;
            WaterCB.Checked = false;    
            CHocolateCB.Checked = false;
            PancakesCB.Checked = false; 
            OrangeCB.Checked = false;
        }

        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, cheesetp, watertp, teatp, cocatp, chocolatetp, pancaketp, orangetp, chickentp;
        double Subtotal = 0, tax, grdtotal;

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTB.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTB.Text);
            saladtp = saladup * Convert.ToDouble(SaladTB.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTB.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTB.Text);
            watertp = waterup * Convert.ToDouble(WaterTB.Text);
            teatp = teaup * Convert.ToDouble(TeaTB.Text);
            cocatp = cocaup * Convert.ToDouble(ColaTB.Text);
            chocolatetp = chocolateup * Convert.ToDouble(CHocolateTB.Text);
            pancaketp = panckesup * Convert.ToDouble(PancakesTB.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTB.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTB.Text);

            //Now let,s Add Products on The receipt
            ReceiptTb.Clear();
            Subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t    CODESPACE RESTAURENT\t\t"+"     "+Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t  ****************************"+Environment.NewLine);
            
            if(FriesCB.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (BurgerCB.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCB.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCB.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCB.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (CheeseCB.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCB.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCB.Checked == true)
            {
                ReceiptTb.AppendText("\tCoca:\t" + cocatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cocatp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCB.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (CHocolateCB.Checked == true)
            {
                ReceiptTb.AppendText("\tCHocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (PancakesCB.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancaketp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pancaketp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (OrangeCB.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + orangetp;
                subtotallbl.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.05;//0.5% tax calculation to be changed based on your palce's tax regulationds 
            grdtotal = Subtotal + tax;
            taxlbl.Text = "Rs" + tax;
            grdtotallbl.Text = "Rs" + grdtotal;
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {
            /*int i;
            for (i = 0; i <= 255; i++)
            {
                this.BackColor = Color.FromArgb(255, i, i);
            }*/
        }
    }
}
