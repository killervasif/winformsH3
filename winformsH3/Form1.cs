using System.Text.RegularExpressions;

namespace winformsH3
{
    public partial class Form1 : Form
    {
        double petrolCost = 0;
        double marketCost = 0;
        double wcCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostValuelbl.Text = (sender as ComboBox)?.Text switch
            {
                "Diesel" => 1.ToString(),                
                "A92" => 2.7.ToString(),
                "A95" => 3.3.ToString(),                
            };
        }

        private void ByLitersrb_CheckedChanged(object sender, EventArgs e)
        {
            if (ByLitersrb.Checked)
            {
                literstxt.Enabled = true;
                moneytxt.Text = "";
            }
            else
                literstxt.Enabled = false;
        }

        private void ByMoneyrb_CheckedChanged(object sender, EventArgs e)
        {
            if (ByMoneyrb.Checked)
            {
                moneytxt.Enabled = true;
                literstxt.Text = "";
            }
            else
                moneytxt.Enabled = false;
        }

        private void moneytxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text)) return;
            if(!double.TryParse(CostValuelbl.Text,out double costValue))
            {
                MessageBox.Show("Pick a petrol type");
                (sender as TextBox).Text = "";
                return;
            }
            if (!Regex.Match((sender as TextBox)?.Text!, @"^([0-9]+([.][0-9]*)?|[.][0-9]+)$").Success)
            {
                (sender as TextBox)!.Text = string.Empty;
                TotalCostlbl.Text = string.Empty;
                MessageBox.Show("Only numbers allowed");
                return;
            }

            if (ByMoneyrb.Checked)
            {
                petrolCost = double.Parse((sender as TextBox)!.Text);
                TotalCostlbl.Text = petrolCost.ToString();
                return;
            }


            petrolCost=double.Parse((sender as TextBox)!.Text)*costValue;
            TotalCostlbl.Text=petrolCost.ToString();
            resultlbl.Text = (petrolCost + marketCost).ToString();
        }

        private void wcbtn_Click(object sender, EventArgs e)
        {
            wcCount++;
            marketCost = (double)IceteaCount.Value * double.Parse(IceTeaPrice.Text)
                + (double)hamburgerCount.Value * double.Parse(hamburgerPrice.Text)
                + (double)friesCount.Value * double.Parse(FriesPrice.Text) + (0.3 * wcCount);
            marketTotalCostlbl.Text = marketCost.ToString();
            resultlbl.Text = (petrolCost + marketCost).ToString();
        }

        private void hamburgerchk_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerchk.Checked)
                hamburgerCount.Enabled = true;
            else
            {
                hamburgerCount.Enabled = false;
                hamburgerCount.Value = 0;
            }
        }

        private void Frieschk_CheckedChanged(object sender, EventArgs e)
        {
            if (Frieschk.Checked)
                friesCount.Enabled = true;
            else
            {
                friesCount.Enabled = false;
                friesCount.Value = 0;
            }
        }

        private void Iceteachk_CheckedChanged(object sender, EventArgs e)
        {
            if (Iceteachk.Checked)
                IceteaCount.Enabled = true;
            else
            {
                IceteaCount.Enabled = false;
                IceteaCount.Value = 0;
            }
        }

        private void Count_ValueChanged(object sender, EventArgs e)
        {
            marketCost = (double)IceteaCount.Value * double.Parse(IceTeaPrice.Text)
                + (double)hamburgerCount.Value * double.Parse(hamburgerPrice.Text)
                + (double)friesCount.Value * double.Parse(FriesPrice.Text) + (0.3 * wcCount);
            marketTotalCostlbl.Text = marketCost.ToString();
            resultlbl.Text = (petrolCost + marketCost).ToString();
        }

        
    }
}