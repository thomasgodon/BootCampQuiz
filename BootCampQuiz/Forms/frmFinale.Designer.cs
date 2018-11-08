namespace BootCampQuiz.Forms
{
    partial class frmFinale
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnVorigeVraag = new System.Windows.Forms.Button();
            this.rbTeamA = new System.Windows.Forms.RadioButton();
            this.nudTimeTeamA = new System.Windows.Forms.NumericUpDown();
            this.nudTimeTeamB = new System.Windows.Forms.NumericUpDown();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.rbTeamB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAntwoord5 = new System.Windows.Forms.Button();
            this.btnAntwoord4 = new System.Windows.Forms.Button();
            this.btnAntwoord3 = new System.Windows.Forms.Button();
            this.btnAntwoord2 = new System.Windows.Forms.Button();
            this.btnAntwoord1 = new System.Windows.Forms.Button();
            this.lblVraag = new System.Windows.Forms.Label();
            this.btnVolgendeVraag = new System.Windows.Forms.Button();
            this.TimerTeamA = new Videohouse.Timing.ReferenceClock(this.components);
            this.TimerTeamB = new Videohouse.Timing.ReferenceClock(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamB)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnStartStop, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnVorigeVraag, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbTeamA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudTimeTeamA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudTimeTeamB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbTeamB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVolgendeVraag, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartStop.Location = new System.Drawing.Point(3, 431);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(380, 40);
            this.btnStartStop.TabIndex = 14;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Location = new System.Drawing.Point(389, 431);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(381, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "TOON VRAGEN";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnVorigeVraag
            // 
            this.btnVorigeVraag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVorigeVraag.Location = new System.Drawing.Point(3, 371);
            this.btnVorigeVraag.Name = "btnVorigeVraag";
            this.btnVorigeVraag.Size = new System.Drawing.Size(380, 40);
            this.btnVorigeVraag.TabIndex = 10;
            this.btnVorigeVraag.Text = "VORIGE";
            this.btnVorigeVraag.UseVisualStyleBackColor = true;
            this.btnVorigeVraag.Click += new System.EventHandler(this.btnVorigeVraag_Click);
            // 
            // rbTeamA
            // 
            this.rbTeamA.AutoSize = true;
            this.rbTeamA.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamA.Checked = true;
            this.rbTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTeamA.Location = new System.Drawing.Point(3, 93);
            this.rbTeamA.Name = "rbTeamA";
            this.rbTeamA.Size = new System.Drawing.Size(380, 34);
            this.rbTeamA.TabIndex = 7;
            this.rbTeamA.TabStop = true;
            this.rbTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamA.UseVisualStyleBackColor = true;
            this.rbTeamA.CheckedChanged += new System.EventHandler(this.rbTeamA_CheckedChanged);
            // 
            // nudTimeTeamA
            // 
            this.nudTimeTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimeTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeTeamA.Location = new System.Drawing.Point(3, 53);
            this.nudTimeTeamA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeTeamA.Name = "nudTimeTeamA";
            this.nudTimeTeamA.Size = new System.Drawing.Size(380, 31);
            this.nudTimeTeamA.TabIndex = 5;
            this.nudTimeTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimeTeamA.ValueChanged += new System.EventHandler(this.nudTimeTeamA_ValueChanged);
            // 
            // nudTimeTeamB
            // 
            this.nudTimeTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimeTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeTeamB.Location = new System.Drawing.Point(389, 53);
            this.nudTimeTeamB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeTeamB.Name = "nudTimeTeamB";
            this.nudTimeTeamB.Size = new System.Drawing.Size(381, 31);
            this.nudTimeTeamB.TabIndex = 4;
            this.nudTimeTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimeTeamB.ValueChanged += new System.EventHandler(this.nudTimeTeamB_ValueChanged);
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.Location = new System.Drawing.Point(389, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(381, 50);
            this.lblTeamB.TabIndex = 3;
            this.lblTeamB.Text = "TEAM B";
            this.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamA.Location = new System.Drawing.Point(3, 0);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(380, 50);
            this.lblTeamA.TabIndex = 2;
            this.lblTeamA.Text = "TEAM A";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbTeamB
            // 
            this.rbTeamB.AutoSize = true;
            this.rbTeamB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTeamB.Location = new System.Drawing.Point(389, 93);
            this.rbTeamB.Name = "rbTeamB";
            this.rbTeamB.Size = new System.Drawing.Size(381, 34);
            this.rbTeamB.TabIndex = 6;
            this.rbTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamB.UseVisualStyleBackColor = true;
            this.rbTeamB.CheckedChanged += new System.EventHandler(this.rbTeamB_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAntwoord5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnAntwoord4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAntwoord3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAntwoord2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAntwoord1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblVraag, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 218);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnAntwoord5
            // 
            this.btnAntwoord5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntwoord5.Location = new System.Drawing.Point(3, 183);
            this.btnAntwoord5.Name = "btnAntwoord5";
            this.btnAntwoord5.Size = new System.Drawing.Size(761, 32);
            this.btnAntwoord5.TabIndex = 4;
            this.btnAntwoord5.Tag = "4";
            this.btnAntwoord5.Text = "Antwoord 5";
            this.btnAntwoord5.UseVisualStyleBackColor = true;
            this.btnAntwoord5.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // btnAntwoord4
            // 
            this.btnAntwoord4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntwoord4.Location = new System.Drawing.Point(3, 147);
            this.btnAntwoord4.Name = "btnAntwoord4";
            this.btnAntwoord4.Size = new System.Drawing.Size(761, 30);
            this.btnAntwoord4.TabIndex = 3;
            this.btnAntwoord4.Tag = "3";
            this.btnAntwoord4.Text = "Antwoord 4";
            this.btnAntwoord4.UseVisualStyleBackColor = true;
            this.btnAntwoord4.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // btnAntwoord3
            // 
            this.btnAntwoord3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntwoord3.Location = new System.Drawing.Point(3, 111);
            this.btnAntwoord3.Name = "btnAntwoord3";
            this.btnAntwoord3.Size = new System.Drawing.Size(761, 30);
            this.btnAntwoord3.TabIndex = 2;
            this.btnAntwoord3.Tag = "2";
            this.btnAntwoord3.Text = "Antwoord 3";
            this.btnAntwoord3.UseVisualStyleBackColor = true;
            this.btnAntwoord3.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // btnAntwoord2
            // 
            this.btnAntwoord2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntwoord2.Location = new System.Drawing.Point(3, 75);
            this.btnAntwoord2.Name = "btnAntwoord2";
            this.btnAntwoord2.Size = new System.Drawing.Size(761, 30);
            this.btnAntwoord2.TabIndex = 1;
            this.btnAntwoord2.Tag = "1";
            this.btnAntwoord2.Text = "Antwoord 2";
            this.btnAntwoord2.UseVisualStyleBackColor = true;
            this.btnAntwoord2.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // btnAntwoord1
            // 
            this.btnAntwoord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntwoord1.Location = new System.Drawing.Point(3, 39);
            this.btnAntwoord1.Name = "btnAntwoord1";
            this.btnAntwoord1.Size = new System.Drawing.Size(761, 30);
            this.btnAntwoord1.TabIndex = 0;
            this.btnAntwoord1.Tag = "0";
            this.btnAntwoord1.Text = "Antwoord 1";
            this.btnAntwoord1.UseVisualStyleBackColor = true;
            this.btnAntwoord1.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVraag.Location = new System.Drawing.Point(3, 0);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(761, 36);
            this.lblVraag.TabIndex = 5;
            this.lblVraag.Text = "Vraag 1";
            this.lblVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolgendeVraag
            // 
            this.btnVolgendeVraag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVolgendeVraag.Location = new System.Drawing.Point(389, 371);
            this.btnVolgendeVraag.Name = "btnVolgendeVraag";
            this.btnVolgendeVraag.Size = new System.Drawing.Size(381, 40);
            this.btnVolgendeVraag.TabIndex = 9;
            this.btnVolgendeVraag.Text = "VOLGENDE";
            this.btnVolgendeVraag.UseVisualStyleBackColor = true;
            this.btnVolgendeVraag.Click += new System.EventHandler(this.btnVolgendeVraag_Click);
            // 
            // TimerTeamA
            // 
            this.TimerTeamA.CountDirection = Videohouse.Timing.countDirection.Down;
            this.TimerTeamA.Period = Videohouse.Timing.timerPeriod.Second;
            this.TimerTeamA.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.TimerTeamA_Elapsed);
            this.TimerTeamA.Stopped += new System.EventHandler(this.Timer_Stopped);
            // 
            // TimerTeamB
            // 
            this.TimerTeamB.CountDirection = Videohouse.Timing.countDirection.Down;
            this.TimerTeamB.Period = Videohouse.Timing.timerPeriod.Second;
            this.TimerTeamB.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.TimerTeamB_Elapsed);
            this.TimerTeamB.Stopped += new System.EventHandler(this.Timer_Stopped);
            // 
            // frmFinale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmFinale";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinale_FormClosing);
            this.Load += new System.EventHandler(this.frmFinale_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamB)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.NumericUpDown nudTimeTeamA;
        private System.Windows.Forms.NumericUpDown nudTimeTeamB;
        private System.Windows.Forms.RadioButton rbTeamA;
        private System.Windows.Forms.RadioButton rbTeamB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAntwoord5;
        private System.Windows.Forms.Button btnAntwoord4;
        private System.Windows.Forms.Button btnAntwoord3;
        private System.Windows.Forms.Button btnAntwoord2;
        private System.Windows.Forms.Button btnAntwoord1;
        private System.Windows.Forms.Button btnVorigeVraag;
        private System.Windows.Forms.Button btnVolgendeVraag;
        private System.Windows.Forms.Button btnReset;
        private Videohouse.Timing.ReferenceClock TimerTeamA;
        private Videohouse.Timing.ReferenceClock TimerTeamB;
        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Button btnStartStop;
    }
}