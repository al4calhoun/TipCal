namespace TipCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.totalBilltxt = new System.Windows.Forms.TextBox();
            this.tipGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomTipRB = new System.Windows.Forms.RadioButton();
            this.tip25RB = new System.Windows.Forms.RadioButton();
            this.tip15RB = new System.Windows.Forms.RadioButton();
            this.tip20RB = new System.Windows.Forms.RadioButton();
            this.tip10RB = new System.Windows.Forms.RadioButton();
            this.tip5RB = new System.Windows.Forms.RadioButton();
            this.totalTipTxt = new System.Windows.Forms.TextBox();
            this.totalTipLabel = new System.Windows.Forms.Label();
            this.grandTotalTxt = new System.Windows.Forms.TextBox();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.splitCheckCB = new System.Windows.Forms.CheckBox();
            this.customTipGB = new System.Windows.Forms.GroupBox();
            this.calculateCustomBtn = new System.Windows.Forms.Button();
            this.customTipTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.percentCB = new System.Windows.Forms.CheckBox();
            this.splitCheckGB = new System.Windows.Forms.GroupBox();
            this.splitEquallyCB = new System.Windows.Forms.CheckBox();
            this.numOfPartyLabel = new System.Windows.Forms.Label();
            this.numOfPartyComboB = new System.Windows.Forms.ComboBox();
            this.party5TotalTxt = new System.Windows.Forms.TextBox();
            this.party5txt = new System.Windows.Forms.TextBox();
            this.Party5Label = new System.Windows.Forms.Label();
            this.party4TotalTxt = new System.Windows.Forms.TextBox();
            this.party3totalTxt = new System.Windows.Forms.TextBox();
            this.party2totalTxt = new System.Windows.Forms.TextBox();
            this.party1totaltxt = new System.Windows.Forms.TextBox();
            this.party4txt = new System.Windows.Forms.TextBox();
            this.party3txt = new System.Windows.Forms.TextBox();
            this.party2txt = new System.Windows.Forms.TextBox();
            this.party1txt = new System.Windows.Forms.TextBox();
            this.Party4Label = new System.Windows.Forms.Label();
            this.Party3Label = new System.Windows.Forms.Label();
            this.Party2Label = new System.Windows.Forms.Label();
            this.Party1Label = new System.Windows.Forms.Label();
            this.eachPartyPaysTxt = new System.Windows.Forms.TextBox();
            this.partyPaysLabel = new System.Windows.Forms.Label();
            this.applyDiscountCB = new System.Windows.Forms.CheckBox();
            this.discountGB = new System.Windows.Forms.GroupBox();
            this.discountAmounttxt = new System.Windows.Forms.TextBox();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountPercentCB = new System.Windows.Forms.CheckBox();
            this.totalDiscounttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.partiesGB = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.totalPercentTxt = new System.Windows.Forms.TextBox();
            this.tipGroupBox.SuspendLayout();
            this.customTipGB.SuspendLayout();
            this.splitCheckGB.SuspendLayout();
            this.discountGB.SuspendLayout();
            this.partiesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Location = new System.Drawing.Point(20, 21);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(53, 13);
            this.totalBillLabel.TabIndex = 0;
            this.totalBillLabel.Text = "Total Bill :";
            // 
            // totalBilltxt
            // 
            this.totalBilltxt.Location = new System.Drawing.Point(122, 14);
            this.totalBilltxt.Name = "totalBilltxt";
            this.totalBilltxt.Size = new System.Drawing.Size(100, 20);
            this.totalBilltxt.TabIndex = 1;
            this.totalBilltxt.TextChanged += new System.EventHandler(this.totalBilltxt_TextChanged);
            // 
            // tipGroupBox
            // 
            this.tipGroupBox.Controls.Add(this.CustomTipRB);
            this.tipGroupBox.Controls.Add(this.tip25RB);
            this.tipGroupBox.Controls.Add(this.tip15RB);
            this.tipGroupBox.Controls.Add(this.tip20RB);
            this.tipGroupBox.Controls.Add(this.tip10RB);
            this.tipGroupBox.Controls.Add(this.tip5RB);
            this.tipGroupBox.Location = new System.Drawing.Point(23, 123);
            this.tipGroupBox.Name = "tipGroupBox";
            this.tipGroupBox.Size = new System.Drawing.Size(199, 165);
            this.tipGroupBox.TabIndex = 2;
            this.tipGroupBox.TabStop = false;
            this.tipGroupBox.Text = "Select Preselected Tip";
            // 
            // CustomTipRB
            // 
            this.CustomTipRB.AutoSize = true;
            this.CustomTipRB.Location = new System.Drawing.Point(7, 135);
            this.CustomTipRB.Name = "CustomTipRB";
            this.CustomTipRB.Size = new System.Drawing.Size(78, 17);
            this.CustomTipRB.TabIndex = 6;
            this.CustomTipRB.Text = "Custom Tip";
            this.CustomTipRB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CustomTipRB.UseVisualStyleBackColor = true;
            this.CustomTipRB.CheckedChanged += new System.EventHandler(this.CustomTipRB_CheckedChanged);
            // 
            // tip25RB
            // 
            this.tip25RB.AutoSize = true;
            this.tip25RB.Location = new System.Drawing.Point(7, 112);
            this.tip25RB.Name = "tip25RB";
            this.tip25RB.Size = new System.Drawing.Size(63, 17);
            this.tip25RB.TabIndex = 5;
            this.tip25RB.Text = "25% Tip";
            this.tip25RB.UseVisualStyleBackColor = true;
            this.tip25RB.CheckedChanged += new System.EventHandler(this.tip25RB_CheckedChanged);
            // 
            // tip15RB
            // 
            this.tip15RB.AutoSize = true;
            this.tip15RB.Location = new System.Drawing.Point(7, 66);
            this.tip15RB.Name = "tip15RB";
            this.tip15RB.Size = new System.Drawing.Size(63, 17);
            this.tip15RB.TabIndex = 4;
            this.tip15RB.Text = "15% Tip";
            this.tip15RB.UseVisualStyleBackColor = true;
            this.tip15RB.CheckedChanged += new System.EventHandler(this.tip15RB_CheckedChanged);
            // 
            // tip20RB
            // 
            this.tip20RB.AutoSize = true;
            this.tip20RB.Location = new System.Drawing.Point(7, 89);
            this.tip20RB.Name = "tip20RB";
            this.tip20RB.Size = new System.Drawing.Size(63, 17);
            this.tip20RB.TabIndex = 3;
            this.tip20RB.Text = "20% Tip";
            this.tip20RB.UseVisualStyleBackColor = true;
            this.tip20RB.CheckedChanged += new System.EventHandler(this.tip20RB_CheckedChanged);
            // 
            // tip10RB
            // 
            this.tip10RB.AutoSize = true;
            this.tip10RB.Location = new System.Drawing.Point(7, 43);
            this.tip10RB.Name = "tip10RB";
            this.tip10RB.Size = new System.Drawing.Size(63, 17);
            this.tip10RB.TabIndex = 1;
            this.tip10RB.Text = "10% Tip";
            this.tip10RB.UseVisualStyleBackColor = true;
            this.tip10RB.CheckedChanged += new System.EventHandler(this.tip10RB_CheckedChanged);
            // 
            // tip5RB
            // 
            this.tip5RB.AutoSize = true;
            this.tip5RB.Location = new System.Drawing.Point(7, 20);
            this.tip5RB.Name = "tip5RB";
            this.tip5RB.Size = new System.Drawing.Size(57, 17);
            this.tip5RB.TabIndex = 0;
            this.tip5RB.Text = "5% Tip";
            this.tip5RB.UseVisualStyleBackColor = true;
            this.tip5RB.CheckedChanged += new System.EventHandler(this.tip5RB_CheckedChanged);
            // 
            // totalTipTxt
            // 
            this.totalTipTxt.Location = new System.Drawing.Point(97, 294);
            this.totalTipTxt.Name = "totalTipTxt";
            this.totalTipTxt.ReadOnly = true;
            this.totalTipTxt.Size = new System.Drawing.Size(100, 20);
            this.totalTipTxt.TabIndex = 4;
            // 
            // totalTipLabel
            // 
            this.totalTipLabel.AutoSize = true;
            this.totalTipLabel.Location = new System.Drawing.Point(22, 301);
            this.totalTipLabel.Name = "totalTipLabel";
            this.totalTipLabel.Size = new System.Drawing.Size(52, 13);
            this.totalTipLabel.TabIndex = 3;
            this.totalTipLabel.Text = "Total Tip:";
            // 
            // grandTotalTxt
            // 
            this.grandTotalTxt.Location = new System.Drawing.Point(97, 335);
            this.grandTotalTxt.Name = "grandTotalTxt";
            this.grandTotalTxt.ReadOnly = true;
            this.grandTotalTxt.Size = new System.Drawing.Size(100, 20);
            this.grandTotalTxt.TabIndex = 6;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(22, 338);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(69, 13);
            this.grandTotalLabel.TabIndex = 5;
            this.grandTotalLabel.Text = "Grand Total: ";
            // 
            // splitCheckCB
            // 
            this.splitCheckCB.AutoSize = true;
            this.splitCheckCB.Location = new System.Drawing.Point(253, 15);
            this.splitCheckCB.Name = "splitCheckCB";
            this.splitCheckCB.Size = new System.Drawing.Size(80, 17);
            this.splitCheckCB.TabIndex = 7;
            this.splitCheckCB.Text = "Split Check";
            this.splitCheckCB.UseVisualStyleBackColor = true;
            this.splitCheckCB.CheckedChanged += new System.EventHandler(this.splitCheckCB_CheckedChanged);
            // 
            // customTipGB
            // 
            this.customTipGB.Controls.Add(this.calculateCustomBtn);
            this.customTipGB.Controls.Add(this.customTipTxt);
            this.customTipGB.Controls.Add(this.label1);
            this.customTipGB.Controls.Add(this.percentCB);
            this.customTipGB.Location = new System.Drawing.Point(253, 123);
            this.customTipGB.Name = "customTipGB";
            this.customTipGB.Size = new System.Drawing.Size(200, 106);
            this.customTipGB.TabIndex = 8;
            this.customTipGB.TabStop = false;
            this.customTipGB.Text = "Select Custom Tip";
            // 
            // calculateCustomBtn
            // 
            this.calculateCustomBtn.Location = new System.Drawing.Point(58, 66);
            this.calculateCustomBtn.Name = "calculateCustomBtn";
            this.calculateCustomBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateCustomBtn.TabIndex = 3;
            this.calculateCustomBtn.Text = "Calculate";
            this.calculateCustomBtn.UseVisualStyleBackColor = true;
            this.calculateCustomBtn.Click += new System.EventHandler(this.calculateCustomBtn_Click);
            // 
            // customTipTxt
            // 
            this.customTipTxt.Location = new System.Drawing.Point(58, 37);
            this.customTipTxt.Name = "customTipTxt";
            this.customTipTxt.Size = new System.Drawing.Size(100, 20);
            this.customTipTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip: ";
            // 
            // percentCB
            // 
            this.percentCB.AutoSize = true;
            this.percentCB.Location = new System.Drawing.Point(7, 20);
            this.percentCB.Name = "percentCB";
            this.percentCB.Size = new System.Drawing.Size(63, 17);
            this.percentCB.TabIndex = 0;
            this.percentCB.Text = "Percent";
            this.percentCB.UseVisualStyleBackColor = true;
            this.percentCB.CheckedChanged += new System.EventHandler(this.percentCB_CheckedChanged);
            // 
            // splitCheckGB
            // 
            this.splitCheckGB.Controls.Add(this.splitEquallyCB);
            this.splitCheckGB.Controls.Add(this.eachPartyPaysTxt);
            this.splitCheckGB.Controls.Add(this.numOfPartyLabel);
            this.splitCheckGB.Controls.Add(this.numOfPartyComboB);
            this.splitCheckGB.Controls.Add(this.partyPaysLabel);
            this.splitCheckGB.Location = new System.Drawing.Point(253, 235);
            this.splitCheckGB.Name = "splitCheckGB";
            this.splitCheckGB.Size = new System.Drawing.Size(200, 133);
            this.splitCheckGB.TabIndex = 9;
            this.splitCheckGB.TabStop = false;
            this.splitCheckGB.Text = "Split Check";
            // 
            // splitEquallyCB
            // 
            this.splitEquallyCB.AutoSize = true;
            this.splitEquallyCB.Checked = true;
            this.splitEquallyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splitEquallyCB.Location = new System.Drawing.Point(13, 19);
            this.splitEquallyCB.Name = "splitEquallyCB";
            this.splitEquallyCB.Size = new System.Drawing.Size(83, 17);
            this.splitEquallyCB.TabIndex = 2;
            this.splitEquallyCB.Text = "Split Equally";
            this.splitEquallyCB.UseVisualStyleBackColor = true;
            this.splitEquallyCB.CheckedChanged += new System.EventHandler(this.splitEquallyCB_CheckedChanged);
            // 
            // numOfPartyLabel
            // 
            this.numOfPartyLabel.AutoSize = true;
            this.numOfPartyLabel.Location = new System.Drawing.Point(10, 40);
            this.numOfPartyLabel.Name = "numOfPartyLabel";
            this.numOfPartyLabel.Size = new System.Drawing.Size(165, 13);
            this.numOfPartyLabel.TabIndex = 1;
            this.numOfPartyLabel.Text = "Select Number of Paying Parties: ";
            // 
            // numOfPartyComboB
            // 
            this.numOfPartyComboB.CausesValidation = false;
            this.numOfPartyComboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfPartyComboB.FormattingEnabled = true;
            this.numOfPartyComboB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.numOfPartyComboB.Location = new System.Drawing.Point(25, 56);
            this.numOfPartyComboB.Name = "numOfPartyComboB";
            this.numOfPartyComboB.Size = new System.Drawing.Size(121, 21);
            this.numOfPartyComboB.TabIndex = 0;
            this.numOfPartyComboB.SelectedIndexChanged += new System.EventHandler(this.numOfPartyComboB_SelectedIndexChanged);
            // 
            // party5TotalTxt
            // 
            this.party5TotalTxt.Location = new System.Drawing.Point(108, 139);
            this.party5TotalTxt.Name = "party5TotalTxt";
            this.party5TotalTxt.ReadOnly = true;
            this.party5TotalTxt.Size = new System.Drawing.Size(64, 20);
            this.party5TotalTxt.TabIndex = 17;
            // 
            // party5txt
            // 
            this.party5txt.Location = new System.Drawing.Point(51, 139);
            this.party5txt.Name = "party5txt";
            this.party5txt.Size = new System.Drawing.Size(43, 20);
            this.party5txt.TabIndex = 16;
            this.party5txt.TextChanged += new System.EventHandler(this.party5txt_TextChanged);
            // 
            // Party5Label
            // 
            this.Party5Label.AutoSize = true;
            this.Party5Label.Location = new System.Drawing.Point(10, 148);
            this.Party5Label.Name = "Party5Label";
            this.Party5Label.Size = new System.Drawing.Size(43, 13);
            this.Party5Label.TabIndex = 15;
            this.Party5Label.Text = "Party 5:";
            // 
            // party4TotalTxt
            // 
            this.party4TotalTxt.Location = new System.Drawing.Point(108, 113);
            this.party4TotalTxt.Name = "party4TotalTxt";
            this.party4TotalTxt.ReadOnly = true;
            this.party4TotalTxt.Size = new System.Drawing.Size(64, 20);
            this.party4TotalTxt.TabIndex = 14;
            // 
            // party3totalTxt
            // 
            this.party3totalTxt.Location = new System.Drawing.Point(108, 87);
            this.party3totalTxt.Name = "party3totalTxt";
            this.party3totalTxt.ReadOnly = true;
            this.party3totalTxt.Size = new System.Drawing.Size(64, 20);
            this.party3totalTxt.TabIndex = 13;
            // 
            // party2totalTxt
            // 
            this.party2totalTxt.Location = new System.Drawing.Point(108, 63);
            this.party2totalTxt.Name = "party2totalTxt";
            this.party2totalTxt.ReadOnly = true;
            this.party2totalTxt.Size = new System.Drawing.Size(64, 20);
            this.party2totalTxt.TabIndex = 12;
            // 
            // party1totaltxt
            // 
            this.party1totaltxt.Location = new System.Drawing.Point(108, 36);
            this.party1totaltxt.Name = "party1totaltxt";
            this.party1totaltxt.ReadOnly = true;
            this.party1totaltxt.Size = new System.Drawing.Size(64, 20);
            this.party1totaltxt.TabIndex = 11;
            // 
            // party4txt
            // 
            this.party4txt.Location = new System.Drawing.Point(50, 113);
            this.party4txt.Name = "party4txt";
            this.party4txt.Size = new System.Drawing.Size(43, 20);
            this.party4txt.TabIndex = 10;
            this.party4txt.TextChanged += new System.EventHandler(this.party4txt_TextChanged);
            // 
            // party3txt
            // 
            this.party3txt.Location = new System.Drawing.Point(50, 89);
            this.party3txt.Name = "party3txt";
            this.party3txt.Size = new System.Drawing.Size(43, 20);
            this.party3txt.TabIndex = 9;
            this.party3txt.TextChanged += new System.EventHandler(this.party3txt_TextChanged);
            // 
            // party2txt
            // 
            this.party2txt.Location = new System.Drawing.Point(50, 63);
            this.party2txt.Name = "party2txt";
            this.party2txt.Size = new System.Drawing.Size(43, 20);
            this.party2txt.TabIndex = 8;
            this.party2txt.TextChanged += new System.EventHandler(this.party2txt_TextChanged);
            // 
            // party1txt
            // 
            this.party1txt.Location = new System.Drawing.Point(50, 36);
            this.party1txt.Name = "party1txt";
            this.party1txt.Size = new System.Drawing.Size(43, 20);
            this.party1txt.TabIndex = 7;
            this.party1txt.TextChanged += new System.EventHandler(this.party1txt_TextChanged);
            // 
            // Party4Label
            // 
            this.Party4Label.AutoSize = true;
            this.Party4Label.Location = new System.Drawing.Point(10, 120);
            this.Party4Label.Name = "Party4Label";
            this.Party4Label.Size = new System.Drawing.Size(43, 13);
            this.Party4Label.TabIndex = 6;
            this.Party4Label.Text = "Party 4:";
            // 
            // Party3Label
            // 
            this.Party3Label.AutoSize = true;
            this.Party3Label.Location = new System.Drawing.Point(10, 96);
            this.Party3Label.Name = "Party3Label";
            this.Party3Label.Size = new System.Drawing.Size(43, 13);
            this.Party3Label.TabIndex = 5;
            this.Party3Label.Text = "Party 3:";
            // 
            // Party2Label
            // 
            this.Party2Label.AutoSize = true;
            this.Party2Label.Location = new System.Drawing.Point(10, 70);
            this.Party2Label.Name = "Party2Label";
            this.Party2Label.Size = new System.Drawing.Size(43, 13);
            this.Party2Label.TabIndex = 4;
            this.Party2Label.Text = "Party 2:";
            // 
            // Party1Label
            // 
            this.Party1Label.AutoSize = true;
            this.Party1Label.Location = new System.Drawing.Point(10, 43);
            this.Party1Label.Name = "Party1Label";
            this.Party1Label.Size = new System.Drawing.Size(43, 13);
            this.Party1Label.TabIndex = 3;
            this.Party1Label.Text = "Party 1:";
            // 
            // eachPartyPaysTxt
            // 
            this.eachPartyPaysTxt.Location = new System.Drawing.Point(10, 107);
            this.eachPartyPaysTxt.Name = "eachPartyPaysTxt";
            this.eachPartyPaysTxt.ReadOnly = true;
            this.eachPartyPaysTxt.Size = new System.Drawing.Size(174, 20);
            this.eachPartyPaysTxt.TabIndex = 4;
            // 
            // partyPaysLabel
            // 
            this.partyPaysLabel.AutoSize = true;
            this.partyPaysLabel.Location = new System.Drawing.Point(10, 90);
            this.partyPaysLabel.Name = "partyPaysLabel";
            this.partyPaysLabel.Size = new System.Drawing.Size(88, 13);
            this.partyPaysLabel.TabIndex = 3;
            this.partyPaysLabel.Text = "Each Party Pays:";
            // 
            // applyDiscountCB
            // 
            this.applyDiscountCB.AutoSize = true;
            this.applyDiscountCB.Location = new System.Drawing.Point(339, 15);
            this.applyDiscountCB.Name = "applyDiscountCB";
            this.applyDiscountCB.Size = new System.Drawing.Size(97, 17);
            this.applyDiscountCB.TabIndex = 10;
            this.applyDiscountCB.Text = "Apply Discount";
            this.applyDiscountCB.UseVisualStyleBackColor = true;
            this.applyDiscountCB.CheckedChanged += new System.EventHandler(this.applyDiscountCB_CheckedChanged);
            // 
            // discountGB
            // 
            this.discountGB.Controls.Add(this.discountAmounttxt);
            this.discountGB.Controls.Add(this.discountAmountLabel);
            this.discountGB.Controls.Add(this.discountPercentCB);
            this.discountGB.Location = new System.Drawing.Point(253, 43);
            this.discountGB.Name = "discountGB";
            this.discountGB.Size = new System.Drawing.Size(200, 71);
            this.discountGB.TabIndex = 11;
            this.discountGB.TabStop = false;
            this.discountGB.Text = "Discount";
            // 
            // discountAmounttxt
            // 
            this.discountAmounttxt.Location = new System.Drawing.Point(76, 33);
            this.discountAmounttxt.Name = "discountAmounttxt";
            this.discountAmounttxt.Size = new System.Drawing.Size(100, 20);
            this.discountAmounttxt.TabIndex = 6;
            this.discountAmounttxt.TextChanged += new System.EventHandler(this.discountAmounttxt_TextChanged);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(22, 40);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(55, 13);
            this.discountAmountLabel.TabIndex = 5;
            this.discountAmountLabel.Text = "Discount: ";
            // 
            // discountPercentCB
            // 
            this.discountPercentCB.AutoSize = true;
            this.discountPercentCB.Location = new System.Drawing.Point(25, 16);
            this.discountPercentCB.Name = "discountPercentCB";
            this.discountPercentCB.Size = new System.Drawing.Size(63, 17);
            this.discountPercentCB.TabIndex = 4;
            this.discountPercentCB.Text = "Percent";
            this.discountPercentCB.UseVisualStyleBackColor = true;
            this.discountPercentCB.CheckedChanged += new System.EventHandler(this.discountPercentCB_CheckedChanged);
            // 
            // totalDiscounttxt
            // 
            this.totalDiscounttxt.Location = new System.Drawing.Point(122, 43);
            this.totalDiscounttxt.Name = "totalDiscounttxt";
            this.totalDiscounttxt.ReadOnly = true;
            this.totalDiscounttxt.Size = new System.Drawing.Size(100, 20);
            this.totalDiscounttxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calculated Discount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total: ";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(122, 75);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalTxt.TabIndex = 13;
            // 
            // partiesGB
            // 
            this.partiesGB.Controls.Add(this.totalPercentTxt);
            this.partiesGB.Controls.Add(this.totalLabel);
            this.partiesGB.Controls.Add(this.percentLabel);
            this.partiesGB.Controls.Add(this.party5TotalTxt);
            this.partiesGB.Controls.Add(this.Party1Label);
            this.partiesGB.Controls.Add(this.party5txt);
            this.partiesGB.Controls.Add(this.Party2Label);
            this.partiesGB.Controls.Add(this.Party5Label);
            this.partiesGB.Controls.Add(this.Party3Label);
            this.partiesGB.Controls.Add(this.party4TotalTxt);
            this.partiesGB.Controls.Add(this.Party4Label);
            this.partiesGB.Controls.Add(this.party3totalTxt);
            this.partiesGB.Controls.Add(this.party1txt);
            this.partiesGB.Controls.Add(this.party2totalTxt);
            this.partiesGB.Controls.Add(this.party2txt);
            this.partiesGB.Controls.Add(this.party1totaltxt);
            this.partiesGB.Controls.Add(this.party3txt);
            this.partiesGB.Controls.Add(this.party4txt);
            this.partiesGB.Location = new System.Drawing.Point(253, 385);
            this.partiesGB.Name = "partiesGB";
            this.partiesGB.Size = new System.Drawing.Size(200, 193);
            this.partiesGB.TabIndex = 14;
            this.partiesGB.TabStop = false;
            this.partiesGB.Text = "Parties";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(122, 16);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 19;
            this.totalLabel.Text = "Total";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(50, 16);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(44, 13);
            this.percentLabel.TabIndex = 18;
            this.percentLabel.Text = "Percent";
            // 
            // totalPercentTxt
            // 
            this.totalPercentTxt.Location = new System.Drawing.Point(51, 167);
            this.totalPercentTxt.Name = "totalPercentTxt";
            this.totalPercentTxt.ReadOnly = true;
            this.totalPercentTxt.Size = new System.Drawing.Size(43, 20);
            this.totalPercentTxt.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateCustomBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 628);
            this.Controls.Add(this.partiesGB);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalDiscounttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discountGB);
            this.Controls.Add(this.applyDiscountCB);
            this.Controls.Add(this.splitCheckGB);
            this.Controls.Add(this.customTipGB);
            this.Controls.Add(this.splitCheckCB);
            this.Controls.Add(this.grandTotalTxt);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.totalTipTxt);
            this.Controls.Add(this.totalTipLabel);
            this.Controls.Add(this.tipGroupBox);
            this.Controls.Add(this.totalBilltxt);
            this.Controls.Add(this.totalBillLabel);
            this.Name = "Form1";
            this.Text = "Tip & Payment Calculator";
            this.tipGroupBox.ResumeLayout(false);
            this.tipGroupBox.PerformLayout();
            this.customTipGB.ResumeLayout(false);
            this.customTipGB.PerformLayout();
            this.splitCheckGB.ResumeLayout(false);
            this.splitCheckGB.PerformLayout();
            this.discountGB.ResumeLayout(false);
            this.discountGB.PerformLayout();
            this.partiesGB.ResumeLayout(false);
            this.partiesGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.TextBox totalBilltxt;
        private System.Windows.Forms.GroupBox tipGroupBox;
        private System.Windows.Forms.RadioButton tip15RB;
        private System.Windows.Forms.RadioButton tip20RB;
        private System.Windows.Forms.RadioButton tip10RB;
        private System.Windows.Forms.RadioButton tip5RB;
        private System.Windows.Forms.TextBox totalTipTxt;
        private System.Windows.Forms.Label totalTipLabel;
        private System.Windows.Forms.TextBox grandTotalTxt;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.CheckBox splitCheckCB;
        private System.Windows.Forms.GroupBox customTipGB;
        private System.Windows.Forms.RadioButton tip25RB;
        private System.Windows.Forms.TextBox customTipTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox percentCB;
        private System.Windows.Forms.RadioButton CustomTipRB;
        private System.Windows.Forms.Button calculateCustomBtn;
        private System.Windows.Forms.GroupBox splitCheckGB;
        private System.Windows.Forms.ComboBox numOfPartyComboB;
        private System.Windows.Forms.Label numOfPartyLabel;
        private System.Windows.Forms.CheckBox splitEquallyCB;
        private System.Windows.Forms.TextBox eachPartyPaysTxt;
        private System.Windows.Forms.Label partyPaysLabel;
        private System.Windows.Forms.CheckBox applyDiscountCB;
        private System.Windows.Forms.GroupBox discountGB;
        private System.Windows.Forms.TextBox discountAmounttxt;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.CheckBox discountPercentCB;
        private System.Windows.Forms.TextBox totalDiscounttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.TextBox party5TotalTxt;
        private System.Windows.Forms.TextBox party5txt;
        private System.Windows.Forms.Label Party5Label;
        private System.Windows.Forms.TextBox party4TotalTxt;
        private System.Windows.Forms.TextBox party3totalTxt;
        private System.Windows.Forms.TextBox party2totalTxt;
        private System.Windows.Forms.TextBox party1totaltxt;
        private System.Windows.Forms.TextBox party4txt;
        private System.Windows.Forms.TextBox party3txt;
        private System.Windows.Forms.TextBox party2txt;
        private System.Windows.Forms.TextBox party1txt;
        private System.Windows.Forms.Label Party4Label;
        private System.Windows.Forms.Label Party3Label;
        private System.Windows.Forms.Label Party2Label;
        private System.Windows.Forms.Label Party1Label;
        private System.Windows.Forms.GroupBox partiesGB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TextBox totalPercentTxt;
    }
}

