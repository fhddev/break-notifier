
namespace BreakNotifier.WinForm.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.breakTime = new System.Windows.Forms.NumericUpDown();
            this.timeBetweenBreaks = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.PlaySoundOnBreakStart = new System.Windows.Forms.CheckBox();
            this.playSoundOnBreakEnd = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEndBreak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableWhenWindowsUnlocked = new System.Windows.Forms.CheckBox();
            this.disableWhenWinLocked = new System.Windows.Forms.CheckBox();
            this.startAtLogon = new System.Windows.Forms.CheckBox();
            this.playSoundOnBreakIsAboutToEnd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.breakTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenBreaks)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Break Time (Minutes) :";
            // 
            // breakTime
            // 
            this.breakTime.Location = new System.Drawing.Point(215, 163);
            this.breakTime.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.breakTime.Name = "breakTime";
            this.breakTime.Size = new System.Drawing.Size(176, 23);
            this.breakTime.TabIndex = 1;
            // 
            // timeBetweenBreaks
            // 
            this.timeBetweenBreaks.Location = new System.Drawing.Point(215, 192);
            this.timeBetweenBreaks.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.timeBetweenBreaks.Name = "timeBetweenBreaks";
            this.timeBetweenBreaks.Size = new System.Drawing.Size(176, 23);
            this.timeBetweenBreaks.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time between breaks (Minutes) :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(308, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PlaySoundOnBreakStart
            // 
            this.PlaySoundOnBreakStart.AutoSize = true;
            this.PlaySoundOnBreakStart.Location = new System.Drawing.Point(15, 20);
            this.PlaySoundOnBreakStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaySoundOnBreakStart.Name = "PlaySoundOnBreakStart";
            this.PlaySoundOnBreakStart.Size = new System.Drawing.Size(174, 19);
            this.PlaySoundOnBreakStart.TabIndex = 12;
            this.PlaySoundOnBreakStart.Text = "Play sound when break start";
            this.PlaySoundOnBreakStart.UseVisualStyleBackColor = true;
            // 
            // playSoundOnBreakEnd
            // 
            this.playSoundOnBreakEnd.AutoSize = true;
            this.playSoundOnBreakEnd.Location = new System.Drawing.Point(15, 65);
            this.playSoundOnBreakEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playSoundOnBreakEnd.Name = "playSoundOnBreakEnd";
            this.playSoundOnBreakEnd.Size = new System.Drawing.Size(171, 19);
            this.playSoundOnBreakEnd.TabIndex = 14;
            this.playSoundOnBreakEnd.Text = "Play sound when break end";
            this.playSoundOnBreakEnd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnEndBreak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 59);
            this.panel1.TabIndex = 15;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnEndBreak
            // 
            this.btnEndBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.btnEndBreak.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEndBreak.ForeColor = System.Drawing.Color.White;
            this.btnEndBreak.Location = new System.Drawing.Point(371, 12);
            this.btnEndBreak.Name = "btnEndBreak";
            this.btnEndBreak.Size = new System.Drawing.Size(41, 37);
            this.btnEndBreak.TabIndex = 3;
            this.btnEndBreak.Text = "X";
            this.btnEndBreak.UseVisualStyleBackColor = false;
            this.btnEndBreak.Click += new System.EventHandler(this.btnEndBreak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Break Notifier";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableWhenWindowsUnlocked);
            this.groupBox1.Controls.Add(this.disableWhenWinLocked);
            this.groupBox1.Controls.Add(this.startAtLogon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.breakTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timeBetweenBreaks);
            this.groupBox1.Controls.Add(this.playSoundOnBreakEnd);
            this.groupBox1.Controls.Add(this.playSoundOnBreakIsAboutToEnd);
            this.groupBox1.Controls.Add(this.PlaySoundOnBreakStart);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(7, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 227);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // enableWhenWindowsUnlocked
            // 
            this.enableWhenWindowsUnlocked.AutoSize = true;
            this.enableWhenWindowsUnlocked.Location = new System.Drawing.Point(15, 133);
            this.enableWhenWindowsUnlocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableWhenWindowsUnlocked.Name = "enableWhenWindowsUnlocked";
            this.enableWhenWindowsUnlocked.Size = new System.Drawing.Size(195, 19);
            this.enableWhenWindowsUnlocked.TabIndex = 17;
            this.enableWhenWindowsUnlocked.Text = "Enable when windows unlocked";
            this.enableWhenWindowsUnlocked.UseVisualStyleBackColor = true;
            // 
            // disableWhenWinLocked
            // 
            this.disableWhenWinLocked.AutoSize = true;
            this.disableWhenWinLocked.Location = new System.Drawing.Point(15, 110);
            this.disableWhenWinLocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disableWhenWinLocked.Name = "disableWhenWinLocked";
            this.disableWhenWinLocked.Size = new System.Drawing.Size(184, 19);
            this.disableWhenWinLocked.TabIndex = 16;
            this.disableWhenWinLocked.Text = "Disable when windows locked";
            this.disableWhenWinLocked.UseVisualStyleBackColor = true;
            // 
            // startAtLogon
            // 
            this.startAtLogon.AutoSize = true;
            this.startAtLogon.Location = new System.Drawing.Point(15, 87);
            this.startAtLogon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startAtLogon.Name = "startAtLogon";
            this.startAtLogon.Size = new System.Drawing.Size(97, 19);
            this.startAtLogon.TabIndex = 15;
            this.startAtLogon.Text = "Start at logon";
            this.startAtLogon.UseVisualStyleBackColor = true;
            // 
            // playSoundOnBreakIsAboutToEnd
            // 
            this.playSoundOnBreakIsAboutToEnd.AutoSize = true;
            this.playSoundOnBreakIsAboutToEnd.Location = new System.Drawing.Point(15, 43);
            this.playSoundOnBreakIsAboutToEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playSoundOnBreakIsAboutToEnd.Name = "playSoundOnBreakIsAboutToEnd";
            this.playSoundOnBreakIsAboutToEnd.Size = new System.Drawing.Size(230, 19);
            this.playSoundOnBreakIsAboutToEnd.TabIndex = 13;
            this.playSoundOnBreakIsAboutToEnd.Text = "Play sound when break is about to end";
            this.playSoundOnBreakIsAboutToEnd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(131, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preferences";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.breakTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetweenBreaks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown breakTime;
        private System.Windows.Forms.NumericUpDown timeBetweenBreaks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox PlaySoundOnBreakStart;
        private System.Windows.Forms.CheckBox playSoundOnBreakEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox startAtLogon;
        private System.Windows.Forms.Button btnEndBreak;
        private System.Windows.Forms.CheckBox enableWhenWindowsUnlocked;
        private System.Windows.Forms.CheckBox disableWhenWinLocked;
        private System.Windows.Forms.CheckBox playSoundOnBreakIsAboutToEnd;
        private System.Windows.Forms.Label label4;
    }
}