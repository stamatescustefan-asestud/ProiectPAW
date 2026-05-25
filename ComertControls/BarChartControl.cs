using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComertControls
{
    public partial class BarChartControl : Control
    {
        public BarChartValue[] _data;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BarChartValue[] Data
        {
            get { return _data; }
            set
            {
                _data = value;
                Invalidate();
            }
        }

        public BarChartControl()
        {
            InitializeComponent();

            ResizeRedraw = true;

            Data = new[]
            {
            new BarChartValue("Magazin A", 30),
            new BarChartValue("Magazin B", 80),
            new BarChartValue("Magazin C", 40)
            };
        }

        public void BarChartControl_Paint(object sender, PaintEventArgs e)
        {
            if (Data == null || Data.Length == 0) return;

            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;

            var barWidth = clipRectangle.Width / Data.Length;
            var maxBarHeight = clipRectangle.Height * 0.8;
            var scalingFactor = maxBarHeight / Data.Max(x => x.Value);

            Color[] colors = { Color.SteelBlue, Color.Coral, Color.SeaGreen, Color.Goldenrod, Color.MediumPurple };
            Pen pen = new Pen(Color.Black);
            Brush textBrush = new SolidBrush(Color.Black);
            Font font = new Font("Segoe UI", 8);

            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = Data[i].Value * scalingFactor;
                Brush brush = new SolidBrush(colors[i % colors.Length]);

                float x = i * barWidth;
                float y = (float)(clipRectangle.Height - barHeight - 20);
                float w = (float)(0.8 * barWidth);
                float h = (float)barHeight;

                graphics.FillRectangle(brush, x, y, w, h);
                graphics.DrawRectangle(pen, x, y, w, h);

                graphics.DrawString(Data[i].Value.ToString("N0"), font, textBrush, x, y - 16);

                graphics.DrawString(Data[i].Label, font, textBrush, x, clipRectangle.Height - 18);
            }
        }
    }
}
