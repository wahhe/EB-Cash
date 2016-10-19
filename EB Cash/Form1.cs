using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB_Cash
{
    public partial class EBCash : Form
    {
        const double CHICKEN_PRICE = 5.5;
        int chicken = 0;
        const double BEEF_PRICE = 6.0;
        int beef = 0;
        const double SOFTDRINK_PRICE = 5.5;
        int softdrink = 0;
        const double FRIES_PRICE = 5.5;
        int fries = 0;
        const double POUTINE_PRICE = 5.5;
        int poutine = 0;
        const double TAX_COST = 0.13;
        double total, taxCost, priceWithTax,subtotal, tendered, change;

        

        private void calculateP_Click(object sender, EventArgs e)
        {
            //put in all the constants and doubles
            chicken = Convert.ToInt32(CBox.Text);
            beef = Convert.ToInt32(BBox.Text);
            softdrink = Convert.ToInt32(SBox.Text);
            fries = Convert.ToInt32(FBox.Text);
            poutine = Convert.ToInt32(PBox.Text);

            //calculate the subtotal, taxcost and price with tax
            subtotal = beef * BEEF_PRICE + chicken * CHICKEN_PRICE + softdrink * SOFTDRINK_PRICE + fries * FRIES_PRICE + poutine * POUTINE_PRICE;
            stPlabel.Text = subtotal.ToString("C");
            taxCost = subtotal * TAX_COST;
            tPlabel.Text = taxCost.ToString("C");
            priceWithTax = subtotal + taxCost;
            totalPlabel.Text = priceWithTax.ToString("C");

        }
            //set the tendered up and let it calculate the change
        private void calchange_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedInput.Text);
            change = tendered - priceWithTax;
            changeP.Text = change.ToString("C");
        }

        //set the receipt printer up and creat a receipt
        private void Printbutton_Click(object sender, EventArgs e)
        {
            Graphics fg1 = this.CreateGraphics();
            Graphics fg2 = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 3);
            SolidBrush frameBrush = new SolidBrush(Color.White);
            Font titleFont = new Font("Trajan Pro", 12, FontStyle.Bold);
            SolidBrush titleBrush = new SolidBrush(Color.Black);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            Font wordFont = new Font("Arial", 10, FontStyle.Bold);


            //make up the receipt, print it
            fg1.DrawRectangle(drawPen, 350, 90, 350, 410);
            fg1.FillRectangle(frameBrush, 350, 90, 350, 410);

            fg2.DrawString("Welcome to the EatBurger", titleFont, titleBrush, 400, 110);
            fg2.DrawString("Order #0816", wordFont, fontBrush, 380, 150);
            fg2.DrawString("beef", wordFont, fontBrush, 380, 165);
            fg2.DrawString("chicken", wordFont, fontBrush, 380, 180);









        }

        public EBCash()
        {
            InitializeComponent(); 
        }

       


    }
    }

