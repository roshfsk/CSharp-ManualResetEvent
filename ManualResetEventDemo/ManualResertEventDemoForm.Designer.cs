namespace ManualResetEventDemo
{
    partial class ManualResertEventDemoForm
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
            this.btnWithSleepStart = new System.Windows.Forms.Button();
            this.btnWithSleepStop = new System.Windows.Forms.Button();
            this.btnWithManualResetEventStart = new System.Windows.Forms.Button();
            this.btnWithManualResetEventStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithSleepStart
            // 
            this.btnWithSleepStart.Location = new System.Drawing.Point(122, 13);
            this.btnWithSleepStart.Name = "btnWithSleepStart";
            this.btnWithSleepStart.Size = new System.Drawing.Size(75, 23);
            this.btnWithSleepStart.TabIndex = 0;
            this.btnWithSleepStart.Text = "Start";
            this.btnWithSleepStart.UseVisualStyleBackColor = true;
            this.btnWithSleepStart.Click += new System.EventHandler(this.btnWithSleepStart_Click);
            // 
            // btnWithSleepStop
            // 
            this.btnWithSleepStop.Location = new System.Drawing.Point(203, 13);
            this.btnWithSleepStop.Name = "btnWithSleepStop";
            this.btnWithSleepStop.Size = new System.Drawing.Size(75, 23);
            this.btnWithSleepStop.TabIndex = 1;
            this.btnWithSleepStop.Text = "Stop";
            this.btnWithSleepStop.UseVisualStyleBackColor = true;
            this.btnWithSleepStop.Click += new System.EventHandler(this.btnWithSleepStop_Click);
            // 
            // btnWithManualResetEventStart
            // 
            this.btnWithManualResetEventStart.Location = new System.Drawing.Point(122, 42);
            this.btnWithManualResetEventStart.Name = "btnWithManualResetEventStart";
            this.btnWithManualResetEventStart.Size = new System.Drawing.Size(75, 23);
            this.btnWithManualResetEventStart.TabIndex = 2;
            this.btnWithManualResetEventStart.Text = "Start";
            this.btnWithManualResetEventStart.UseVisualStyleBackColor = true;
            this.btnWithManualResetEventStart.Click += new System.EventHandler(this.btnWithManualResetEventStart_Click);
            // 
            // btnWithManualResetEventStop
            // 
            this.btnWithManualResetEventStop.Location = new System.Drawing.Point(203, 42);
            this.btnWithManualResetEventStop.Name = "btnWithManualResetEventStop";
            this.btnWithManualResetEventStop.Size = new System.Drawing.Size(75, 23);
            this.btnWithManualResetEventStop.TabIndex = 3;
            this.btnWithManualResetEventStop.Text = "Stop";
            this.btnWithManualResetEventStop.UseVisualStyleBackColor = true;
            this.btnWithManualResetEventStop.Click += new System.EventHandler(this.btnWithManualResetEventStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thread.Sleep()";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ManualResetEvent";
            // 
            // ManualResertEventDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 77);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithManualResetEventStop);
            this.Controls.Add(this.btnWithManualResetEventStart);
            this.Controls.Add(this.btnWithSleepStop);
            this.Controls.Add(this.btnWithSleepStart);
            this.Name = "ManualResertEventDemoForm";
            this.Text = "Comparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithSleepStart;
        private System.Windows.Forms.Button btnWithSleepStop;
        private System.Windows.Forms.Button btnWithManualResetEventStart;
        private System.Windows.Forms.Button btnWithManualResetEventStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

