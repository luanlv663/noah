namespace Water_Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddInvoiceMenuButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ExitButton = new Button();
            ManageInvoicesMenuButton = new Button();
            addInvoiceUserControl = new AddInvoiceUserControl();
            manageinvoicesUsercontrol = new ManageinvoicesUsercontrol();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Location = new Point(-2, 155);
            AddInvoiceMenuButton.Margin = new Padding(5);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(294, 82);
            AddInvoiceMenuButton.TabIndex = 0;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoiceMenuButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ManageInvoicesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 937);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(5, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 146);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Location = new Point(0, 854);
            ExitButton.Margin = new Padding(5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(294, 82);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ManageInvoicesMenuButton
            // 
            ManageInvoicesMenuButton.Location = new Point(0, 246);
            ManageInvoicesMenuButton.Margin = new Padding(5);
            ManageInvoicesMenuButton.Name = "ManageInvoicesMenuButton";
            ManageInvoicesMenuButton.Size = new Size(294, 82);
            ManageInvoicesMenuButton.TabIndex = 0;
            ManageInvoicesMenuButton.Text = "Manage Invoices";
            ManageInvoicesMenuButton.UseVisualStyleBackColor = true;
            ManageInvoicesMenuButton.Click += ManageInvoicesMenuButton_Click;
            // 
            // addInvoiceUserControl
            // 
            addInvoiceUserControl.Location = new Point(315, 5);
            addInvoiceUserControl.Margin = new Padding(8);
            addInvoiceUserControl.Name = "addInvoiceUserControl";
            addInvoiceUserControl.Size = new Size(1183, 936);
            addInvoiceUserControl.TabIndex = 1;
            // 
            // manageinvoicesUsercontrol
            // 
            manageinvoicesUsercontrol.Location = new Point(315, 2);
            manageinvoicesUsercontrol.Name = "manageinvoicesUsercontrol";
            manageinvoicesUsercontrol.Size = new Size(1155, 909);
            manageinvoicesUsercontrol.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1497, 944);
            Controls.Add(manageinvoicesUsercontrol);
            Controls.Add(addInvoiceUserControl);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wassco Water Bills";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddInvoiceMenuButton;
        private Panel panel1;
        private Button ManageInvoicesMenuButton;
        private PictureBox pictureBox1;
        private Button ExitButton;
        private AddInvoiceUserControl addInvoiceUserControl;
        private ManageinvoicesUsercontrol manageinvoicesUsercontrol;
    }
}
