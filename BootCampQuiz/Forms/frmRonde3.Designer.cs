namespace BootCampQuiz.Forms
{
    partial class frmRonde3
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
            this.tlpRonde1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControlA = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamABeide = new System.Windows.Forms.Button();
            this.btnTeamAStart = new System.Windows.Forms.Button();
            this.btnTeamAHalf = new System.Windows.Forms.Button();
            this.tlpControlB = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamBBeide = new System.Windows.Forms.Button();
            this.btnTeamBHalf = new System.Windows.Forms.Button();
            this.btnTeamBStart = new System.Windows.Forms.Button();
            this.nudTeamC = new System.Windows.Forms.NumericUpDown();
            this.nudTeamB = new System.Windows.Forms.NumericUpDown();
            this.nudTeamA = new System.Windows.Forms.NumericUpDown();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lblTeamC = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.tlpGenres = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenre3 = new System.Windows.Forms.CheckBox();
            this.btnGenre2 = new System.Windows.Forms.CheckBox();
            this.btnGenre1 = new System.Windows.Forms.CheckBox();
            this.tlpControlC = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamCBeide = new System.Windows.Forms.Button();
            this.btnTeamCStart = new System.Windows.Forms.Button();
            this.btnTeamCHalf = new System.Windows.Forms.Button();
            this.rcTeamA = new Videohouse.Timing.ReferenceClock(this.components);
            this.rcTeamB = new Videohouse.Timing.ReferenceClock(this.components);
            this.rcTeamC = new Videohouse.Timing.ReferenceClock(this.components);
            this.tlpRonde1.SuspendLayout();
            this.tlpControlA.SuspendLayout();
            this.tlpControlB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).BeginInit();
            this.tlpGenres.SuspendLayout();
            this.tlpControlC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRonde1
            // 
            this.tlpRonde1.ColumnCount = 3;
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.Controls.Add(this.tlpControlA, 0, 3);
            this.tlpRonde1.Controls.Add(this.tlpControlB, 1, 3);
            this.tlpRonde1.Controls.Add(this.nudTeamC, 2, 1);
            this.tlpRonde1.Controls.Add(this.nudTeamB, 1, 1);
            this.tlpRonde1.Controls.Add(this.nudTeamA, 0, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamB, 1, 0);
            this.tlpRonde1.Controls.Add(this.lblTeamC, 2, 0);
            this.tlpRonde1.Controls.Add(this.lblTeamA, 0, 0);
            this.tlpRonde1.Controls.Add(this.tlpGenres, 1, 2);
            this.tlpRonde1.Controls.Add(this.tlpControlC, 2, 3);
            this.tlpRonde1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRonde1.Location = new System.Drawing.Point(10, 10);
            this.tlpRonde1.Name = "tlpRonde1";
            this.tlpRonde1.RowCount = 5;
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.38646F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.61354F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.Size = new System.Drawing.Size(845, 432);
            this.tlpRonde1.TabIndex = 2;
            // 
            // tlpControlA
            // 
            this.tlpControlA.ColumnCount = 1;
            this.tlpControlA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlA.Controls.Add(this.btnTeamABeide, 0, 2);
            this.tlpControlA.Controls.Add(this.btnTeamAStart, 0, 0);
            this.tlpControlA.Controls.Add(this.btnTeamAHalf, 0, 1);
            this.tlpControlA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlA.Location = new System.Drawing.Point(3, 277);
            this.tlpControlA.Name = "tlpControlA";
            this.tlpControlA.RowCount = 3;
            this.tlpControlA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControlA.Size = new System.Drawing.Size(275, 111);
            this.tlpControlA.TabIndex = 12;
            // 
            // btnTeamABeide
            // 
            this.btnTeamABeide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamABeide.Location = new System.Drawing.Point(3, 77);
            this.btnTeamABeide.Name = "btnTeamABeide";
            this.btnTeamABeide.Size = new System.Drawing.Size(269, 31);
            this.btnTeamABeide.TabIndex = 4;
            this.btnTeamABeide.Text = "Beide";
            this.btnTeamABeide.UseVisualStyleBackColor = true;
            this.btnTeamABeide.Click += new System.EventHandler(this.btnTeamABeide_Click);
            // 
            // btnTeamAStart
            // 
            this.btnTeamAStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAStart.Location = new System.Drawing.Point(3, 3);
            this.btnTeamAStart.Name = "btnTeamAStart";
            this.btnTeamAStart.Size = new System.Drawing.Size(269, 31);
            this.btnTeamAStart.TabIndex = 2;
            this.btnTeamAStart.Text = "Start";
            this.btnTeamAStart.UseVisualStyleBackColor = true;
            this.btnTeamAStart.Click += new System.EventHandler(this.btnTeamAStart_Click);
            // 
            // btnTeamAHalf
            // 
            this.btnTeamAHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAHalf.Location = new System.Drawing.Point(3, 40);
            this.btnTeamAHalf.Name = "btnTeamAHalf";
            this.btnTeamAHalf.Size = new System.Drawing.Size(269, 31);
            this.btnTeamAHalf.TabIndex = 3;
            this.btnTeamAHalf.Text = "1/2";
            this.btnTeamAHalf.UseVisualStyleBackColor = true;
            this.btnTeamAHalf.Click += new System.EventHandler(this.btnTeamAHalf_Click);
            // 
            // tlpControlB
            // 
            this.tlpControlB.ColumnCount = 1;
            this.tlpControlB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlB.Controls.Add(this.btnTeamBBeide, 0, 2);
            this.tlpControlB.Controls.Add(this.btnTeamBHalf, 0, 1);
            this.tlpControlB.Controls.Add(this.btnTeamBStart, 0, 0);
            this.tlpControlB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlB.Location = new System.Drawing.Point(284, 277);
            this.tlpControlB.Name = "tlpControlB";
            this.tlpControlB.RowCount = 3;
            this.tlpControlB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControlB.Size = new System.Drawing.Size(275, 111);
            this.tlpControlB.TabIndex = 11;
            // 
            // btnTeamBBeide
            // 
            this.btnTeamBBeide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBBeide.Location = new System.Drawing.Point(3, 77);
            this.btnTeamBBeide.Name = "btnTeamBBeide";
            this.btnTeamBBeide.Size = new System.Drawing.Size(269, 31);
            this.btnTeamBBeide.TabIndex = 2;
            this.btnTeamBBeide.Text = "Beide";
            this.btnTeamBBeide.UseVisualStyleBackColor = true;
            this.btnTeamBBeide.Click += new System.EventHandler(this.btnTeamBBeide_Click);
            // 
            // btnTeamBHalf
            // 
            this.btnTeamBHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBHalf.Location = new System.Drawing.Point(3, 40);
            this.btnTeamBHalf.Name = "btnTeamBHalf";
            this.btnTeamBHalf.Size = new System.Drawing.Size(269, 31);
            this.btnTeamBHalf.TabIndex = 1;
            this.btnTeamBHalf.Text = "1/2";
            this.btnTeamBHalf.UseVisualStyleBackColor = true;
            this.btnTeamBHalf.Click += new System.EventHandler(this.btnTeamBHalf_Click);
            // 
            // btnTeamBStart
            // 
            this.btnTeamBStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBStart.Location = new System.Drawing.Point(3, 3);
            this.btnTeamBStart.Name = "btnTeamBStart";
            this.btnTeamBStart.Size = new System.Drawing.Size(269, 31);
            this.btnTeamBStart.TabIndex = 0;
            this.btnTeamBStart.Text = "Start";
            this.btnTeamBStart.UseVisualStyleBackColor = true;
            this.btnTeamBStart.Click += new System.EventHandler(this.btnTeamBStart_Click);
            // 
            // nudTeamC
            // 
            this.nudTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamC.Location = new System.Drawing.Point(565, 43);
            this.nudTeamC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamC.Name = "nudTeamC";
            this.nudTeamC.Size = new System.Drawing.Size(277, 31);
            this.nudTeamC.TabIndex = 8;
            this.nudTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamC.ValueChanged += new System.EventHandler(this.nudTeam_ValueChanged);
            // 
            // nudTeamB
            // 
            this.nudTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamB.Location = new System.Drawing.Point(284, 43);
            this.nudTeamB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamB.Name = "nudTeamB";
            this.nudTeamB.Size = new System.Drawing.Size(275, 31);
            this.nudTeamB.TabIndex = 7;
            this.nudTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamB.ValueChanged += new System.EventHandler(this.nudTeam_ValueChanged);
            // 
            // nudTeamA
            // 
            this.nudTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamA.Location = new System.Drawing.Point(3, 43);
            this.nudTeamA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamA.Name = "nudTeamA";
            this.nudTeamA.Size = new System.Drawing.Size(275, 31);
            this.nudTeamA.TabIndex = 6;
            this.nudTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamA.ValueChanged += new System.EventHandler(this.nudTeam_ValueChanged);
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.Location = new System.Drawing.Point(284, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(275, 40);
            this.lblTeamB.TabIndex = 5;
            this.lblTeamB.Text = "TEAM B";
            this.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamC
            // 
            this.lblTeamC.AutoSize = true;
            this.lblTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamC.Location = new System.Drawing.Point(565, 0);
            this.lblTeamC.Name = "lblTeamC";
            this.lblTeamC.Size = new System.Drawing.Size(277, 40);
            this.lblTeamC.TabIndex = 4;
            this.lblTeamC.Text = "TEAM C";
            this.lblTeamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamA.Location = new System.Drawing.Point(3, 0);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(275, 40);
            this.lblTeamA.TabIndex = 2;
            this.lblTeamA.Text = "TEAM A";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpGenres
            // 
            this.tlpGenres.ColumnCount = 1;
            this.tlpGenres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGenres.Controls.Add(this.btnGenre3, 0, 2);
            this.tlpGenres.Controls.Add(this.btnGenre2, 0, 1);
            this.tlpGenres.Controls.Add(this.btnGenre1, 0, 0);
            this.tlpGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGenres.Location = new System.Drawing.Point(284, 143);
            this.tlpGenres.Name = "tlpGenres";
            this.tlpGenres.RowCount = 3;
            this.tlpGenres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGenres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGenres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGenres.Size = new System.Drawing.Size(275, 128);
            this.tlpGenres.TabIndex = 9;
            // 
            // btnGenre3
            // 
            this.btnGenre3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnGenre3.AutoSize = true;
            this.btnGenre3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenre3.Location = new System.Drawing.Point(3, 87);
            this.btnGenre3.Name = "btnGenre3";
            this.btnGenre3.Size = new System.Drawing.Size(269, 38);
            this.btnGenre3.TabIndex = 2;
            this.btnGenre3.Text = "Genre 3";
            this.btnGenre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenre3.UseVisualStyleBackColor = true;
            this.btnGenre3.CheckedChanged += new System.EventHandler(this.btnGenre_CheckedChanged);
            // 
            // btnGenre2
            // 
            this.btnGenre2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnGenre2.AutoSize = true;
            this.btnGenre2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenre2.Location = new System.Drawing.Point(3, 45);
            this.btnGenre2.Name = "btnGenre2";
            this.btnGenre2.Size = new System.Drawing.Size(269, 36);
            this.btnGenre2.TabIndex = 1;
            this.btnGenre2.Text = "Genre 2";
            this.btnGenre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenre2.UseVisualStyleBackColor = true;
            this.btnGenre2.CheckedChanged += new System.EventHandler(this.btnGenre_CheckedChanged);
            // 
            // btnGenre1
            // 
            this.btnGenre1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnGenre1.AutoSize = true;
            this.btnGenre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenre1.Location = new System.Drawing.Point(3, 3);
            this.btnGenre1.Name = "btnGenre1";
            this.btnGenre1.Size = new System.Drawing.Size(269, 36);
            this.btnGenre1.TabIndex = 0;
            this.btnGenre1.Text = "Genre 1";
            this.btnGenre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenre1.UseVisualStyleBackColor = true;
            this.btnGenre1.CheckedChanged += new System.EventHandler(this.btnGenre_CheckedChanged);
            // 
            // tlpControlC
            // 
            this.tlpControlC.ColumnCount = 1;
            this.tlpControlC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlC.Controls.Add(this.btnTeamCBeide, 0, 2);
            this.tlpControlC.Controls.Add(this.btnTeamCStart, 0, 0);
            this.tlpControlC.Controls.Add(this.btnTeamCHalf, 0, 1);
            this.tlpControlC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlC.Location = new System.Drawing.Point(565, 277);
            this.tlpControlC.Name = "tlpControlC";
            this.tlpControlC.RowCount = 3;
            this.tlpControlC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControlC.Size = new System.Drawing.Size(277, 111);
            this.tlpControlC.TabIndex = 10;
            // 
            // btnTeamCBeide
            // 
            this.btnTeamCBeide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCBeide.Location = new System.Drawing.Point(3, 77);
            this.btnTeamCBeide.Name = "btnTeamCBeide";
            this.btnTeamCBeide.Size = new System.Drawing.Size(271, 31);
            this.btnTeamCBeide.TabIndex = 7;
            this.btnTeamCBeide.Text = "Beide";
            this.btnTeamCBeide.UseVisualStyleBackColor = true;
            this.btnTeamCBeide.Click += new System.EventHandler(this.btnTeamCBeide_Click);
            // 
            // btnTeamCStart
            // 
            this.btnTeamCStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCStart.Location = new System.Drawing.Point(3, 3);
            this.btnTeamCStart.Name = "btnTeamCStart";
            this.btnTeamCStart.Size = new System.Drawing.Size(271, 31);
            this.btnTeamCStart.TabIndex = 5;
            this.btnTeamCStart.Text = "Start";
            this.btnTeamCStart.UseVisualStyleBackColor = true;
            this.btnTeamCStart.Click += new System.EventHandler(this.btnTeamCStart_Click);
            // 
            // btnTeamCHalf
            // 
            this.btnTeamCHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCHalf.Location = new System.Drawing.Point(3, 40);
            this.btnTeamCHalf.Name = "btnTeamCHalf";
            this.btnTeamCHalf.Size = new System.Drawing.Size(271, 31);
            this.btnTeamCHalf.TabIndex = 6;
            this.btnTeamCHalf.Text = "1/2";
            this.btnTeamCHalf.UseVisualStyleBackColor = true;
            this.btnTeamCHalf.Click += new System.EventHandler(this.btnTeamCHalf_Click);
            // 
            // rcTeamA
            // 
            this.rcTeamA.CountDirection = Videohouse.Timing.countDirection.Down;
            this.rcTeamA.Period = Videohouse.Timing.timerPeriod.Second;
            this.rcTeamA.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.rcTeamA_Elapsed);
            // 
            // rcTeamB
            // 
            this.rcTeamB.CountDirection = Videohouse.Timing.countDirection.Down;
            this.rcTeamB.Period = Videohouse.Timing.timerPeriod.Second;
            this.rcTeamB.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.rcTeamB_Elapsed);
            // 
            // rcTeamC
            // 
            this.rcTeamC.CountDirection = Videohouse.Timing.countDirection.Down;
            this.rcTeamC.Period = Videohouse.Timing.timerPeriod.Second;
            this.rcTeamC.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.rcTeamC_Elapsed);
            // 
            // frmRonde3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 452);
            this.Controls.Add(this.tlpRonde1);
            this.Name = "frmRonde3";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ronde 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRonde3_FormClosing);
            this.Load += new System.EventHandler(this.frmRonde3_Load);
            this.tlpRonde1.ResumeLayout(false);
            this.tlpRonde1.PerformLayout();
            this.tlpControlA.ResumeLayout(false);
            this.tlpControlB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).EndInit();
            this.tlpGenres.ResumeLayout(false);
            this.tlpGenres.PerformLayout();
            this.tlpControlC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRonde1;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTeamC;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.NumericUpDown nudTeamA;
        private System.Windows.Forms.NumericUpDown nudTeamB;
        private System.Windows.Forms.NumericUpDown nudTeamC;
        private System.Windows.Forms.TableLayoutPanel tlpGenres;
        private System.Windows.Forms.CheckBox btnGenre3;
        private System.Windows.Forms.CheckBox btnGenre2;
        private System.Windows.Forms.CheckBox btnGenre1;
        private System.Windows.Forms.TableLayoutPanel tlpControlA;
        private System.Windows.Forms.TableLayoutPanel tlpControlB;
        private System.Windows.Forms.TableLayoutPanel tlpControlC;
        private System.Windows.Forms.Button btnTeamABeide;
        private System.Windows.Forms.Button btnTeamAStart;
        private System.Windows.Forms.Button btnTeamAHalf;
        private System.Windows.Forms.Button btnTeamBBeide;
        private System.Windows.Forms.Button btnTeamBHalf;
        private System.Windows.Forms.Button btnTeamBStart;
        private System.Windows.Forms.Button btnTeamCBeide;
        private System.Windows.Forms.Button btnTeamCStart;
        private System.Windows.Forms.Button btnTeamCHalf;
        private Videohouse.Timing.ReferenceClock rcTeamA;
        private Videohouse.Timing.ReferenceClock rcTeamB;
        private Videohouse.Timing.ReferenceClock rcTeamC;
    }
}