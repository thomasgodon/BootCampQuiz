namespace BootCampQuiz.Forms
{
    partial class frmRonde1
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
            this.tlpRonde1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamCFout = new System.Windows.Forms.Button();
            this.btnTeamBFout = new System.Windows.Forms.Button();
            this.btnTeamAFout = new System.Windows.Forms.Button();
            this.btnTeamBJuist = new System.Windows.Forms.Button();
            this.btnTeamAJuist = new System.Windows.Forms.Button();
            this.nudTeamC = new System.Windows.Forms.NumericUpDown();
            this.nudTeamB = new System.Windows.Forms.NumericUpDown();
            this.lblTeamC = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.nudTeamA = new System.Windows.Forms.NumericUpDown();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.btnTeamCJuist = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlpRonde1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRonde1
            // 
            this.tlpRonde1.ColumnCount = 3;
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.Controls.Add(this.btnTeamCFout, 2, 3);
            this.tlpRonde1.Controls.Add(this.btnTeamBFout, 1, 3);
            this.tlpRonde1.Controls.Add(this.btnTeamAFout, 0, 3);
            this.tlpRonde1.Controls.Add(this.btnTeamBJuist, 1, 2);
            this.tlpRonde1.Controls.Add(this.btnTeamAJuist, 0, 2);
            this.tlpRonde1.Controls.Add(this.nudTeamC, 2, 1);
            this.tlpRonde1.Controls.Add(this.nudTeamB, 1, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamC, 2, 0);
            this.tlpRonde1.Controls.Add(this.lblTeamB, 1, 0);
            this.tlpRonde1.Controls.Add(this.nudTeamA, 0, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamA, 0, 0);
            this.tlpRonde1.Controls.Add(this.btnTeamCJuist, 2, 2);
            this.tlpRonde1.Controls.Add(this.btnReset, 1, 4);
            this.tlpRonde1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRonde1.Location = new System.Drawing.Point(10, 10);
            this.tlpRonde1.Name = "tlpRonde1";
            this.tlpRonde1.RowCount = 5;
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRonde1.Size = new System.Drawing.Size(654, 324);
            this.tlpRonde1.TabIndex = 0;
            // 
            // btnTeamCFout
            // 
            this.btnTeamCFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCFout.Location = new System.Drawing.Point(438, 195);
            this.btnTeamCFout.Name = "btnTeamCFout";
            this.btnTeamCFout.Size = new System.Drawing.Size(213, 46);
            this.btnTeamCFout.TabIndex = 11;
            this.btnTeamCFout.Tag = "C";
            this.btnTeamCFout.Text = "FOUT";
            this.btnTeamCFout.UseVisualStyleBackColor = true;
            this.btnTeamCFout.Click += new System.EventHandler(this.btnFout_Click);
            // 
            // btnTeamBFout
            // 
            this.btnTeamBFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBFout.Location = new System.Drawing.Point(220, 195);
            this.btnTeamBFout.Name = "btnTeamBFout";
            this.btnTeamBFout.Size = new System.Drawing.Size(212, 46);
            this.btnTeamBFout.TabIndex = 10;
            this.btnTeamBFout.Tag = "B";
            this.btnTeamBFout.Text = "FOUT";
            this.btnTeamBFout.UseVisualStyleBackColor = true;
            this.btnTeamBFout.Click += new System.EventHandler(this.btnFout_Click);
            // 
            // btnTeamAFout
            // 
            this.btnTeamAFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAFout.Location = new System.Drawing.Point(3, 195);
            this.btnTeamAFout.Name = "btnTeamAFout";
            this.btnTeamAFout.Size = new System.Drawing.Size(211, 46);
            this.btnTeamAFout.TabIndex = 9;
            this.btnTeamAFout.Tag = "A";
            this.btnTeamAFout.Text = "FOUT";
            this.btnTeamAFout.UseVisualStyleBackColor = true;
            this.btnTeamAFout.Click += new System.EventHandler(this.btnFout_Click);
            // 
            // btnTeamBJuist
            // 
            this.btnTeamBJuist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBJuist.Location = new System.Drawing.Point(220, 143);
            this.btnTeamBJuist.Name = "btnTeamBJuist";
            this.btnTeamBJuist.Size = new System.Drawing.Size(212, 46);
            this.btnTeamBJuist.TabIndex = 8;
            this.btnTeamBJuist.Tag = "B";
            this.btnTeamBJuist.Text = "JUIST";
            this.btnTeamBJuist.UseVisualStyleBackColor = true;
            this.btnTeamBJuist.Click += new System.EventHandler(this.btnJuist_Click);
            // 
            // btnTeamAJuist
            // 
            this.btnTeamAJuist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAJuist.Location = new System.Drawing.Point(3, 143);
            this.btnTeamAJuist.Name = "btnTeamAJuist";
            this.btnTeamAJuist.Size = new System.Drawing.Size(211, 46);
            this.btnTeamAJuist.TabIndex = 7;
            this.btnTeamAJuist.Tag = "A";
            this.btnTeamAJuist.Text = "JUIST";
            this.btnTeamAJuist.UseVisualStyleBackColor = true;
            this.btnTeamAJuist.Click += new System.EventHandler(this.btnJuist_Click);
            // 
            // nudTeamC
            // 
            this.nudTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamC.Location = new System.Drawing.Point(438, 43);
            this.nudTeamC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamC.Name = "nudTeamC";
            this.nudTeamC.Size = new System.Drawing.Size(213, 31);
            this.nudTeamC.TabIndex = 5;
            this.nudTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudTeamB
            // 
            this.nudTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamB.Location = new System.Drawing.Point(220, 43);
            this.nudTeamB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamB.Name = "nudTeamB";
            this.nudTeamB.Size = new System.Drawing.Size(212, 31);
            this.nudTeamB.TabIndex = 4;
            this.nudTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeamC
            // 
            this.lblTeamC.AutoSize = true;
            this.lblTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamC.Location = new System.Drawing.Point(438, 0);
            this.lblTeamC.Name = "lblTeamC";
            this.lblTeamC.Size = new System.Drawing.Size(213, 40);
            this.lblTeamC.TabIndex = 3;
            this.lblTeamC.Text = "TEAM C";
            this.lblTeamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.Location = new System.Drawing.Point(220, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(212, 40);
            this.lblTeamB.TabIndex = 2;
            this.lblTeamB.Text = "TEAM B";
            this.lblTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.nudTeamA.Size = new System.Drawing.Size(211, 31);
            this.nudTeamA.TabIndex = 0;
            this.nudTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamA.Location = new System.Drawing.Point(3, 0);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(211, 40);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "TEAM A";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTeamCJuist
            // 
            this.btnTeamCJuist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCJuist.Location = new System.Drawing.Point(438, 143);
            this.btnTeamCJuist.Name = "btnTeamCJuist";
            this.btnTeamCJuist.Size = new System.Drawing.Size(213, 46);
            this.btnTeamCJuist.TabIndex = 6;
            this.btnTeamCJuist.Tag = "C";
            this.btnTeamCJuist.Text = "JUIST";
            this.btnTeamCJuist.UseVisualStyleBackColor = true;
            this.btnTeamCJuist.Click += new System.EventHandler(this.btnJuist_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Location = new System.Drawing.Point(220, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(212, 50);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmRonde1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 344);
            this.Controls.Add(this.tlpRonde1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 382);
            this.Name = "frmRonde1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ronde 1";
            this.Load += new System.EventHandler(this.frmRonde1_Load);
            this.tlpRonde1.ResumeLayout(false);
            this.tlpRonde1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRonde1;
        private System.Windows.Forms.Label lblTeamC;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.NumericUpDown nudTeamA;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.NumericUpDown nudTeamC;
        private System.Windows.Forms.NumericUpDown nudTeamB;
        private System.Windows.Forms.Button btnTeamCFout;
        private System.Windows.Forms.Button btnTeamBFout;
        private System.Windows.Forms.Button btnTeamAFout;
        private System.Windows.Forms.Button btnTeamBJuist;
        private System.Windows.Forms.Button btnTeamAJuist;
        private System.Windows.Forms.Button btnTeamCJuist;
        private System.Windows.Forms.Button btnReset;
    }
}