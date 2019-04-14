namespace CountdownTimer
{
    partial class TimerLauncher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.NoActionRadbut = new System.Windows.Forms.RadioButton();
            this.HibernationRadbut = new System.Windows.Forms.RadioButton();
            this.ShutdownRadbut = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.HoursBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinutesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SecondsBox = new System.Windows.Forms.TextBox();
            this.SignalBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WarningBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.WarningTimeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HiddenLaunchBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShutdownRadbut);
            this.panel1.Controls.Add(this.HibernationRadbut);
            this.panel1.Controls.Add(this.NoActionRadbut);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 98);
            this.panel1.TabIndex = 0;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(12, 10);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(40, 13);
            this.ActionLabel.TabIndex = 0;
            this.ActionLabel.Text = "Action:";
            // 
            // NoActionRadbut
            // 
            this.NoActionRadbut.AutoSize = true;
            this.NoActionRadbut.Checked = true;
            this.NoActionRadbut.Location = new System.Drawing.Point(6, 6);
            this.NoActionRadbut.Name = "NoActionRadbut";
            this.NoActionRadbut.Size = new System.Drawing.Size(51, 17);
            this.NoActionRadbut.TabIndex = 0;
            this.NoActionRadbut.TabStop = true;
            this.NoActionRadbut.Text = "None";
            this.NoActionRadbut.UseVisualStyleBackColor = true;
            // 
            // HibernationRadbut
            // 
            this.HibernationRadbut.AutoSize = true;
            this.HibernationRadbut.Location = new System.Drawing.Point(6, 29);
            this.HibernationRadbut.Name = "HibernationRadbut";
            this.HibernationRadbut.Size = new System.Drawing.Size(79, 17);
            this.HibernationRadbut.TabIndex = 1;
            this.HibernationRadbut.Text = "Hibernation";
            this.HibernationRadbut.UseVisualStyleBackColor = true;
            // 
            // ShutdownRadbut
            // 
            this.ShutdownRadbut.AutoSize = true;
            this.ShutdownRadbut.Location = new System.Drawing.Point(6, 52);
            this.ShutdownRadbut.Name = "ShutdownRadbut";
            this.ShutdownRadbut.Size = new System.Drawing.Size(76, 17);
            this.ShutdownRadbut.TabIndex = 2;
            this.ShutdownRadbut.Text = "Shut down";
            this.ShutdownRadbut.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preset:";
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Location = new System.Drawing.Point(328, 307);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(75, 21);
            this.LoadPresetButton.TabIndex = 3;
            this.LoadPresetButton.Text = "Load preset";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(410, 278);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 4;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(7, 21);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(95, 20);
            this.HoursBox.TabIndex = 5;
            this.HoursBox.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HiddenLaunchBox);
            this.panel2.Controls.Add(this.SignalBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SecondsBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MinutesBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.HoursBox);
            this.panel2.Location = new System.Drawing.Point(119, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 97);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parameters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration. Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "minutes";
            // 
            // MinutesBox
            // 
            this.MinutesBox.Location = new System.Drawing.Point(108, 21);
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(95, 20);
            this.MinutesBox.TabIndex = 7;
            this.MinutesBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "seconds";
            // 
            // SecondsBox
            // 
            this.SecondsBox.Location = new System.Drawing.Point(209, 21);
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(95, 20);
            this.SecondsBox.TabIndex = 9;
            this.SecondsBox.Text = "0";
            // 
            // SignalBox
            // 
            this.SignalBox.AutoSize = true;
            this.SignalBox.Location = new System.Drawing.Point(7, 52);
            this.SignalBox.Name = "SignalBox";
            this.SignalBox.Size = new System.Drawing.Size(87, 17);
            this.SignalBox.TabIndex = 11;
            this.SignalBox.Text = "Sound signal";
            this.SignalBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save preset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WarningBox
            // 
            this.WarningBox.AutoSize = true;
            this.WarningBox.Location = new System.Drawing.Point(9, 13);
            this.WarningBox.Name = "WarningBox";
            this.WarningBox.Size = new System.Drawing.Size(66, 17);
            this.WarningBox.TabIndex = 12;
            this.WarningBox.Text = "Warning";
            this.WarningBox.UseVisualStyleBackColor = true;
            this.WarningBox.CheckedChanged += new System.EventHandler(this.WarningBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.WarningTimeBox);
            this.panel3.Controls.Add(this.WarningBox);
            this.panel3.Location = new System.Drawing.Point(12, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 98);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Warning:";
            // 
            // WarningTimeBox
            // 
            this.WarningTimeBox.Enabled = false;
            this.WarningTimeBox.Location = new System.Drawing.Point(6, 57);
            this.WarningTimeBox.Name = "WarningTimeBox";
            this.WarningTimeBox.Size = new System.Drawing.Size(82, 20);
            this.WarningTimeBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time to end (sec):";
            // 
            // HiddenLaunchBox
            // 
            this.HiddenLaunchBox.AutoSize = true;
            this.HiddenLaunchBox.Location = new System.Drawing.Point(108, 52);
            this.HiddenLaunchBox.Name = "HiddenLaunchBox";
            this.HiddenLaunchBox.Size = new System.Drawing.Size(95, 17);
            this.HiddenLaunchBox.TabIndex = 12;
            this.HiddenLaunchBox.Text = "Hidden launch";
            this.HiddenLaunchBox.UseVisualStyleBackColor = true;
            // 
            // TimerLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.LoadPresetButton);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "TimerLauncher";
            this.Text = "TimerLauncher";
            this.Load += new System.EventHandler(this.TimerLauncher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ShutdownRadbut;
        private System.Windows.Forms.RadioButton HibernationRadbut;
        private System.Windows.Forms.RadioButton NoActionRadbut;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadPresetButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox SignalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SecondsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinutesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox WarningBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WarningTimeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox HiddenLaunchBox;
    }
}