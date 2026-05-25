namespace ComertApp.Forms
{
    partial class FormGrafic
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
            barChartControl1 = new ComertControls.BarChartControl();
            SuspendLayout();
            // 
            // barChartControl1
            // 
            barChartControl1.Location = new Point(1, -1);
            barChartControl1.Name = "barChartControl1";
            barChartControl1.Size = new Size(800, 450);
            barChartControl1.TabIndex = 0;
            barChartControl1.Text = "barChartControl1";
            // 
            // FormGrafic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(barChartControl1);
            Name = "FormGrafic";
            Text = "FormGrafic";
            ResumeLayout(false);
        }

        #endregion

        private ComertControls.BarChartControl barChartControl1;
    }
}