namespace TCP_Client_TideMaster
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIPAdress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMeasurmentTime = new System.Windows.Forms.TextBox();
            this.tbTideHeight = new System.Windows.Forms.TextBox();
            this.tbRecive = new System.Windows.Forms.TextBox();
            this.tmConnection = new System.Windows.Forms.Timer(this.components);
            this.pbConnect = new System.Windows.Forms.ProgressBar();
            this.tmProgress = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbPackagetime = new System.Windows.Forms.TextBox();
            this.chbSilentMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Port";
            // 
            // tbIPAdress
            // 
            this.tbIPAdress.Location = new System.Drawing.Point(126, 28);
            this.tbIPAdress.Name = "tbIPAdress";
            this.tbIPAdress.ReadOnly = true;
            this.tbIPAdress.Size = new System.Drawing.Size(134, 22);
            this.tbIPAdress.TabIndex = 2;
            this.tbIPAdress.Text = "109.188.128.115";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(126, 59);
            this.tbPort.Name = "tbPort";
            this.tbPort.ReadOnly = true;
            this.tbPort.Size = new System.Drawing.Size(64, 22);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "2291";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(217, 59);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Measurement time (UTC)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tide Height";
            // 
            // tbMeasurmentTime
            // 
            this.tbMeasurmentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeasurmentTime.Location = new System.Drawing.Point(16, 114);
            this.tbMeasurmentTime.Name = "tbMeasurmentTime";
            this.tbMeasurmentTime.Size = new System.Drawing.Size(235, 22);
            this.tbMeasurmentTime.TabIndex = 7;
            // 
            // tbTideHeight
            // 
            this.tbTideHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTideHeight.Location = new System.Drawing.Point(260, 114);
            this.tbTideHeight.Name = "tbTideHeight";
            this.tbTideHeight.Size = new System.Drawing.Size(78, 22);
            this.tbTideHeight.TabIndex = 8;
            // 
            // tbRecive
            // 
            this.tbRecive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecive.Location = new System.Drawing.Point(12, 200);
            this.tbRecive.Multiline = true;
            this.tbRecive.Name = "tbRecive";
            this.tbRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecive.Size = new System.Drawing.Size(458, 246);
            this.tbRecive.TabIndex = 9;
            this.tbRecive.Text = "20.04.2019 8:40:41 $PVTM0,01,20042019,084000,-0.271,0.010,1,5.6,0*2a";
            this.tbRecive.UseWaitCursor = true;
            // 
            // tmConnection
            // 
            this.tmConnection.Interval = 120000;
            this.tmConnection.Tick += new System.EventHandler(this.Tm1_Tick);
            // 
            // pbConnect
            // 
            this.pbConnect.Location = new System.Drawing.Point(12, 187);
            this.pbConnect.Maximum = 60;
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(458, 14);
            this.pbConnect.Step = 1;
            this.pbConnect.TabIndex = 10;
            this.pbConnect.Visible = false;
            // 
            // tmProgress
            // 
            this.tmProgress.Interval = 1000;
            this.tmProgress.Tick += new System.EventHandler(this.TmProgress_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Package time (UTC)";
            // 
            // tbPackagetime
            // 
            this.tbPackagetime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPackagetime.Location = new System.Drawing.Point(16, 159);
            this.tbPackagetime.Name = "tbPackagetime";
            this.tbPackagetime.Size = new System.Drawing.Size(235, 22);
            this.tbPackagetime.TabIndex = 12;
            // 
            // chbSilentMode
            // 
            this.chbSilentMode.AutoSize = true;
            this.chbSilentMode.Checked = true;
            this.chbSilentMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSilentMode.Location = new System.Drawing.Point(260, 159);
            this.chbSilentMode.Name = "chbSilentMode";
            this.chbSilentMode.Size = new System.Drawing.Size(104, 21);
            this.chbSilentMode.TabIndex = 13;
            this.chbSilentMode.Text = "Silent mode";
            this.chbSilentMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 458);
            this.Controls.Add(this.chbSilentMode);
            this.Controls.Add(this.tbPackagetime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbConnect);
            this.Controls.Add(this.tbRecive);
            this.Controls.Add(this.tbTideHeight);
            this.Controls.Add(this.tbMeasurmentTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIPAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 505);
            this.Name = "Form1";
            this.Text = "Cofferdam Tide Gauge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIPAdress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMeasurmentTime;
        private System.Windows.Forms.TextBox tbTideHeight;
        private System.Windows.Forms.TextBox tbRecive;
        internal System.Windows.Forms.Timer tmConnection;
        private System.Windows.Forms.Timer tmProgress;
        protected System.Windows.Forms.ProgressBar pbConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPackagetime;
        private System.Windows.Forms.CheckBox chbSilentMode;
    }
}

