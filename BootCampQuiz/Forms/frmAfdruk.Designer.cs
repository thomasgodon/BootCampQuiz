namespace BootCampQuiz.Forms
{
    partial class frmAfdruk
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
            this.tlpAfdruk = new System.Windows.Forms.TableLayoutPanel();
            this.btnTeamA = new System.Windows.Forms.Button();
            this.btnTeamB = new System.Windows.Forms.Button();
            this.btnTeamC = new System.Windows.Forms.Button();
            this.tlpAfdruk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAfdruk
            // 
            this.tlpAfdruk.ColumnCount = 1;
            this.tlpAfdruk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAfdruk.Controls.Add(this.btnTeamC, 0, 2);
            this.tlpAfdruk.Controls.Add(this.btnTeamB, 0, 1);
            this.tlpAfdruk.Controls.Add(this.btnTeamA, 0, 0);
            this.tlpAfdruk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAfdruk.Location = new System.Drawing.Point(10, 10);
            this.tlpAfdruk.Name = "tlpAfdruk";
            this.tlpAfdruk.RowCount = 3;
            this.tlpAfdruk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAfdruk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAfdruk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAfdruk.Size = new System.Drawing.Size(305, 256);
            this.tlpAfdruk.TabIndex = 0;
            // 
            // btnTeamA
            // 
            this.btnTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamA.Location = new System.Drawing.Point(3, 3);
            this.btnTeamA.Name = "btnTeamA";
            this.btnTeamA.Size = new System.Drawing.Size(299, 79);
            this.btnTeamA.TabIndex = 0;
            this.btnTeamA.Text = "TeamA";
            this.btnTeamA.UseVisualStyleBackColor = true;
            this.btnTeamA.Click += new System.EventHandler(this.btnTeamA_Click);
            // 
            // btnTeamB
            // 
            this.btnTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamB.Location = new System.Drawing.Point(3, 88);
            this.btnTeamB.Name = "btnTeamB";
            this.btnTeamB.Size = new System.Drawing.Size(299, 79);
            this.btnTeamB.TabIndex = 1;
            this.btnTeamB.Text = "TeamB";
            this.btnTeamB.UseVisualStyleBackColor = true;
            this.btnTeamB.Click += new System.EventHandler(this.btnTeamB_Click);
            // 
            // btnTeamC
            // 
            this.btnTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeamC.Location = new System.Drawing.Point(3, 173);
            this.btnTeamC.Name = "btnTeamC";
            this.btnTeamC.Size = new System.Drawing.Size(299, 80);
            this.btnTeamC.TabIndex = 2;
            this.btnTeamC.Text = "TeamC";
            this.btnTeamC.UseVisualStyleBackColor = true;
            this.btnTeamC.Click += new System.EventHandler(this.btnTeamC_Click);
            // 
            // frmAfdruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 276);
            this.Controls.Add(this.tlpAfdruk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAfdruk";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Afdruk";
            this.tlpAfdruk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAfdruk;
        private System.Windows.Forms.Button btnTeamC;
        private System.Windows.Forms.Button btnTeamB;
        private System.Windows.Forms.Button btnTeamA;
    }
}