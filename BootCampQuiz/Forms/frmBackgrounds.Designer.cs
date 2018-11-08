namespace BootCampQuiz.Forms
{
    partial class frmBackgrounds
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinale = new System.Windows.Forms.Button();
            this.btnBackground3 = new System.Windows.Forms.Button();
            this.btnBackground2 = new System.Windows.Forms.Button();
            this.btnBackground1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnFinale, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBackground3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBackground2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBackground1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnFinale
            // 
            this.btnFinale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinale.Location = new System.Drawing.Point(3, 204);
            this.btnFinale.Name = "btnFinale";
            this.btnFinale.Size = new System.Drawing.Size(209, 61);
            this.btnFinale.TabIndex = 5;
            this.btnFinale.Text = "FINALE";
            this.btnFinale.UseVisualStyleBackColor = true;
            this.btnFinale.Click += new System.EventHandler(this.btnFinale_Click);
            // 
            // btnBackground3
            // 
            this.btnBackground3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackground3.Location = new System.Drawing.Point(3, 137);
            this.btnBackground3.Name = "btnBackground3";
            this.btnBackground3.Size = new System.Drawing.Size(209, 61);
            this.btnBackground3.TabIndex = 4;
            this.btnBackground3.Text = "RONDE 3";
            this.btnBackground3.UseVisualStyleBackColor = true;
            this.btnBackground3.Click += new System.EventHandler(this.btnBackground3_Click);
            // 
            // btnBackground2
            // 
            this.btnBackground2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackground2.Location = new System.Drawing.Point(3, 70);
            this.btnBackground2.Name = "btnBackground2";
            this.btnBackground2.Size = new System.Drawing.Size(209, 61);
            this.btnBackground2.TabIndex = 3;
            this.btnBackground2.Text = "RONDE 2";
            this.btnBackground2.UseVisualStyleBackColor = true;
            this.btnBackground2.Click += new System.EventHandler(this.btnBackground2_Click);
            // 
            // btnBackground1
            // 
            this.btnBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackground1.Location = new System.Drawing.Point(3, 3);
            this.btnBackground1.Name = "btnBackground1";
            this.btnBackground1.Size = new System.Drawing.Size(209, 61);
            this.btnBackground1.TabIndex = 2;
            this.btnBackground1.Text = "RONDE 1";
            this.btnBackground1.UseVisualStyleBackColor = true;
            this.btnBackground1.Click += new System.EventHandler(this.btnBackground1_Click);
            // 
            // frmBackgrounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 288);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackgrounds";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backgrounds";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBackground3;
        private System.Windows.Forms.Button btnBackground2;
        private System.Windows.Forms.Button btnBackground1;
        private System.Windows.Forms.Button btnFinale;
    }
}