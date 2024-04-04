namespace WinFormsApp1
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
            btnCargaCustomers = new Button();
            lstCustomers = new ListBox();
            lblCustomers = new Label();
            SuspendLayout();
            // 
            // btnCargaCustomers
            // 
            btnCargaCustomers.Location = new Point(43, 55);
            btnCargaCustomers.Name = "btnCargaCustomers";
            btnCargaCustomers.Size = new Size(124, 44);
            btnCargaCustomers.TabIndex = 0;
            btnCargaCustomers.Text = "Cargar Customers";
            btnCargaCustomers.UseVisualStyleBackColor = true;
            btnCargaCustomers.Click += btnCargaCustomers_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(237, 93);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(231, 199);
            lstCustomers.TabIndex = 1;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Location = new Point(237, 55);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(64, 15);
            lblCustomers.TabIndex = 2;
            lblCustomers.Text = "Customers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCustomers);
            Controls.Add(lstCustomers);
            Controls.Add(btnCargaCustomers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargaCustomers;
        private ListBox lstCustomers;
        private Label lblCustomers;
    }
}
