namespace P5_2_1204007_TestClock
{
    partial class Form1
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
            this.digitalClock1 = new P5_2_1204007.DigitalClock();
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.LocalTimeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digitalClock1
            // 
            this.digitalClock1.LocalTimerLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalClock1.Location = new System.Drawing.Point(94, 37);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(178, 81);
            this.digitalClock1.TabIndex = 0;
            this.digitalClock1.Timer1_Enabled = true;
            this.digitalClock1.RaiseTimer1_Tick += new System.EventHandler(this.digitalClock1_RaiseTimer1_Tick);
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.AutoSize = true;
            this.UniversalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversalTimeLabel.Location = new System.Drawing.Point(12, 138);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(91, 13);
            this.UniversalTimeLabel.TabIndex = 1;
            this.UniversalTimeLabel.Text = "Universal Time";
            // 
            // LocalTimeLabel
            // 
            this.LocalTimeLabel.AutoSize = true;
            this.LocalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalTimeLabel.Location = new System.Drawing.Point(15, 82);
            this.LocalTimeLabel.Name = "LocalTimeLabel";
            this.LocalTimeLabel.Size = new System.Drawing.Size(69, 13);
            this.LocalTimeLabel.TabIndex = 2;
            this.LocalTimeLabel.Text = "Local Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Star/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LocalTimeLabel);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.digitalClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private P5_2_1204007.DigitalClock digitalClock1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Label LocalTimeLabel;
        private System.Windows.Forms.Button button1;
    }
}

