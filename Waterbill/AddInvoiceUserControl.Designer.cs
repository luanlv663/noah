namespace Water_Bills
{
    partial class AddInvoiceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CustomerIDInput = new TextBox();
            label3 = new Label();
            CustomerNameInput = new TextBox();
            label4 = new Label();
            ThisMonthInput = new TextBox();
            label5 = new Label();
            LastMonthInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            NumberOfPeopleInput = new TextBox();
            button1 = new Button();
            TypeOfCustomerInput = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            resultSubtotal = new Label();
            resultEnvFee = new Label();
            resultVATFee = new Label();
            resultTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 50);
            label1.TabIndex = 0;
            label1.Text = "Add an Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(3, 90);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(177, 27);
            CustomerIDInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(210, 59);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 1;
            label3.Text = "Customer Name";
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(210, 90);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(177, 27);
            CustomerNameInput.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 133);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 1;
            label4.Text = "This month number";
            // 
            // ThisMonthInput
            // 
            ThisMonthInput.Location = new Point(3, 164);
            ThisMonthInput.Name = "ThisMonthInput";
            ThisMonthInput.Size = new Size(177, 27);
            ThisMonthInput.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(210, 133);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 1;
            label5.Text = "Last Month Number";
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(210, 164);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(177, 27);
            LastMonthInput.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 208);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 1;
            label6.Text = "Type of Customer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(210, 208);
            label7.Name = "label7";
            label7.Size = new Size(173, 28);
            label7.TabIndex = 1;
            label7.Text = "Number of people";
            // 
            // NumberOfPeopleInput
            // 
            NumberOfPeopleInput.Location = new Point(210, 239);
            NumberOfPeopleInput.Name = "NumberOfPeopleInput";
            NumberOfPeopleInput.Size = new Size(177, 27);
            NumberOfPeopleInput.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(261, 272);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TypeOfCustomerInput
            // 
            TypeOfCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfCustomerInput.FormattingEnabled = true;
            TypeOfCustomerInput.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            TypeOfCustomerInput.Location = new Point(3, 239);
            TypeOfCustomerInput.Name = "TypeOfCustomerInput";
            TypeOfCustomerInput.Size = new Size(177, 28);
            TypeOfCustomerInput.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 290);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 5;
            label8.Text = "Subtotal: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 321);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 5;
            label9.Text = "Env Fee:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 352);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 5;
            label10.Text = "VAT Fee:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 384);
            label11.Name = "label11";
            label11.Size = new Size(64, 28);
            label11.TabIndex = 5;
            label11.Text = "Total:";
            // 
            // resultSubtotal
            // 
            resultSubtotal.AutoSize = true;
            resultSubtotal.Location = new Point(81, 290);
            resultSubtotal.Name = "resultSubtotal";
            resultSubtotal.Size = new Size(0, 20);
            resultSubtotal.TabIndex = 6;
            // 
            // resultEnvFee
            // 
            resultEnvFee.AutoSize = true;
            resultEnvFee.Location = new Point(81, 321);
            resultEnvFee.Name = "resultEnvFee";
            resultEnvFee.Size = new Size(0, 20);
            resultEnvFee.TabIndex = 6;
            // 
            // resultVATFee
            // 
            resultVATFee.AutoSize = true;
            resultVATFee.Location = new Point(81, 352);
            resultVATFee.Name = "resultVATFee";
            resultVATFee.Size = new Size(0, 20);
            resultVATFee.TabIndex = 6;
            // 
            // resultTotal
            // 
            resultTotal.AutoSize = true;
            resultTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resultTotal.Location = new Point(62, 388);
            resultTotal.Name = "resultTotal";
            resultTotal.Size = new Size(0, 23);
            resultTotal.TabIndex = 6;
            // 
            // AddInvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultTotal);
            Controls.Add(resultVATFee);
            Controls.Add(resultEnvFee);
            Controls.Add(resultSubtotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TypeOfCustomerInput);
            Controls.Add(button1);
            Controls.Add(NumberOfPeopleInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LastMonthInput);
            Controls.Add(label5);
            Controls.Add(ThisMonthInput);
            Controls.Add(label4);
            Controls.Add(CustomerNameInput);
            Controls.Add(label3);
            Controls.Add(CustomerIDInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoiceUserControl";
            Size = new Size(400, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CustomerIDInput;
        private Label label3;
        private TextBox CustomerNameInput;
        private Label label4;
        private TextBox ThisMonthInput;
        private Label label5;
        private TextBox LastMonthInput;
        private Label label6;
        private Label label7;
        private TextBox NumberOfPeopleInput;
        private Button button1;
        private ComboBox TypeOfCustomerInput;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label resultSubtotal;
        private Label resultEnvFee;
        private Label resultVATFee;
        private Label resultTotal;
    }
}
