namespace winformsH3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Petrol = new System.Windows.Forms.GroupBox();
            this.TotalCostlbl = new System.Windows.Forms.Label();
            this.Totallb = new System.Windows.Forms.Label();
            this.moneytxt = new System.Windows.Forms.TextBox();
            this.literstxt = new System.Windows.Forms.TextBox();
            this.ByMoneyrb = new System.Windows.Forms.RadioButton();
            this.ByLitersrb = new System.Windows.Forms.RadioButton();
            this.CostValuelbl = new System.Windows.Forms.Label();
            this.Costlbl = new System.Windows.Forms.Label();
            this.Typelbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Market = new System.Windows.Forms.GroupBox();
            this.wcbtn = new System.Windows.Forms.Button();
            this.marketTotalCostlbl = new System.Windows.Forms.Label();
            this.marketTotallbl = new System.Windows.Forms.Label();
            this.IceteaCount = new System.Windows.Forms.NumericUpDown();
            this.friesCount = new System.Windows.Forms.NumericUpDown();
            this.hamburgerCount = new System.Windows.Forms.NumericUpDown();
            this.IceTeaPrice = new System.Windows.Forms.Label();
            this.FriesPrice = new System.Windows.Forms.Label();
            this.hamburgerPrice = new System.Windows.Forms.Label();
            this.Iceteachk = new System.Windows.Forms.CheckBox();
            this.Frieschk = new System.Windows.Forms.CheckBox();
            this.hamburgerchk = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultlbl = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.GroupBox();
            this.Petrol.SuspendLayout();
            this.Market.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IceteaCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerCount)).BeginInit();
            this.Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // Petrol
            // 
            this.Petrol.Controls.Add(this.TotalCostlbl);
            this.Petrol.Controls.Add(this.Totallb);
            this.Petrol.Controls.Add(this.moneytxt);
            this.Petrol.Controls.Add(this.literstxt);
            this.Petrol.Controls.Add(this.ByMoneyrb);
            this.Petrol.Controls.Add(this.ByLitersrb);
            this.Petrol.Controls.Add(this.CostValuelbl);
            this.Petrol.Controls.Add(this.Costlbl);
            this.Petrol.Controls.Add(this.Typelbl);
            this.Petrol.Controls.Add(this.comboBox1);
            this.Petrol.Location = new System.Drawing.Point(12, 12);
            this.Petrol.Name = "Petrol";
            this.Petrol.Size = new System.Drawing.Size(200, 251);
            this.Petrol.TabIndex = 0;
            this.Petrol.TabStop = false;
            this.Petrol.Text = "Petrol";
            // 
            // TotalCostlbl
            // 
            this.TotalCostlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostlbl.Location = new System.Drawing.Point(90, 193);
            this.TotalCostlbl.Name = "TotalCostlbl";
            this.TotalCostlbl.Size = new System.Drawing.Size(91, 17);
            this.TotalCostlbl.TabIndex = 9;
            this.TotalCostlbl.Text = "Cost";
            // 
            // Totallb
            // 
            this.Totallb.AutoSize = true;
            this.Totallb.Location = new System.Drawing.Point(6, 193);
            this.Totallb.Name = "Totallb";
            this.Totallb.Size = new System.Drawing.Size(32, 15);
            this.Totallb.TabIndex = 8;
            this.Totallb.Text = "Total";
            // 
            // moneytxt
            // 
            this.moneytxt.Enabled = false;
            this.moneytxt.Location = new System.Drawing.Point(90, 125);
            this.moneytxt.Name = "moneytxt";
            this.moneytxt.Size = new System.Drawing.Size(91, 23);
            this.moneytxt.TabIndex = 7;
            this.moneytxt.TextChanged += new System.EventHandler(this.moneytxt_TextChanged);
            // 
            // literstxt
            // 
            this.literstxt.Enabled = false;
            this.literstxt.Location = new System.Drawing.Point(90, 96);
            this.literstxt.Name = "literstxt";
            this.literstxt.Size = new System.Drawing.Size(91, 23);
            this.literstxt.TabIndex = 6;
            this.literstxt.TextChanged += new System.EventHandler(this.moneytxt_TextChanged);
            // 
            // ByMoneyrb
            // 
            this.ByMoneyrb.AutoSize = true;
            this.ByMoneyrb.Location = new System.Drawing.Point(6, 125);
            this.ByMoneyrb.Name = "ByMoneyrb";
            this.ByMoneyrb.Size = new System.Drawing.Size(78, 19);
            this.ByMoneyrb.TabIndex = 5;
            this.ByMoneyrb.Text = "By Money";
            this.ByMoneyrb.UseVisualStyleBackColor = true;
            this.ByMoneyrb.CheckedChanged += new System.EventHandler(this.ByMoneyrb_CheckedChanged);
            // 
            // ByLitersrb
            // 
            this.ByLitersrb.AutoSize = true;
            this.ByLitersrb.Location = new System.Drawing.Point(6, 97);
            this.ByLitersrb.Name = "ByLitersrb";
            this.ByLitersrb.Size = new System.Drawing.Size(69, 19);
            this.ByLitersrb.TabIndex = 4;
            this.ByLitersrb.Text = "By Liters";
            this.ByLitersrb.UseVisualStyleBackColor = true;
            this.ByLitersrb.CheckedChanged += new System.EventHandler(this.ByLitersrb_CheckedChanged);
            // 
            // CostValuelbl
            // 
            this.CostValuelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostValuelbl.Location = new System.Drawing.Point(90, 56);
            this.CostValuelbl.Name = "CostValuelbl";
            this.CostValuelbl.Size = new System.Drawing.Size(91, 17);
            this.CostValuelbl.TabIndex = 3;
            this.CostValuelbl.Text = "Value";
            // 
            // Costlbl
            // 
            this.Costlbl.AutoSize = true;
            this.Costlbl.Location = new System.Drawing.Point(6, 58);
            this.Costlbl.Name = "Costlbl";
            this.Costlbl.Size = new System.Drawing.Size(31, 15);
            this.Costlbl.TabIndex = 2;
            this.Costlbl.Text = "Cost";
            // 
            // Typelbl
            // 
            this.Typelbl.AutoSize = true;
            this.Typelbl.Location = new System.Drawing.Point(6, 33);
            this.Typelbl.Name = "Typelbl";
            this.Typelbl.Size = new System.Drawing.Size(31, 15);
            this.Typelbl.TabIndex = 1;
            this.Typelbl.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "A92"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A92",
            "A95",
            "Diesel"});
            this.comboBox1.Location = new System.Drawing.Point(90, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Market
            // 
            this.Market.Controls.Add(this.wcbtn);
            this.Market.Controls.Add(this.marketTotalCostlbl);
            this.Market.Controls.Add(this.marketTotallbl);
            this.Market.Controls.Add(this.IceteaCount);
            this.Market.Controls.Add(this.friesCount);
            this.Market.Controls.Add(this.hamburgerCount);
            this.Market.Controls.Add(this.IceTeaPrice);
            this.Market.Controls.Add(this.FriesPrice);
            this.Market.Controls.Add(this.hamburgerPrice);
            this.Market.Controls.Add(this.Iceteachk);
            this.Market.Controls.Add(this.Frieschk);
            this.Market.Controls.Add(this.hamburgerchk);
            this.Market.Location = new System.Drawing.Point(262, 12);
            this.Market.Name = "Market";
            this.Market.Size = new System.Drawing.Size(230, 251);
            this.Market.TabIndex = 1;
            this.Market.TabStop = false;
            this.Market.Text = "Market";
            // 
            // wcbtn
            // 
            this.wcbtn.Location = new System.Drawing.Point(73, 141);
            this.wcbtn.Name = "wcbtn";
            this.wcbtn.Size = new System.Drawing.Size(75, 23);
            this.wcbtn.TabIndex = 11;
            this.wcbtn.Text = "WC";
            this.wcbtn.UseVisualStyleBackColor = true;
            this.wcbtn.Click += new System.EventHandler(this.wcbtn_Click);
            // 
            // marketTotalCostlbl
            // 
            this.marketTotalCostlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marketTotalCostlbl.Location = new System.Drawing.Point(110, 193);
            this.marketTotalCostlbl.Name = "marketTotalCostlbl";
            this.marketTotalCostlbl.Size = new System.Drawing.Size(91, 17);
            this.marketTotalCostlbl.TabIndex = 10;
            this.marketTotalCostlbl.Text = "Cost";
            // 
            // marketTotallbl
            // 
            this.marketTotallbl.AutoSize = true;
            this.marketTotallbl.Location = new System.Drawing.Point(19, 193);
            this.marketTotallbl.Name = "marketTotallbl";
            this.marketTotallbl.Size = new System.Drawing.Size(32, 15);
            this.marketTotallbl.TabIndex = 10;
            this.marketTotallbl.Text = "Total";
            // 
            // IceteaCount
            // 
            this.IceteaCount.Enabled = false;
            this.IceteaCount.Location = new System.Drawing.Point(154, 93);
            this.IceteaCount.Name = "IceteaCount";
            this.IceteaCount.Size = new System.Drawing.Size(76, 23);
            this.IceteaCount.TabIndex = 10;
            this.IceteaCount.ValueChanged += new System.EventHandler(this.Count_ValueChanged);
            // 
            // friesCount
            // 
            this.friesCount.Enabled = false;
            this.friesCount.Location = new System.Drawing.Point(154, 60);
            this.friesCount.Name = "friesCount";
            this.friesCount.Size = new System.Drawing.Size(76, 23);
            this.friesCount.TabIndex = 9;
            this.friesCount.ValueChanged += new System.EventHandler(this.Count_ValueChanged);
            // 
            // hamburgerCount
            // 
            this.hamburgerCount.Enabled = false;
            this.hamburgerCount.Location = new System.Drawing.Point(154, 22);
            this.hamburgerCount.Name = "hamburgerCount";
            this.hamburgerCount.Size = new System.Drawing.Size(76, 23);
            this.hamburgerCount.TabIndex = 8;
            this.hamburgerCount.ValueChanged += new System.EventHandler(this.Count_ValueChanged);
            // 
            // IceTeaPrice
            // 
            this.IceTeaPrice.AutoSize = true;
            this.IceTeaPrice.Location = new System.Drawing.Point(110, 96);
            this.IceTeaPrice.Name = "IceTeaPrice";
            this.IceTeaPrice.Size = new System.Drawing.Size(22, 15);
            this.IceTeaPrice.TabIndex = 6;
            this.IceTeaPrice.Text = "1.2";
            // 
            // FriesPrice
            // 
            this.FriesPrice.AutoSize = true;
            this.FriesPrice.Location = new System.Drawing.Point(110, 62);
            this.FriesPrice.Name = "FriesPrice";
            this.FriesPrice.Size = new System.Drawing.Size(22, 15);
            this.FriesPrice.TabIndex = 5;
            this.FriesPrice.Text = "2.5";
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.AutoSize = true;
            this.hamburgerPrice.Location = new System.Drawing.Point(110, 24);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.Size = new System.Drawing.Size(13, 15);
            this.hamburgerPrice.TabIndex = 4;
            this.hamburgerPrice.Text = "2";
            // 
            // Iceteachk
            // 
            this.Iceteachk.AutoSize = true;
            this.Iceteachk.Location = new System.Drawing.Point(10, 96);
            this.Iceteachk.Name = "Iceteachk";
            this.Iceteachk.Size = new System.Drawing.Size(60, 19);
            this.Iceteachk.TabIndex = 2;
            this.Iceteachk.Text = "Ice tea";
            this.Iceteachk.UseVisualStyleBackColor = true;
            this.Iceteachk.CheckedChanged += new System.EventHandler(this.Iceteachk_CheckedChanged);
            // 
            // Frieschk
            // 
            this.Frieschk.AutoSize = true;
            this.Frieschk.Location = new System.Drawing.Point(10, 58);
            this.Frieschk.Name = "Frieschk";
            this.Frieschk.Size = new System.Drawing.Size(50, 19);
            this.Frieschk.TabIndex = 1;
            this.Frieschk.Text = "Fries";
            this.Frieschk.UseVisualStyleBackColor = true;
            this.Frieschk.CheckedChanged += new System.EventHandler(this.Frieschk_CheckedChanged);
            // 
            // hamburgerchk
            // 
            this.hamburgerchk.AutoSize = true;
            this.hamburgerchk.Location = new System.Drawing.Point(10, 23);
            this.hamburgerchk.Name = "hamburgerchk";
            this.hamburgerchk.Size = new System.Drawing.Size(87, 19);
            this.hamburgerchk.TabIndex = 0;
            this.hamburgerchk.Text = "Hamburger";
            this.hamburgerchk.UseVisualStyleBackColor = true;
            this.hamburgerchk.CheckedChanged += new System.EventHandler(this.hamburgerchk_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total";
            // 
            // resultlbl
            // 
            this.resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultlbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultlbl.Location = new System.Drawing.Point(254, 19);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(115, 49);
            this.resultlbl.TabIndex = 12;
            this.resultlbl.Text = "Cost";
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.label7);
            this.Payment.Controls.Add(this.resultlbl);
            this.Payment.Location = new System.Drawing.Point(27, 293);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(465, 100);
            this.Payment.TabIndex = 13;
            this.Payment.TabStop = false;
            this.Payment.Text = "Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Market);
            this.Controls.Add(this.Petrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Petrol.ResumeLayout(false);
            this.Petrol.PerformLayout();
            this.Market.ResumeLayout(false);
            this.Market.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IceteaCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerCount)).EndInit();
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Petrol;
        private ComboBox comboBox1;
        private Label CostValuelbl;
        private Label Costlbl;
        private Label Typelbl;
        private TextBox moneytxt;
        private TextBox literstxt;
        private RadioButton ByMoneyrb;
        private RadioButton ByLitersrb;
        private Label TotalCostlbl;
        private Label Totallb;
        private GroupBox Market;
        private Label marketTotalCostlbl;
        private Label marketTotallbl;
        private NumericUpDown IceteaCount;
        private NumericUpDown friesCount;
        private NumericUpDown hamburgerCount;
        private Label IceTeaPrice;
        private Label FriesPrice;
        private Label hamburgerPrice;
        private CheckBox Iceteachk;
        private CheckBox Frieschk;
        private CheckBox hamburgerchk;
        private Label label7;
        private Label resultlbl;
        private GroupBox Payment;
        private Button wcbtn;
    }
}