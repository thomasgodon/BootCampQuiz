namespace BootCampQuiz.Forms
{
    partial class frmRonde2
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
            this.nudTeamC = new System.Windows.Forms.NumericUpDown();
            this.nudTeamB = new System.Windows.Forms.NumericUpDown();
            this.lblTeamC = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.nudTeamA = new System.Windows.Forms.NumericUpDown();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlpButtonsTeamA = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamAGoed = new System.Windows.Forms.Button();
            this.btnTeamAFout = new System.Windows.Forms.Button();
            this.tlpButtonsTeamC = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamCGoed = new System.Windows.Forms.Button();
            this.btnTeamCFout = new System.Windows.Forms.Button();
            this.tlpButtonsTeamB = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamBGoed = new System.Windows.Forms.Button();
            this.btnTeamBFout = new System.Windows.Forms.Button();
            this.tlpRonde1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).BeginInit();
            this.tlpButtonsTeamA.SuspendLayout();
            this.tlpButtonsTeamC.SuspendLayout();
            this.tlpButtonsTeamB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRonde1
            // 
            this.tlpRonde1.ColumnCount = 3;
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.Controls.Add(this.nudTeamC, 2, 1);
            this.tlpRonde1.Controls.Add(this.nudTeamB, 1, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamC, 2, 0);
            this.tlpRonde1.Controls.Add(this.lblTeamB, 1, 0);
            this.tlpRonde1.Controls.Add(this.nudTeamA, 0, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamA, 0, 0);
            this.tlpRonde1.Controls.Add(this.btnReset, 1, 3);
            this.tlpRonde1.Controls.Add(this.tlpButtonsTeamA, 0, 2);
            this.tlpRonde1.Controls.Add(this.tlpButtonsTeamC, 2, 2);
            this.tlpRonde1.Controls.Add(this.tlpButtonsTeamB, 1, 2);
            this.tlpRonde1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRonde1.Location = new System.Drawing.Point(10, 10);
            this.tlpRonde1.Name = "tlpRonde1";
            this.tlpRonde1.RowCount = 4;
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRonde1.Size = new System.Drawing.Size(772, 420);
            this.tlpRonde1.TabIndex = 1;
            // 
            // nudTeamC
            // 
            this.nudTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamC.Location = new System.Drawing.Point(517, 43);
            this.nudTeamC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamC.Name = "nudTeamC";
            this.nudTeamC.Size = new System.Drawing.Size(252, 31);
            this.nudTeamC.TabIndex = 5;
            this.nudTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudTeamB
            // 
            this.nudTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamB.Location = new System.Drawing.Point(260, 43);
            this.nudTeamB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTeamB.Name = "nudTeamB";
            this.nudTeamB.Size = new System.Drawing.Size(251, 31);
            this.nudTeamB.TabIndex = 4;
            this.nudTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeamC
            // 
            this.lblTeamC.AutoSize = true;
            this.lblTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamC.Location = new System.Drawing.Point(517, 0);
            this.lblTeamC.Name = "lblTeamC";
            this.lblTeamC.Size = new System.Drawing.Size(252, 40);
            this.lblTeamC.TabIndex = 3;
            this.lblTeamC.Text = "TEAM C";
            this.lblTeamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.Location = new System.Drawing.Point(260, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(251, 40);
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
            this.nudTeamA.Size = new System.Drawing.Size(251, 31);
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
            this.lblTeamA.Size = new System.Drawing.Size(251, 40);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "TEAM A";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Location = new System.Drawing.Point(260, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(251, 50);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tlpButtonsTeamA
            // 
            this.tlpButtonsTeamA.ColumnCount = 1;
            this.tlpButtonsTeamA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamAGoed, 0, 0);
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamAFout, 0, 1);
            this.tlpButtonsTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamA.Location = new System.Drawing.Point(3, 143);
            this.tlpButtonsTeamA.Name = "tlpButtonsTeamA";
            this.tlpButtonsTeamA.RowCount = 2;
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamA.Size = new System.Drawing.Size(251, 170);
            this.tlpButtonsTeamA.TabIndex = 26;
            // 
            // btnTeamAGoed
            // 
            this.btnTeamAGoed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAGoed.Location = new System.Drawing.Point(3, 3);
            this.btnTeamAGoed.Name = "btnTeamAGoed";
            this.btnTeamAGoed.Size = new System.Drawing.Size(245, 79);
            this.btnTeamAGoed.TabIndex = 13;
            this.btnTeamAGoed.Tag = "A";
            this.btnTeamAGoed.Text = "Goed";
            this.btnTeamAGoed.UseVisualStyleBackColor = true;
            this.btnTeamAGoed.Click += new System.EventHandler(this.btnTeamAGoed_Click);
            // 
            // btnTeamAFout
            // 
            this.btnTeamAFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamAFout.Location = new System.Drawing.Point(3, 88);
            this.btnTeamAFout.Name = "btnTeamAFout";
            this.btnTeamAFout.Size = new System.Drawing.Size(245, 79);
            this.btnTeamAFout.TabIndex = 16;
            this.btnTeamAFout.Tag = "A";
            this.btnTeamAFout.Text = "Fout";
            this.btnTeamAFout.UseVisualStyleBackColor = true;
            this.btnTeamAFout.Click += new System.EventHandler(this.btnTeamAFout_Click);
            // 
            // tlpButtonsTeamC
            // 
            this.tlpButtonsTeamC.ColumnCount = 1;
            this.tlpButtonsTeamC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamCGoed, 0, 0);
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamCFout, 0, 1);
            this.tlpButtonsTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamC.Location = new System.Drawing.Point(517, 143);
            this.tlpButtonsTeamC.Name = "tlpButtonsTeamC";
            this.tlpButtonsTeamC.RowCount = 2;
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamC.Size = new System.Drawing.Size(252, 170);
            this.tlpButtonsTeamC.TabIndex = 27;
            // 
            // btnTeamCGoed
            // 
            this.btnTeamCGoed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCGoed.Location = new System.Drawing.Point(3, 3);
            this.btnTeamCGoed.Name = "btnTeamCGoed";
            this.btnTeamCGoed.Size = new System.Drawing.Size(246, 79);
            this.btnTeamCGoed.TabIndex = 15;
            this.btnTeamCGoed.Tag = "C";
            this.btnTeamCGoed.Text = "Goed";
            this.btnTeamCGoed.UseVisualStyleBackColor = true;
            this.btnTeamCGoed.Click += new System.EventHandler(this.btnTeamAGoed_Click);
            // 
            // btnTeamCFout
            // 
            this.btnTeamCFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamCFout.Location = new System.Drawing.Point(3, 88);
            this.btnTeamCFout.Name = "btnTeamCFout";
            this.btnTeamCFout.Size = new System.Drawing.Size(246, 79);
            this.btnTeamCFout.TabIndex = 18;
            this.btnTeamCFout.Tag = "C";
            this.btnTeamCFout.Text = "Fout";
            this.btnTeamCFout.UseVisualStyleBackColor = true;
            this.btnTeamCFout.Click += new System.EventHandler(this.btnTeamAFout_Click);
            // 
            // tlpButtonsTeamB
            // 
            this.tlpButtonsTeamB.ColumnCount = 1;
            this.tlpButtonsTeamB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamBGoed, 0, 0);
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamBFout, 0, 1);
            this.tlpButtonsTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamB.Location = new System.Drawing.Point(260, 143);
            this.tlpButtonsTeamB.Name = "tlpButtonsTeamB";
            this.tlpButtonsTeamB.RowCount = 2;
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsTeamB.Size = new System.Drawing.Size(251, 170);
            this.tlpButtonsTeamB.TabIndex = 25;
            // 
            // btnTeamBGoed
            // 
            this.btnTeamBGoed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBGoed.Location = new System.Drawing.Point(3, 3);
            this.btnTeamBGoed.Name = "btnTeamBGoed";
            this.btnTeamBGoed.Size = new System.Drawing.Size(245, 79);
            this.btnTeamBGoed.TabIndex = 14;
            this.btnTeamBGoed.Tag = "B";
            this.btnTeamBGoed.Text = "Goed";
            this.btnTeamBGoed.UseVisualStyleBackColor = true;
            this.btnTeamBGoed.Click += new System.EventHandler(this.btnTeamAGoed_Click);
            // 
            // btnTeamBFout
            // 
            this.btnTeamBFout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamBFout.Location = new System.Drawing.Point(3, 88);
            this.btnTeamBFout.Name = "btnTeamBFout";
            this.btnTeamBFout.Size = new System.Drawing.Size(245, 79);
            this.btnTeamBFout.TabIndex = 17;
            this.btnTeamBFout.Tag = "B";
            this.btnTeamBFout.Text = "Fout";
            this.btnTeamBFout.UseVisualStyleBackColor = true;
            this.btnTeamBFout.Click += new System.EventHandler(this.btnTeamAFout_Click);
            // 
            // frmRonde2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 440);
            this.Controls.Add(this.tlpRonde1);
            this.MinimizeBox = false;
            this.Name = "frmRonde2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ronde 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRonde2_FormClosing);
            this.Load += new System.EventHandler(this.frmRonde2_Load);
            this.tlpRonde1.ResumeLayout(false);
            this.tlpRonde1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).EndInit();
            this.tlpButtonsTeamA.ResumeLayout(false);
            this.tlpButtonsTeamC.ResumeLayout(false);
            this.tlpButtonsTeamB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRonde1;
        private System.Windows.Forms.NumericUpDown nudTeamC;
        private System.Windows.Forms.NumericUpDown nudTeamB;
        private System.Windows.Forms.Label lblTeamC;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.NumericUpDown nudTeamA;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTeamCFout;
        private System.Windows.Forms.Button btnTeamBFout;
        private System.Windows.Forms.Button btnTeamAFout;
        private System.Windows.Forms.Button btnTeamCGoed;
        private System.Windows.Forms.Button btnTeamBGoed;
        private System.Windows.Forms.Button btnTeamAGoed;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamA;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamC;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamB;
    }
}