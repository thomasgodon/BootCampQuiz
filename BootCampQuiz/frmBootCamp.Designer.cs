namespace BootCampQuiz
{
    partial class frmBootCamp
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miCasparCG = new System.Windows.Forms.ToolStripMenuItem();
            this.miCasparCGConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miCasparCGSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRonde1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miRonde2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miRonde3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miFinale = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfdrukken = new System.Windows.Forms.ToolStripMenuItem();
            this.miBackgrounds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCasparCGStatus = new System.Windows.Forms.ToolStrip();
            this.lblCasparCGStatus = new System.Windows.Forms.ToolStripLabel();
            this.miRonde4 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.tsCasparCGStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCasparCG,
            this.miRonde1,
            this.miRonde2,
            this.miRonde3,
            this.miRonde4,
            this.miFinale,
            this.miAfdrukken,
            this.miBackgrounds});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(784, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // miCasparCG
            // 
            this.miCasparCG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCasparCGConnect,
            this.miCasparCGSetup});
            this.miCasparCG.Name = "miCasparCG";
            this.miCasparCG.Size = new System.Drawing.Size(71, 20);
            this.miCasparCG.Text = "CasparCG";
            // 
            // miCasparCGConnect
            // 
            this.miCasparCGConnect.Name = "miCasparCGConnect";
            this.miCasparCGConnect.Size = new System.Drawing.Size(119, 22);
            this.miCasparCGConnect.Text = "Connect";
            this.miCasparCGConnect.Click += new System.EventHandler(this.miCasparCGConnect_Click);
            // 
            // miCasparCGSetup
            // 
            this.miCasparCGSetup.Name = "miCasparCGSetup";
            this.miCasparCGSetup.Size = new System.Drawing.Size(119, 22);
            this.miCasparCGSetup.Text = "Setup";
            this.miCasparCGSetup.Click += new System.EventHandler(this.miCasparCGSetup_Click);
            // 
            // miRonde1
            // 
            this.miRonde1.Name = "miRonde1";
            this.miRonde1.Size = new System.Drawing.Size(62, 20);
            this.miRonde1.Text = "Ronde 1";
            this.miRonde1.Click += new System.EventHandler(this.miRonde1_Click);
            // 
            // miRonde2
            // 
            this.miRonde2.Name = "miRonde2";
            this.miRonde2.Size = new System.Drawing.Size(62, 20);
            this.miRonde2.Text = "Ronde 2";
            this.miRonde2.Click += new System.EventHandler(this.miRonde2_Click);
            // 
            // miRonde3
            // 
            this.miRonde3.Name = "miRonde3";
            this.miRonde3.Size = new System.Drawing.Size(62, 20);
            this.miRonde3.Text = "Ronde 3";
            this.miRonde3.Click += new System.EventHandler(this.miRonde3_Click);
            // 
            // miFinale
            // 
            this.miFinale.Name = "miFinale";
            this.miFinale.Size = new System.Drawing.Size(50, 20);
            this.miFinale.Text = "Finale";
            this.miFinale.Click += new System.EventHandler(this.miFinale_Click);
            // 
            // miAfdrukken
            // 
            this.miAfdrukken.Name = "miAfdrukken";
            this.miAfdrukken.Size = new System.Drawing.Size(74, 20);
            this.miAfdrukken.Text = "Afdrukken";
            this.miAfdrukken.Click += new System.EventHandler(this.miAfdrukken_Click);
            // 
            // miBackgrounds
            // 
            this.miBackgrounds.Name = "miBackgrounds";
            this.miBackgrounds.Size = new System.Drawing.Size(88, 20);
            this.miBackgrounds.Text = "Backgrounds";
            this.miBackgrounds.Click += new System.EventHandler(this.miBackgrounds_Click);
            // 
            // tsCasparCGStatus
            // 
            this.tsCasparCGStatus.CanOverflow = false;
            this.tsCasparCGStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsCasparCGStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCasparCGStatus});
            this.tsCasparCGStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsCasparCGStatus.Location = new System.Drawing.Point(0, 388);
            this.tsCasparCGStatus.Name = "tsCasparCGStatus";
            this.tsCasparCGStatus.Size = new System.Drawing.Size(784, 18);
            this.tsCasparCGStatus.TabIndex = 3;
            this.tsCasparCGStatus.Text = "toolStrip1";
            // 
            // lblCasparCGStatus
            // 
            this.lblCasparCGStatus.Name = "lblCasparCGStatus";
            this.lblCasparCGStatus.Size = new System.Drawing.Size(86, 15);
            this.lblCasparCGStatus.Text = "toolStripLabel1";
            // 
            // miRonde4
            // 
            this.miRonde4.Name = "miRonde4";
            this.miRonde4.Size = new System.Drawing.Size(62, 20);
            this.miRonde4.Text = "Ronde 4";
            this.miRonde4.Click += new System.EventHandler(this.miRonde4_Click);
            // 
            // frmBootCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BootCampQuiz.Properties.Resources.logo_boost;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.tsCasparCGStatus);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmBootCamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot Camp Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBootCamp_FormClosing);
            this.Load += new System.EventHandler(this.frmBootCamp_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsCasparCGStatus.ResumeLayout(false);
            this.tsCasparCGStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miCasparCG;
        private System.Windows.Forms.ToolStripMenuItem miRonde1;
        private System.Windows.Forms.ToolStripMenuItem miRonde2;
        private System.Windows.Forms.ToolStripMenuItem miRonde3;
        private System.Windows.Forms.ToolStripMenuItem miCasparCGConnect;
        private System.Windows.Forms.ToolStripMenuItem miCasparCGSetup;
        private System.Windows.Forms.ToolStripMenuItem miFinale;
        private System.Windows.Forms.ToolStrip tsCasparCGStatus;
        private System.Windows.Forms.ToolStripLabel lblCasparCGStatus;
        private System.Windows.Forms.ToolStripMenuItem miAfdrukken;
        private System.Windows.Forms.ToolStripMenuItem miBackgrounds;
        private System.Windows.Forms.ToolStripMenuItem miRonde4;
    }
}

