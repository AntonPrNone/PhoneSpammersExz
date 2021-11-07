
namespace PhoneSpammers
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
            this.Heading = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.Text_OutgoingCall = new System.Windows.Forms.Label();
            this.NumberOut = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateConnection = new System.Windows.Forms.DateTimePicker();
            this.TimeConnection = new System.Windows.Forms.MaskedTextBox();
            this.Text_IncomingCall = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DurationCall = new System.Windows.Forms.TextBox();
            this.PutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DateStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DateEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.NumberInc = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Green;
            this.Heading.Location = new System.Drawing.Point(0, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(800, 35);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "Spammer Detection";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(22, 38);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 26);
            this.OpenFileButton.TabIndex = 17;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SaveReportButton.Location = new System.Drawing.Point(687, 38);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(91, 26);
            this.SaveReportButton.TabIndex = 19;
            this.SaveReportButton.Text = "Save Report";
            this.SaveReportButton.UseVisualStyleBackColor = true;
            this.SaveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // Text_OutgoingCall
            // 
            this.Text_OutgoingCall.AutoSize = true;
            this.Text_OutgoingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_OutgoingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_OutgoingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_OutgoingCall.Location = new System.Drawing.Point(28, 131);
            this.Text_OutgoingCall.Name = "Text_OutgoingCall";
            this.Text_OutgoingCall.Size = new System.Drawing.Size(103, 18);
            this.Text_OutgoingCall.TabIndex = 20;
            this.Text_OutgoingCall.Text = "Outgoing call";
            // 
            // NumberOut
            // 
            this.NumberOut.Location = new System.Drawing.Point(31, 169);
            this.NumberOut.Mask = "+7(999) 000-000";
            this.NumberOut.Name = "NumberOut";
            this.NumberOut.Size = new System.Drawing.Size(100, 20);
            this.NumberOut.TabIndex = 21;
            this.NumberOut.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NumberOut_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(290, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date/time of connection start";
            // 
            // DateConnection
            // 
            this.DateConnection.Location = new System.Drawing.Point(293, 131);
            this.DateConnection.Name = "DateConnection";
            this.DateConnection.Size = new System.Drawing.Size(140, 20);
            this.DateConnection.TabIndex = 23;
            // 
            // TimeConnection
            // 
            this.TimeConnection.Location = new System.Drawing.Point(471, 132);
            this.TimeConnection.Mask = "00:00:00";
            this.TimeConnection.Name = "TimeConnection";
            this.TimeConnection.Size = new System.Drawing.Size(48, 20);
            this.TimeConnection.TabIndex = 24;
            this.TimeConnection.ValidatingType = typeof(System.DateTime);
            // 
            // Text_IncomingCall
            // 
            this.Text_IncomingCall.AutoSize = true;
            this.Text_IncomingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_IncomingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_IncomingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_IncomingCall.Location = new System.Drawing.Point(665, 130);
            this.Text_IncomingCall.Name = "Text_IncomingCall";
            this.Text_IncomingCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_IncomingCall.Size = new System.Drawing.Size(104, 18);
            this.Text_IncomingCall.TabIndex = 27;
            this.Text_IncomingCall.Text = "Incoming call";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(318, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Connection duration";
            // 
            // DurationCall
            // 
            this.DurationCall.Location = new System.Drawing.Point(362, 197);
            this.DurationCall.Name = "DurationCall";
            this.DurationCall.Size = new System.Drawing.Size(60, 20);
            this.DurationCall.TabIndex = 29;
            // 
            // PutButton
            // 
            this.PutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PutButton.Location = new System.Drawing.Point(356, 230);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(75, 23);
            this.PutButton.TabIndex = 30;
            this.PutButton.Text = "Put";
            this.PutButton.UseVisualStyleBackColor = true;
            this.PutButton.Click += new System.EventHandler(this.PutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Start date of the period:";
            // 
            // DateStartPeriod
            // 
            this.DateStartPeriod.Location = new System.Drawing.Point(237, 380);
            this.DateStartPeriod.Name = "DateStartPeriod";
            this.DateStartPeriod.Size = new System.Drawing.Size(140, 20);
            this.DateStartPeriod.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(468, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Period end date:";
            // 
            // DateEndPeriod
            // 
            this.DateEndPeriod.Location = new System.Drawing.Point(638, 382);
            this.DateEndPeriod.Name = "DateEndPeriod";
            this.DateEndPeriod.Size = new System.Drawing.Size(140, 20);
            this.DateEndPeriod.TabIndex = 34;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(356, 425);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(108, 27);
            this.SaveAndCloseButton.TabIndex = 35;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAndCloseButton.UseVisualStyleBackColor = false;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // NumberInc
            // 
            this.NumberInc.Location = new System.Drawing.Point(668, 169);
            this.NumberInc.Mask = "+7(999) 000-000";
            this.NumberInc.Name = "NumberInc";
            this.NumberInc.Size = new System.Drawing.Size(100, 20);
            this.NumberInc.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.NumberInc);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.DateEndPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateStartPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PutButton);
            this.Controls.Add(this.DurationCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_IncomingCall);
            this.Controls.Add(this.TimeConnection);
            this.Controls.Add(this.DateConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOut);
            this.Controls.Add(this.Text_OutgoingCall);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.Heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveReportButton;
        private System.Windows.Forms.Label Text_OutgoingCall;
        private System.Windows.Forms.MaskedTextBox NumberOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateConnection;
        private System.Windows.Forms.MaskedTextBox TimeConnection;
        private System.Windows.Forms.Label Text_IncomingCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DurationCall;
        private System.Windows.Forms.Button PutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateStartPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateEndPeriod;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.MaskedTextBox NumberInc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

