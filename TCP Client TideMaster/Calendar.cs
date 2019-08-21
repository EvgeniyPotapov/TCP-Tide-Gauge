using System;
using System.Windows.Forms;

namespace TCP_Client_TideMaster
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }
        string _datachoosed;
        public string DataChoosed { get { return _datachoosed; } }
        
        public void BDates(DateTime[] BoldedDates)
        {
            mCalendar.BoldedDates = BoldedDates;
        }


        private void MCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string[] temp = mCalendar.SelectionRange.Start.ToString("s").Split('T');
            _datachoosed = temp[0];
            DialogResult = DialogResult.OK;
        }
    }
}
