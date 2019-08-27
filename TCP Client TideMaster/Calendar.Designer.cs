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
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mCalendar
            // 
            this.mCalendar.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.mCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mCalendar.Location = new System.Drawing.Point(1, 1);
            this.mCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.mCalendar.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.mCalendar.MaxSelectionCount = 1;
            this.mCalendar.MinDate = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.ShowTodayCircle = false;
            this.mCalendar.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(434, 285);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(502, 314);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mCalendar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 353);
            this.Name = "Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Choose a Day";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calendar_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.Button btnOK;
    }
}