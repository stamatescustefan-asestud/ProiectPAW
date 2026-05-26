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
    public partial class StatusBarControl : UserControl
    {
        public StatusBarControl()
        {
            InitializeComponent();
        }

        public void Refresh(int totalMagazine, int totalRaioane, int totalDesfaceri)
        {
            lblMagazineVal.Text = totalMagazine.ToString();
            lblRaioaneVal.Text = totalRaioane.ToString();
            lblDesfaceriVal.Text = totalDesfaceri.ToString();
        }
    }
}
