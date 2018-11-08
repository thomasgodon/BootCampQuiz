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
            this.btnTeamA30 = new System.Windows.Forms.Button();
            this.btnTeamA20 = new System.Windows.Forms.Button();
            this.btnTeamA10 = new System.Windows.Forms.Button();
            this.btnTeamA0 = new System.Windows.Forms.Button();
            this.tlpButtonsTeamC = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamC30 = new System.Windows.Forms.Button();
            this.btnTeamC20 = new System.Windows.Forms.Button();
            this.btnTeamC10 = new System.Windows.Forms.Button();
            this.btnTeamC0 = new System.Windows.Forms.Button();
            this.tlpButtonsTeamB = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamB30 = new System.Windows.Forms.Button();
            this.btnTeamB20 = new System.Windows.Forms.Button();
            this.btnTeamB0 = new System.Windows.Forms.Button();
            this.btnTeamB10 = new System.Windows.Forms.Button();
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
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamA30, 0, 0);
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamA20, 0, 1);
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamA10, 0, 2);
            this.tlpButtonsTeamA.Controls.Add(this.btnTeamA0, 0, 3);
            this.tlpButtonsTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamA.Location = new System.Drawing.Point(3, 143);
            this.tlpButtonsTeamA.Name = "tlpButtonsTeamA";
            this.tlpButtonsTeamA.RowCount = 4;
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamA.Size = new System.Drawing.Size(251, 170);
            this.tlpButtonsTeamA.TabIndex = 26;
            // 
            // btnTeamA30
            // 
            this.btnTeamA30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamA30.Location = new System.Drawing.Point(3, 3);
            this.btnTeamA30.Name = "btnTeamA30";
            this.btnTeamA30.Size = new System.Drawing.Size(245, 36);
            this.btnTeamA30.TabIndex = 13;
            this.btnTeamA30.Tag = "30";
            this.btnTeamA30.Text = "30";
            this.btnTeamA30.UseVisualStyleBackColor = true;
            this.btnTeamA30.Click += new System.EventHandler(this.btnTeamA_Click);
            // 
            // btnTeamA20
            // 
            this.btnTeamA20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamA20.Location = new System.Drawing.Point(3, 45);
            this.btnTeamA20.Name = "btnTeamA20";
            this.btnTeamA20.Size = new System.Drawing.Size(245, 36);
            this.btnTeamA20.TabIndex = 16;
            this.btnTeamA20.Tag = "20";
            this.btnTeamA20.Text = "20";
            this.btnTeamA20.UseVisualStyleBackColor = true;
            this.btnTeamA20.Click += new System.EventHandler(this.btnTeamA_Click);
            // 
            // btnTeamA10
            // 
            this.btnTeamA10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamA10.Location = new System.Drawing.Point(3, 87);
            this.btnTeamA10.Name = "btnTeamA10";
            this.btnTeamA10.Size = new System.Drawing.Size(245, 36);
            this.btnTeamA10.TabIndex = 19;
            this.btnTeamA10.Tag = "10";
            this.btnTeamA10.Text = "10";
            this.btnTeamA10.UseVisualStyleBackColor = true;
            this.btnTeamA10.Click += new System.EventHandler(this.btnTeamA_Click);
            // 
            // btnTeamA0
            // 
            this.btnTeamA0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamA0.Location = new System.Drawing.Point(3, 129);
            this.btnTeamA0.Name = "btnTeamA0";
            this.btnTeamA0.Size = new System.Drawing.Size(245, 38);
            this.btnTeamA0.TabIndex = 22;
            this.btnTeamA0.Tag = "0";
            this.btnTeamA0.Text = "0";
            this.btnTeamA0.UseVisualStyleBackColor = true;
            this.btnTeamA0.Click += new System.EventHandler(this.btnTeamA_Click);
            // 
            // tlpButtonsTeamC
            // 
            this.tlpButtonsTeamC.ColumnCount = 1;
            this.tlpButtonsTeamC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamC30, 0, 0);
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamC20, 0, 1);
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamC10, 0, 2);
            this.tlpButtonsTeamC.Controls.Add(this.btnTeamC0, 0, 3);
            this.tlpButtonsTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamC.Location = new System.Drawing.Point(517, 143);
            this.tlpButtonsTeamC.Name = "tlpButtonsTeamC";
            this.tlpButtonsTeamC.RowCount = 4;
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamC.Size = new System.Drawing.Size(252, 170);
            this.tlpButtonsTeamC.TabIndex = 27;
            // 
            // btnTeamC30
            // 
            this.btnTeamC30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamC30.Location = new System.Drawing.Point(3, 3);
            this.btnTeamC30.Name = "btnTeamC30";
            this.btnTeamC30.Size = new System.Drawing.Size(246, 36);
            this.btnTeamC30.TabIndex = 15;
            this.btnTeamC30.Tag = "30";
            this.btnTeamC30.Text = "30";
            this.btnTeamC30.UseVisualStyleBackColor = true;
            this.btnTeamC30.Click += new System.EventHandler(this.btnTeamC_Click);
            // 
            // btnTeamC20
            // 
            this.btnTeamC20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamC20.Location = new System.Drawing.Point(3, 45);
            this.btnTeamC20.Name = "btnTeamC20";
            this.btnTeamC20.Size = new System.Drawing.Size(246, 36);
            this.btnTeamC20.TabIndex = 18;
            this.btnTeamC20.Tag = "20";
            this.btnTeamC20.Text = "20";
            this.btnTeamC20.UseVisualStyleBackColor = true;
            this.btnTeamC20.Click += new System.EventHandler(this.btnTeamC_Click);
            // 
            // btnTeamC10
            // 
            this.btnTeamC10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamC10.Location = new System.Drawing.Point(3, 87);
            this.btnTeamC10.Name = "btnTeamC10";
            this.btnTeamC10.Size = new System.Drawing.Size(246, 36);
            this.btnTeamC10.TabIndex = 21;
            this.btnTeamC10.Tag = "10";
            this.btnTeamC10.Text = "10";
            this.btnTeamC10.UseVisualStyleBackColor = true;
            this.btnTeamC10.Click += new System.EventHandler(this.btnTeamC_Click);
            // 
            // btnTeamC0
            // 
            this.btnTeamC0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamC0.Location = new System.Drawing.Point(3, 129);
            this.btnTeamC0.Name = "btnTeamC0";
            this.btnTeamC0.Size = new System.Drawing.Size(246, 38);
            this.btnTeamC0.TabIndex = 24;
            this.btnTeamC0.Tag = "0";
            this.btnTeamC0.Text = "0";
            this.btnTeamC0.UseVisualStyleBackColor = true;
            this.btnTeamC0.Click += new System.EventHandler(this.btnTeamC_Click);
            // 
            // tlpButtonsTeamB
            // 
            this.tlpButtonsTeamB.ColumnCount = 1;
            this.tlpButtonsTeamB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamB30, 0, 0);
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamB20, 0, 1);
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamB0, 0, 3);
            this.tlpButtonsTeamB.Controls.Add(this.btnTeamB10, 0, 2);
            this.tlpButtonsTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsTeamB.Location = new System.Drawing.Point(260, 143);
            this.tlpButtonsTeamB.Name = "tlpButtonsTeamB";
            this.tlpButtonsTeamB.RowCount = 4;
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsTeamB.Size = new System.Drawing.Size(251, 170);
            this.tlpButtonsTeamB.TabIndex = 25;
            // 
            // btnTeamB30
            // 
            this.btnTeamB30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamB30.Location = new System.Drawing.Point(3, 3);
            this.btnTeamB30.Name = "btnTeamB30";
            this.btnTeamB30.Size = new System.Drawing.Size(245, 36);
            this.btnTeamB30.TabIndex = 14;
            this.btnTeamB30.Tag = "30";
            this.btnTeamB30.Text = "30";
            this.btnTeamB30.UseVisualStyleBackColor = true;
            this.btnTeamB30.Click += new System.EventHandler(this.btnTeamB_Click);
            // 
            // btnTeamB20
            // 
            this.btnTeamB20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamB20.Location = new System.Drawing.Point(3, 45);
            this.btnTeamB20.Name = "btnTeamB20";
            this.btnTeamB20.Size = new System.Drawing.Size(245, 36);
            this.btnTeamB20.TabIndex = 17;
            this.btnTeamB20.Tag = "20";
            this.btnTeamB20.Text = "20";
            this.btnTeamB20.UseVisualStyleBackColor = true;
            this.btnTeamB20.Click += new System.EventHandler(this.btnTeamB_Click);
            // 
            // btnTeamB0
            // 
            this.btnTeamB0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamB0.Location = new System.Drawing.Point(3, 129);
            this.btnTeamB0.Name = "btnTeamB0";
            this.btnTeamB0.Size = new System.Drawing.Size(245, 38);
            this.btnTeamB0.TabIndex = 23;
            this.btnTeamB0.Tag = "0";
            this.btnTeamB0.Text = "0";
            this.btnTeamB0.UseVisualStyleBackColor = true;
            this.btnTeamB0.Click += new System.EventHandler(this.btnTeamB_Click);
            // 
            // btnTeamB10
            // 
            this.btnTeamB10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamB10.Location = new System.Drawing.Point(3, 87);
            this.btnTeamB10.Name = "btnTeamB10";
            this.btnTeamB10.Size = new System.Drawing.Size(245, 36);
            this.btnTeamB10.TabIndex = 20;
            this.btnTeamB10.Tag = "10";
            this.btnTeamB10.Text = "10";
            this.btnTeamB10.UseVisualStyleBackColor = true;
            this.btnTeamB10.Click += new System.EventHandler(this.btnTeamB_Click);
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
        private System.Windows.Forms.Button btnTeamC0;
        private System.Windows.Forms.Button btnTeamB0;
        private System.Windows.Forms.Button btnTeamA0;
        private System.Windows.Forms.Button btnTeamC10;
        private System.Windows.Forms.Button btnTeamB10;
        private System.Windows.Forms.Button btnTeamA10;
        private System.Windows.Forms.Button btnTeamC20;
        private System.Windows.Forms.Button btnTeamB20;
        private System.Windows.Forms.Button btnTeamA20;
        private System.Windows.Forms.Button btnTeamC30;
        private System.Windows.Forms.Button btnTeamB30;
        private System.Windows.Forms.Button btnTeamA30;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamA;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamC;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsTeamB;
    }
}