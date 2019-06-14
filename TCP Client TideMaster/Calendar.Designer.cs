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
            this.mCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mCalendar.Location = new System.Drawing.Point(1, 2);
            this.mCalendar.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.mCalendar.MaxSelectionCount = 2;
            this.mCalendar.MinDate = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 0;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 165);
            this.ControlBox = false;
            this.Controls.Add(this.mCalendar);
            this.Name = "Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Choose a Day";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendar;
    }
}