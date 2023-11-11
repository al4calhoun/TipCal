using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customTipGB.Hide();
            splitCheckGB.Hide();
            discountGB.Hide();
            partiesGB.Hide();
        }
        private void calculateTip(decimal number, string type)
        {
            try  //finish try/catch statement
            {
                decimal tip = 0;
                decimal totalBill = decimal.Parse(TotalTxt.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number);
                TotalTxt.Text = totalBill.ToString();

                switch (type)
                {
                    case "p":
                        tip = (totalBill * number / 100);
                        totalTipTxt.Text = tip.ToString("c");
                        break;
                    case "d":
                        tip = number;
                        totalTipTxt.Text = tip.ToString("c");
                        break;
                    default:
                        break;
                }

                decimal grandTotal = totalBill + tip;
                grandTotalTxt.Text = grandTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Please enter a valid value for your total bill amount.");
            }
        }
        private void tip5RB_CheckedChanged(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "") //make sure the total bill amount is not empty
            {
                calculateTip(5, "p"); //pass in "p" for type percent
                setDefaultCustomTipGP();
            }
        }
        private void tip10RB_CheckedChanged(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "") //make sure the total bill amount is not empty
            {
                calculateTip(10, "p");
                setDefaultCustomTipGP();
            }
        }

        private void tip15RB_CheckedChanged(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "") //make sure the total bill amount is not empty
            {
                calculateTip(15, "p");
                setDefaultCustomTipGP();
            }
        }

        private void tip20RB_CheckedChanged(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "") //make sure the total bill amount is not empty
            {
                calculateTip(20, "p");
                setDefaultCustomTipGP();
            }
        }

        private void tip25RB_CheckedChanged(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "") //make sure the total bill amount is not empty
            {
                calculateTip(25, "p");
                setDefaultCustomTipGP();
            }
        }

        private void CustomTipRB_CheckedChanged(object sender, EventArgs e)
        {
            customTipGB.Show();
            totalTipTxt.Clear();
            grandTotalTxt.Clear();
        }

        private void setDefaultCustomTipGP()
        {
            customTipGB.Hide();
            customTipTxt.Clear();
            percentCB.Checked = false;
        }

        private void calculateCustomBtn_Click(object sender, EventArgs e)
        {
            if (totalBilltxt.Text.ToString() != "")
            {
                try
                {
                    calculateCustomTip();
                }
                catch
                {
                    MessageBox.Show("Please enter a tip amount.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid value for your total bill amount.");
            }
        }

        private void splitCheckCB_CheckedChanged(object sender, EventArgs e)
        {
            if (splitCheckCB.Checked)
            {
                splitCheckGB.Show();
            }
            else
            {
                splitCheckGB.Hide();
            }
        }

        private void totalBilltxt_TextChanged(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (totalDiscounttxt.Text != "")
            {
                discount = decimal.Parse(totalDiscounttxt.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number);
            }
            decimal total = decimal.Parse(totalBilltxt.Text);
            total = total - discount;
            TotalTxt.Text = total.ToString("c");

            if (totalBilltxt.Text.ToString() == "")
            {
                setDefaultCustomTipGP();
                grandTotalTxt.Clear();
                totalTipTxt.Clear();

                if (tip5RB.Checked) { tip5RB.Checked = false; }
                else if (tip10RB.Checked) { tip10RB.Checked = false; }
                else if (tip15RB.Checked) { tip15RB.Checked = false; }
                else if (tip20RB.Checked) { tip20RB.Checked = false; }
                else if (tip25RB.Checked) { tip25RB.Checked = false; }
                else if (CustomTipRB.Checked)
                {
                    CustomTipRB.Checked = false;
                    customTipGB.Hide();
                }
            }
            else
            {
                if (tip5RB.Checked) { calculateTip(5, "p"); }
                else if (tip10RB.Checked) { calculateTip(10, "p"); }
                else if (tip15RB.Checked) { calculateTip(15, "p"); }
                else if (tip20RB.Checked) { calculateTip(20, "p"); }
                else if (tip25RB.Checked) { calculateTip(25, "p"); }
                else if (CustomTipRB.Checked)
                {
                    calculateCustomTip();
                }
            }
        }

        private void percentCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateCustomTip();
        }
        private void calculateCustomTip()
        {
            if (totalBilltxt.Text.ToString() != "")
            {
                decimal customTip;
                string type;

                if (customTipTxt.Text.ToString() == "")
                {
                    customTip = decimal.Zero;
                }
                else
                {
                    customTip = decimal.Parse(customTipTxt.Text);
                }

                if (percentCB.Checked) //check type, p = percent, d = dollar
                {
                    type = "p";
                }
                else
                {
                    type = "d";
                }
                calculateTip(customTip, type);
            }
        }

        private void applyDiscountCB_CheckedChanged(object sender, EventArgs e)
        {
            if (applyDiscountCB.Checked)
            {
                discountGB.Show();
            }
            else
            {
                discountGB.Hide();
            }

        }

        private void discountAmounttxt_TextChanged(object sender, EventArgs e)
        {
            calculateDiscount();
        }

        private void discountPercentCB_CheckedChanged(object sender, EventArgs e)
        {
            calculateDiscount();
        }

        private void calculateDiscount()
        {
            decimal discount = 0;
            string type;
            if (totalBilltxt.Text.ToString() != "")
            {
                if (discountAmounttxt.Text.ToString() == "")
                {
                    discount = decimal.Zero;
                }
                else
                {
                    discount = decimal.Parse(discountAmounttxt.Text);
                }

                if (discountPercentCB.Checked) //check type, p = percent, d = dollar
                {
                    type = "p";
                }
                else
                {
                    type = "d";
                }

                try  
                {
                    decimal totalBill = decimal.Parse(totalBilltxt.Text);
                    switch (type)
                    {
                        case "p":
                            discount = (totalBill * discount / 100);
                            totalDiscounttxt.Text = discount.ToString("c");
                            break;
                        case "d":
                            totalDiscounttxt.Text = discount.ToString("c");
                            break;
                        default:
                            break;
                    }

                    if(discount > totalBill)
                    {
                        MessageBox.Show("Discount can't be greater than total bill.");
                    }
                    else
                    {
                        decimal discountedTotal = totalBill - discount;
                        TotalTxt.Text = discountedTotal.ToString("c");

                        if (tip5RB.Checked) { tip5RB.Checked = false; }
                        else if (tip10RB.Checked) { tip10RB.Checked = false; }
                        else if (tip15RB.Checked) { tip15RB.Checked = false; }
                        else if (tip20RB.Checked) { tip20RB.Checked = false; }
                        else if (tip25RB.Checked) { tip25RB.Checked = false; }
                        else if (CustomTipRB.Checked)
                        {
                            CustomTipRB.Checked = false;
                            customTipGB.Hide();
                        }
                        totalTipTxt.Clear();
                        grandTotalTxt.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid value for your total bill amount.");

                }
            }
        }
        private void numOfPartyComboB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfParty = int.Parse(numOfPartyComboB.SelectedItem.ToString());

            if (splitEquallyCB.Checked)
            {
                decimal grandTotal = decimal.Parse(grandTotalTxt.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number);
                decimal splitTotal = grandTotal / numOfParty;
                eachPartyPaysTxt.Text = splitTotal.ToString("c");
            }
            else
            {
                splitPartyView(numOfParty);
            }
        }

        private void splitPartyView(int numParty)
        {
            partiesGB.Show();
            percentLabel.Show();
            totalLabel.Show();
            totalPercentTxt.Show();

            switch(numParty) 
            {
                case 2:
                    Party1Label.Show();
                    party1txt.Show();
                    party1txt.Clear();
                    party1totaltxt.Show();
                    party1totaltxt.Clear();
                    party2txt.Show();
                    party2txt.Clear();
                    party2totalTxt.Show();
                    party2totalTxt.Clear();
                    Party2Label.Show();
                    Party3Label.Hide();
                    party3txt.Hide();
                    party3txt.Clear();
                    party3totalTxt.Hide();
                    party3totalTxt.Clear();
                    party4txt.Hide();
                    party4txt.Clear();
                    party4TotalTxt.Clear();
                    Party4Label.Hide();
                    party4TotalTxt.Hide();  
                    party5txt.Hide();
                    party5txt.Clear();
                    Party5Label.Hide();
                    party5TotalTxt.Hide();
                    party5TotalTxt.Clear();
                   break;
                case 3:
                    Party1Label.Show();
                    party1txt.Show();
                    party1txt.Clear();
                    party1totaltxt.Show();
                    party1totaltxt.Clear();
                    party2txt.Show();
                    party2txt.Clear();
                    party2totalTxt.Show();
                    party2totalTxt.Clear();
                    Party2Label.Show();
                    Party3Label.Show();
                    party3txt.Show();
                    party3txt.Clear();
                    party3totalTxt.Show();
                    party3totalTxt.Clear();
                    party4txt.Hide();
                    party4txt.Clear();
                    Party4Label.Hide();
                    party4TotalTxt.Hide();
                    party4TotalTxt.Clear();
                    party5txt.Hide();
                    party5txt.Clear();
                    Party5Label.Hide();
                    party5TotalTxt.Hide();
                    party5TotalTxt.Clear();
                    break;
                case 4:
                    Party1Label.Show();
                    party1txt.Show();
                    party1txt.Clear();
                    party1totaltxt.Show();
                    party1totaltxt.Clear();
                    party2txt.Show();
                    party2txt.Clear();
                    party2totalTxt.Show();
                    party2totalTxt.Clear();
                    Party2Label.Show();
                    Party3Label.Show();
                    party3txt.Show();
                    party3txt.Clear();
                    party3totalTxt.Show();
                    party3totalTxt.Clear();
                    party4txt.Show();
                    party4txt.Clear();
                    Party4Label.Show();
                    party4TotalTxt.Show();
                    party4TotalTxt.Clear();
                    party5txt.Hide();
                    party5txt.Clear ();
                    Party5Label.Hide();
                    party5TotalTxt.Hide();
                    party5TotalTxt.Clear();
                    break;
                case 5:
                    Party1Label.Show();
                    party1txt.Show();
                    party1txt.Clear();
                    party1totaltxt.Show();
                    party1totaltxt.Clear();
                    party2txt.Show();
                    party2txt.Clear();
                    party2totalTxt.Show();
                    party2totalTxt.Clear();
                    Party2Label.Show();
                    Party3Label.Show();
                    party3txt.Show();
                    party3txt.Clear();
                    party3totalTxt.Show();
                    party3totalTxt.Clear();
                    party4txt.Show();
                    party4txt.Clear();
                    Party4Label.Show();
                    party4TotalTxt.Show();
                    party4TotalTxt.Clear();
                    party5txt.Show();
                    party5txt.Clear();
                    Party5Label.Show();
                    party5TotalTxt.Show();
                    party5TotalTxt.Clear();
                    break;
                default:
                   break;
            }
        }
        private void splitEquallyCB_CheckedChanged(object sender, EventArgs e)
        {
            if (splitEquallyCB.Checked)
            {
                eachPartyPaysTxt.Show();
                partyPaysLabel.Show();
            }
            else
            {
                eachPartyPaysTxt.Hide();
                partyPaysLabel.Hide();
            }
        }


        private decimal calculateCheck(decimal percent)
        {
            decimal grandtotal = decimal.Parse(grandTotalTxt.Text,
                               System.Globalization.NumberStyles.AllowCurrencySymbol |
                               System.Globalization.NumberStyles.Number);
            percent = grandtotal * percent / 100;
            return percent;
        }


        private void party1txt_TextChanged(object sender, EventArgs e)
        {
            if (grandTotalTxt.Text != "" && party1txt.Text != "")
            {
                decimal party1percent = decimal.Parse(party1txt.Text);
                party1totaltxt.Text = calculateCheck(party1percent).ToString();
            }
        }

        private void party2txt_TextChanged(object sender, EventArgs e)
        {
            if (grandTotalTxt.Text != "" && party2txt.Text != "")
            {
                decimal party2percent = decimal.Parse(party2txt.Text);
                party2totalTxt.Text = calculateCheck(party2percent).ToString();
            }
        }

        private void party3txt_TextChanged(object sender, EventArgs e)
        {
            if (grandTotalTxt.Text != "" && party3txt.Text != "")
            {
                decimal party3percent = decimal.Parse(party3txt.Text);
                party3totalTxt.Text = calculateCheck(party3percent).ToString();
            }
        }

        private void party4txt_TextChanged(object sender, EventArgs e)
        {
            if (grandTotalTxt.Text != "" && party4txt.Text != "")
            {
                decimal party4percent = decimal.Parse(party4txt.Text);
                party4TotalTxt.Text = calculateCheck(party4percent).ToString();
            }
        }
        private void party5txt_TextChanged(object sender, EventArgs e)
        {
            if (grandTotalTxt.Text != "" && party5txt.Text != "")
            {
                decimal party5percent = decimal.Parse(party5txt.Text);
                party5TotalTxt.Text = calculateCheck(party5percent).ToString();
            }
        }
    }
}
