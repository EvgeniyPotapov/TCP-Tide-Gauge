using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client_TideMaster
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            mCalendar.DateChanged += mCalendar_DateChanged;
        }

        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(mCalendar.SelectionRange.Start.ToShortDateString());
        }
    }
}
