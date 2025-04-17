namespace Water_Bills
{
    partial class ManageinvoicesUsercontrol
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
            InvoicesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InvoicesDataGridView
            // 
            InvoicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicesDataGridView.Location = new Point(0, 0);
            InvoicesDataGridView.Name = "InvoicesDataGridView";
            InvoicesDataGridView.RowHeadersWidth = 82;
            InvoicesDataGridView.Size = new Size(1136, 839);
            InvoicesDataGridView.TabIndex = 0;
            // 
            // ManageinvoicesUsercontrol
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InvoicesDataGridView);
            Name = "ManageinvoicesUsercontrol";
            Size = new Size(1145, 854);
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView InvoicesDataGridView;
    }
}
