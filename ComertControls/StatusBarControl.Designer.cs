namespace ComertControls
{
    partial class StatusBarControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMagazineTitle = new Label();
            lblRaioaneTitle = new Label();
            lblDesfaceriTitle = new Label();
            lblMagazineVal = new Label();
            lblRaioaneVal = new Label();
            lblDesfaceriVal = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lblMagazineTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblRaioaneTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDesfaceriTitle, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMagazineVal, 0, 1);
            tableLayoutPanel1.Controls.Add(lblRaioaneVal, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDesfaceriVal, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(500, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMagazineTitle
            // 
            lblMagazineTitle.AutoSize = true;
            lblMagazineTitle.Dock = DockStyle.Fill;
            lblMagazineTitle.Location = new Point(3, 0);
            lblMagazineTitle.Name = "lblMagazineTitle";
            lblMagazineTitle.Size = new Size(160, 30);
            lblMagazineTitle.TabIndex = 0;
            lblMagazineTitle.Text = "Magazine";
            lblMagazineTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRaioaneTitle
            // 
            lblRaioaneTitle.AutoSize = true;
            lblRaioaneTitle.Dock = DockStyle.Fill;
            lblRaioaneTitle.Location = new Point(169, 0);
            lblRaioaneTitle.Name = "lblRaioaneTitle";
            lblRaioaneTitle.Size = new Size(160, 30);
            lblRaioaneTitle.TabIndex = 1;
            lblRaioaneTitle.Text = "Raioane";
            lblRaioaneTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesfaceriTitle
            // 
            lblDesfaceriTitle.AutoSize = true;
            lblDesfaceriTitle.Dock = DockStyle.Fill;
            lblDesfaceriTitle.Location = new Point(335, 0);
            lblDesfaceriTitle.Name = "lblDesfaceriTitle";
            lblDesfaceriTitle.Size = new Size(162, 30);
            lblDesfaceriTitle.TabIndex = 2;
            lblDesfaceriTitle.Text = "Desfaceri";
            lblDesfaceriTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMagazineVal
            // 
            lblMagazineVal.AutoSize = true;
            lblMagazineVal.Dock = DockStyle.Fill;
            lblMagazineVal.Location = new Point(3, 30);
            lblMagazineVal.Name = "lblMagazineVal";
            lblMagazineVal.Size = new Size(160, 30);
            lblMagazineVal.TabIndex = 3;
            lblMagazineVal.Text = "0";
            lblMagazineVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRaioaneVal
            // 
            lblRaioaneVal.AutoSize = true;
            lblRaioaneVal.Dock = DockStyle.Fill;
            lblRaioaneVal.Location = new Point(169, 30);
            lblRaioaneVal.Name = "lblRaioaneVal";
            lblRaioaneVal.Size = new Size(160, 30);
            lblRaioaneVal.TabIndex = 4;
            lblRaioaneVal.Text = "0";
            lblRaioaneVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesfaceriVal
            // 
            lblDesfaceriVal.AutoSize = true;
            lblDesfaceriVal.Dock = DockStyle.Fill;
            lblDesfaceriVal.Location = new Point(335, 30);
            lblDesfaceriVal.Name = "lblDesfaceriVal";
            lblDesfaceriVal.Size = new Size(162, 30);
            lblDesfaceriVal.TabIndex = 5;
            lblDesfaceriVal.Text = "0";
            lblDesfaceriVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "StatusBarControl";
            Size = new Size(500, 60);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMagazineTitle;
        private Label lblRaioaneTitle;
        private Label lblDesfaceriTitle;
        private Label lblMagazineVal;
        private Label lblRaioaneVal;
        private Label lblDesfaceriVal;
    }
}
