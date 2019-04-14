namespace CountdownTimer
{
    partial class TimerGui
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
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.MainCounter = new System.Windows.Forms.Timer(this.components);
            this.HideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.AutoSize = true;
            this.TimerDisplay.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerDisplay.Location = new System.Drawing.Point(65, 9);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(214, 51);
            this.TimerDisplay.TabIndex = 0;
            this.TimerDisplay.Text = "00:00:00";
            this.TimerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(130, 57);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 1;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // MainCounter
            // 
            this.MainCounter.Interval = 1000;
            this.MainCounter.Tick += new System.EventHandler(this.MainCounter_Tick);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(254, 57);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 2;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideGuiClick);
            // 
            // TimerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 87);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.TimerDisplay);
            this.Name = "TimerGui";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.TimerGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerDisplay;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Timer MainCounter;
        private System.Windows.Forms.Button HideButton;
    }
}

