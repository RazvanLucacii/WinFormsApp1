namespace WinFormsApp1
{
    partial class Form2
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
            btnCargarAirports = new Button();
            lblAirports = new Label();
            lsbAirports = new ListBox();
            SuspendLayout();
            // 
            // btnCargarAirports
            // 
            btnCargarAirports.Location = new Point(62, 42);
            btnCargarAirports.Name = "btnCargarAirports";
            btnCargarAirports.Size = new Size(116, 53);
            btnCargarAirports.TabIndex = 0;
            btnCargarAirports.Text = "Cargar Airports";
            btnCargarAirports.UseVisualStyleBackColor = true;
            btnCargarAirports.Click += btnCargarAirports_Click;
            // 
            // lblAirports
            // 
            lblAirports.AutoSize = true;
            lblAirports.Location = new Point(225, 56);
            lblAirports.Name = "lblAirports";
            lblAirports.Size = new Size(49, 15);
            lblAirports.TabIndex = 1;
            lblAirports.Text = "Airports";
            // 
            // lsbAirports
            // 
            lsbAirports.FormattingEnabled = true;
            lsbAirports.ItemHeight = 15;
            lsbAirports.Location = new Point(225, 86);
            lsbAirports.Name = "lsbAirports";
            lsbAirports.Size = new Size(563, 259);
            lsbAirports.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbAirports);
            Controls.Add(lblAirports);
            Controls.Add(btnCargarAirports);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarAirports;
        private Label lblAirports;
        private ListBox lsbAirports;
    }
}