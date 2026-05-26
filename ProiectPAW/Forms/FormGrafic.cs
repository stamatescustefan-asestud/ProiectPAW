using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComertControls;

namespace ComertApp.Forms
{
    public partial class FormGrafic : Form
    {
        public BarChartControl barChartControl;
        public FormGrafic(BarChartValue[] data)
        {
            InitializeComponent();

            barChartControl = new BarChartControl();
            barChartControl.Dock = DockStyle.Fill;
            barChartControl.BackColor = Color.Black;
            barChartControl.Data = data;
            Controls.Add(barChartControl);
        }
    }
}
