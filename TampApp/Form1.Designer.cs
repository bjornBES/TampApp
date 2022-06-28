
namespace TampApp
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
            this.components = new System.ComponentModel.Container();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateTimerTick = new System.Windows.Forms.Timer(this.components);
            this.SaveNow = new System.Windows.Forms.Button();
            this.TempText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 150000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // UpdateTimerTick
            // 
            this.UpdateTimerTick.Interval = 1000;
            this.UpdateTimerTick.Tick += new System.EventHandler(this.UpdateTimerTick_Tick);
            // 
            // SaveNow
            // 
            this.SaveNow.Location = new System.Drawing.Point(350, 435);
            this.SaveNow.Name = "SaveNow";
            this.SaveNow.Size = new System.Drawing.Size(100, 23);
            this.SaveNow.TabIndex = 0;
            this.SaveNow.Text = "SaveNow";
            this.SaveNow.UseVisualStyleBackColor = true;
            this.SaveNow.Click += new System.EventHandler(this.SaveNow_Click);
            // 
            // TempText
            // 
            this.TempText.Location = new System.Drawing.Point(350, 12);
            this.TempText.Multiline = true;
            this.TempText.Name = "TempText";
            this.TempText.Size = new System.Drawing.Size(100, 74);
            this.TempText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TempText);
            this.Controls.Add(this.SaveNow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveNow;
        public System.Windows.Forms.Timer UpdateTimer;
        public System.Windows.Forms.Timer UpdateTimerTick;
        public System.Windows.Forms.TextBox TempText;
    }
}

