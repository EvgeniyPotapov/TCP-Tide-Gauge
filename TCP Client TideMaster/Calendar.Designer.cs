namespace TCP_Client_TideMaster
{
    partial class Calendar
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
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // mCalendar
            // 
            this.mCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mCalendar.Location = new System.Drawing.Point(1, 2);
            this.mCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.mCalendar.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.mCalendar.MaxSelectionCount = 1;
            this.mCalendar.MinDate = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.ShowTodayCircle = false;
            this.mCalendar.TabIndex = 0;
            this.mCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MCalendar_DateSelected);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(392, 208);
            this.Controls.Add(this.mCalendar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 255);
            this.Name = "Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Choose a Day";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendar;
    }
}