namespace ComertApp.Forms
{
    partial class FormMagazin
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
            panelFormMagazin = new Panel();
            btnAdaugaMagazin = new Button();
            lblAdresaMagazin = new Label();
            lblNumeMagazin = new Label();
            tbAdresaMagazin = new TextBox();
            tbNumeMagazin = new TextBox();
            lblTitluMagazin = new Label();
            panelFormMagazin.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormMagazin
            // 
            panelFormMagazin.Controls.Add(btnAdaugaMagazin);
            panelFormMagazin.Controls.Add(lblAdresaMagazin);
            panelFormMagazin.Controls.Add(lblNumeMagazin);
            panelFormMagazin.Controls.Add(tbAdresaMagazin);
            panelFormMagazin.Controls.Add(tbNumeMagazin);
            panelFormMagazin.Controls.Add(lblTitluMagazin);
            panelFormMagazin.Dock = DockStyle.Fill;
            panelFormMagazin.Location = new Point(0, 0);
            panelFormMagazin.Name = "panelFormMagazin";
            panelFormMagazin.Size = new Size(800, 450);
            panelFormMagazin.TabIndex = 2;
            panelFormMagazin.Visible = false;
            // 
            // btnAdaugaMagazin
            // 
            btnAdaugaMagazin.Location = new Point(88, 216);
            btnAdaugaMagazin.Name = "btnAdaugaMagazin";
            btnAdaugaMagazin.Size = new Size(75, 23);
            btnAdaugaMagazin.TabIndex = 5;
            btnAdaugaMagazin.Text = "Adauga";
            btnAdaugaMagazin.UseVisualStyleBackColor = true;
            // 
            // lblAdresaMagazin
            // 
            lblAdresaMagazin.AutoSize = true;
            lblAdresaMagazin.Location = new Point(88, 146);
            lblAdresaMagazin.Name = "lblAdresaMagazin";
            lblAdresaMagazin.Size = new Size(91, 15);
            lblAdresaMagazin.TabIndex = 4;
            lblAdresaMagazin.Text = "Adresa Magazin";
            // 
            // lblNumeMagazin
            // 
            lblNumeMagazin.AutoSize = true;
            lblNumeMagazin.Location = new Point(88, 73);
            lblNumeMagazin.Name = "lblNumeMagazin";
            lblNumeMagazin.Size = new Size(88, 15);
            lblNumeMagazin.TabIndex = 3;
            lblNumeMagazin.Text = "Nume Magazin";
            // 
            // tbAdresaMagazin
            // 
            tbAdresaMagazin.Location = new Point(193, 143);
            tbAdresaMagazin.Name = "tbAdresaMagazin";
            tbAdresaMagazin.Size = new Size(100, 23);
            tbAdresaMagazin.TabIndex = 2;
            // 
            // tbNumeMagazin
            // 
            tbNumeMagazin.Location = new Point(193, 70);
            tbNumeMagazin.Name = "tbNumeMagazin";
            tbNumeMagazin.Size = new Size(100, 23);
            tbNumeMagazin.TabIndex = 1;
            // 
            // lblTitluMagazin
            // 
            lblTitluMagazin.AutoSize = true;
            lblTitluMagazin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitluMagazin.Location = new Point(12, 9);
            lblTitluMagazin.Name = "lblTitluMagazin";
            lblTitluMagazin.Size = new Size(155, 25);
            lblTitluMagazin.TabIndex = 0;
            lblTitluMagazin.Text = "Adauga Magazin";
            // 
            // FormMagazin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFormMagazin);
            Name = "FormMagazin";
            Text = "FormMagazin";
            panelFormMagazin.ResumeLayout(false);
            panelFormMagazin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormMagazin;
        private Button btnAdaugaMagazin;
        private Label lblAdresaMagazin;
        private Label lblNumeMagazin;
        private TextBox tbAdresaMagazin;
        private TextBox tbNumeMagazin;
        private Label lblTitluMagazin;
    }
}