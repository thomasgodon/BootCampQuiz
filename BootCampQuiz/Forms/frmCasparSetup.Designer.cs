namespace BootCampQuiz.Forms
{
    partial class frmCasparSetup
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
            this.tlpCasparSetup = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.tlpCasparSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCasparSetup
            // 
            this.tlpCasparSetup.ColumnCount = 2;
            this.tlpCasparSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCasparSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCasparSetup.Controls.Add(this.label3, 0, 1);
            this.tlpCasparSetup.Controls.Add(this.btnSave, 0, 2);
            this.tlpCasparSetup.Controls.Add(this.label1, 0, 0);
            this.tlpCasparSetup.Controls.Add(this.txtHost, 1, 0);
            this.tlpCasparSetup.Controls.Add(this.nudPort, 1, 1);
            this.tlpCasparSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCasparSetup.Location = new System.Drawing.Point(10, 10);
            this.tlpCasparSetup.Name = "tlpCasparSetup";
            this.tlpCasparSetup.RowCount = 3;
            this.tlpCasparSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCasparSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCasparSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCasparSetup.Size = new System.Drawing.Size(222, 95);
            this.tlpCasparSetup.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.tlpCasparSetup.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHost
            // 
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHost.Location = new System.Drawing.Point(43, 3);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(176, 20);
            this.txtHost.TabIndex = 4;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // nudPort
            // 
            this.nudPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPort.Location = new System.Drawing.Point(43, 30);
            this.nudPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(176, 20);
            this.nudPort.TabIndex = 5;
            this.nudPort.Value = new decimal(new int[] {
            5252,
            0,
            0,
            0});
            this.nudPort.ValueChanged += new System.EventHandler(this.nudPort_ValueChanged);
            // 
            // frmCasparSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 115);
            this.Controls.Add(this.tlpCasparSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCasparSetup";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasparCG Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCasparSetup_FormClosing);
            this.tlpCasparSetup.ResumeLayout(false);
            this.tlpCasparSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCasparSetup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.NumericUpDown nudPort;
    }
}