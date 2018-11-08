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
            this.rbTeamB = new System.Windows.Forms.RadioButton();
            this.rbTeamA = new System.Windows.Forms.RadioButton();
            this.tlpControlsTeamC = new System.Windows.Forms.TableLayoutPanel();
            this.nudTimeTeamC = new System.Windows.Forms.NumericUpDown();
            this.btnJuistTeamC = new System.Windows.Forms.Button();
            this.nudTimerTeamC = new System.Windows.Forms.NumericUpDown();
            this.btnStartTimerTeamC = new System.Windows.Forms.Button();
            this.tlpControlsTeamB = new System.Windows.Forms.TableLayoutPanel();
            this.nudTimeTeamB = new System.Windows.Forms.NumericUpDown();
            this.btnJuistTeamB = new System.Windows.Forms.Button();
            this.nudTimerTeamB = new System.Windows.Forms.NumericUpDown();
            this.btnStartTimerTeamB = new System.Windows.Forms.Button();
            this.nudTeamC = new System.Windows.Forms.NumericUpDown();
            this.nudTeamB = new System.Windows.Forms.NumericUpDown();
            this.lblTeamC = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.nudTeamA = new System.Windows.Forms.NumericUpDown();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.tlpControlsTeamA = new System.Windows.Forms.TableLayoutPanel();
            this.nudTimeTeamA = new System.Windows.Forms.NumericUpDown();
            this.btnJuistTeamA = new System.Windows.Forms.Button();
            this.nudTimerTeamA = new System.Windows.Forms.NumericUpDown();
            this.btnStartTimerTeamA = new System.Windows.Forms.Button();
            this.rbTeamC = new System.Windows.Forms.RadioButton();
            this.TimerTeamA = new Videohouse.Timing.ReferenceClock(this.components);
            this.TimerTeamB = new Videohouse.Timing.ReferenceClock(this.components);
            this.TimerTeamC = new Videohouse.Timing.ReferenceClock(this.components);
            this.tlpRonde1.SuspendLayout();
            this.tlpControlsTeamC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamC)).BeginInit();
            this.tlpControlsTeamB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).BeginInit();
            this.tlpControlsTeamA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamA)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRonde1
            // 
            this.tlpRonde1.ColumnCount = 3;
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRonde1.Controls.Add(this.rbTeamB, 1, 3);
            this.tlpRonde1.Controls.Add(this.rbTeamA, 0, 3);
            this.tlpRonde1.Controls.Add(this.tlpControlsTeamC, 2, 2);
            this.tlpRonde1.Controls.Add(this.tlpControlsTeamB, 1, 2);
            this.tlpRonde1.Controls.Add(this.nudTeamC, 2, 1);
            this.tlpRonde1.Controls.Add(this.nudTeamB, 1, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamC, 2, 0);
            this.tlpRonde1.Controls.Add(this.lblTeamB, 1, 0);
            this.tlpRonde1.Controls.Add(this.nudTeamA, 0, 1);
            this.tlpRonde1.Controls.Add(this.lblTeamA, 0, 0);
            this.tlpRonde1.Controls.Add(this.tlpControlsTeamA, 0, 2);
            this.tlpRonde1.Controls.Add(this.rbTeamC, 2, 3);
            this.tlpRonde1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRonde1.Location = new System.Drawing.Point(10, 10);
            this.tlpRonde1.Name = "tlpRonde1";
            this.tlpRonde1.RowCount = 4;
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRonde1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRonde1.Size = new System.Drawing.Size(845, 432);
            this.tlpRonde1.TabIndex = 2;
            // 
            // rbTeamB
            // 
            this.rbTeamB.AutoSize = true;
            this.rbTeamB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTeamB.Location = new System.Drawing.Point(284, 395);
            this.rbTeamB.Name = "rbTeamB";
            this.rbTeamB.Size = new System.Drawing.Size(275, 34);
            this.rbTeamB.TabIndex = 18;
            this.rbTeamB.UseVisualStyleBackColor = true;
            this.rbTeamB.CheckedChanged += new System.EventHandler(this.rbTeam_CheckedChanged);
            // 
            // rbTeamA
            // 
            this.rbTeamA.AutoSize = true;
            this.rbTeamA.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamA.Checked = true;
            this.rbTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTeamA.Location = new System.Drawing.Point(3, 395);
            this.rbTeamA.Name = "rbTeamA";
            this.rbTeamA.Size = new System.Drawing.Size(275, 34);
            this.rbTeamA.TabIndex = 17;
            this.rbTeamA.TabStop = true;
            this.rbTeamA.UseVisualStyleBackColor = true;
            this.rbTeamA.CheckedChanged += new System.EventHandler(this.rbTeam_CheckedChanged);
            // 
            // tlpControlsTeamC
            // 
            this.tlpControlsTeamC.ColumnCount = 1;
            this.tlpControlsTeamC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlsTeamC.Controls.Add(this.nudTimeTeamC, 0, 3);
            this.tlpControlsTeamC.Controls.Add(this.btnJuistTeamC, 0, 2);
            this.tlpControlsTeamC.Controls.Add(this.nudTimerTeamC, 0, 1);
            this.tlpControlsTeamC.Controls.Add(this.btnStartTimerTeamC, 0, 0);
            this.tlpControlsTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlsTeamC.Location = new System.Drawing.Point(565, 143);
            this.tlpControlsTeamC.Name = "tlpControlsTeamC";
            this.tlpControlsTeamC.RowCount = 4;
            this.tlpControlsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamC.Size = new System.Drawing.Size(277, 246);
            this.tlpControlsTeamC.TabIndex = 15;
            // 
            // nudTimeTeamC
            // 
            this.nudTimeTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimeTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeTeamC.Location = new System.Drawing.Point(3, 186);
            this.nudTimeTeamC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeTeamC.Name = "nudTimeTeamC";
            this.nudTimeTeamC.Size = new System.Drawing.Size(271, 31);
            this.nudTimeTeamC.TabIndex = 16;
            this.nudTimeTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimeTeamC.ValueChanged += new System.EventHandler(this.nudTimeTeamC_ValueChanged);
            // 
            // btnJuistTeamC
            // 
            this.btnJuistTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJuistTeamC.Location = new System.Drawing.Point(3, 125);
            this.btnJuistTeamC.Name = "btnJuistTeamC";
            this.btnJuistTeamC.Size = new System.Drawing.Size(271, 55);
            this.btnJuistTeamC.TabIndex = 15;
            this.btnJuistTeamC.Text = "JUIST";
            this.btnJuistTeamC.UseVisualStyleBackColor = true;
            this.btnJuistTeamC.Click += new System.EventHandler(this.btnJuistTeamC_Click);
            // 
            // nudTimerTeamC
            // 
            this.nudTimerTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimerTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimerTeamC.Location = new System.Drawing.Point(3, 64);
            this.nudTimerTeamC.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamC.Name = "nudTimerTeamC";
            this.nudTimerTeamC.Size = new System.Drawing.Size(271, 31);
            this.nudTimerTeamC.TabIndex = 1;
            this.nudTimerTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimerTeamC.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamC.ValueChanged += new System.EventHandler(this.nudTimerTeamC_ValueChanged);
            // 
            // btnStartTimerTeamC
            // 
            this.btnStartTimerTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartTimerTeamC.Location = new System.Drawing.Point(3, 3);
            this.btnStartTimerTeamC.Name = "btnStartTimerTeamC";
            this.btnStartTimerTeamC.Size = new System.Drawing.Size(271, 55);
            this.btnStartTimerTeamC.TabIndex = 14;
            this.btnStartTimerTeamC.Text = "START";
            this.btnStartTimerTeamC.UseVisualStyleBackColor = true;
            this.btnStartTimerTeamC.Click += new System.EventHandler(this.btnStartTimerTeamC_Click);
            // 
            // tlpControlsTeamB
            // 
            this.tlpControlsTeamB.ColumnCount = 1;
            this.tlpControlsTeamB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlsTeamB.Controls.Add(this.nudTimeTeamB, 0, 3);
            this.tlpControlsTeamB.Controls.Add(this.btnJuistTeamB, 0, 2);
            this.tlpControlsTeamB.Controls.Add(this.nudTimerTeamB, 0, 1);
            this.tlpControlsTeamB.Controls.Add(this.btnStartTimerTeamB, 0, 0);
            this.tlpControlsTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlsTeamB.Location = new System.Drawing.Point(284, 143);
            this.tlpControlsTeamB.Name = "tlpControlsTeamB";
            this.tlpControlsTeamB.RowCount = 4;
            this.tlpControlsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamB.Size = new System.Drawing.Size(275, 246);
            this.tlpControlsTeamB.TabIndex = 14;
            // 
            // nudTimeTeamB
            // 
            this.nudTimeTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimeTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeTeamB.Location = new System.Drawing.Point(3, 186);
            this.nudTimeTeamB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeTeamB.Name = "nudTimeTeamB";
            this.nudTimeTeamB.Size = new System.Drawing.Size(269, 31);
            this.nudTimeTeamB.TabIndex = 16;
            this.nudTimeTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimeTeamB.ValueChanged += new System.EventHandler(this.nudTimeTeamB_ValueChanged);
            // 
            // btnJuistTeamB
            // 
            this.btnJuistTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJuistTeamB.Location = new System.Drawing.Point(3, 125);
            this.btnJuistTeamB.Name = "btnJuistTeamB";
            this.btnJuistTeamB.Size = new System.Drawing.Size(269, 55);
            this.btnJuistTeamB.TabIndex = 15;
            this.btnJuistTeamB.Text = "JUIST";
            this.btnJuistTeamB.UseVisualStyleBackColor = true;
            this.btnJuistTeamB.Click += new System.EventHandler(this.btnJuistTeamB_Click);
            // 
            // nudTimerTeamB
            // 
            this.nudTimerTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimerTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimerTeamB.Location = new System.Drawing.Point(3, 64);
            this.nudTimerTeamB.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamB.Name = "nudTimerTeamB";
            this.nudTimerTeamB.Size = new System.Drawing.Size(269, 31);
            this.nudTimerTeamB.TabIndex = 1;
            this.nudTimerTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimerTeamB.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamB.ValueChanged += new System.EventHandler(this.nudTimerTeamB_ValueChanged);
            // 
            // btnStartTimerTeamB
            // 
            this.btnStartTimerTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartTimerTeamB.Location = new System.Drawing.Point(3, 3);
            this.btnStartTimerTeamB.Name = "btnStartTimerTeamB";
            this.btnStartTimerTeamB.Size = new System.Drawing.Size(269, 55);
            this.btnStartTimerTeamB.TabIndex = 14;
            this.btnStartTimerTeamB.Text = "START";
            this.btnStartTimerTeamB.UseVisualStyleBackColor = true;
            this.btnStartTimerTeamB.Click += new System.EventHandler(this.btnStartTimerTeamB_Click);
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
            this.nudTeamC.TabIndex = 5;
            this.nudTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.nudTeamB.TabIndex = 4;
            this.nudTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeamC
            // 
            this.lblTeamC.AutoSize = true;
            this.lblTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamC.Location = new System.Drawing.Point(565, 0);
            this.lblTeamC.Name = "lblTeamC";
            this.lblTeamC.Size = new System.Drawing.Size(277, 40);
            this.lblTeamC.TabIndex = 3;
            this.lblTeamC.Text = "TEAM C";
            this.lblTeamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.Location = new System.Drawing.Point(284, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(275, 40);
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
            this.nudTeamA.Size = new System.Drawing.Size(275, 31);
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
            this.lblTeamA.Size = new System.Drawing.Size(275, 40);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "TEAM A";
            this.lblTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpControlsTeamA
            // 
            this.tlpControlsTeamA.ColumnCount = 1;
            this.tlpControlsTeamA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlsTeamA.Controls.Add(this.nudTimeTeamA, 0, 3);
            this.tlpControlsTeamA.Controls.Add(this.btnJuistTeamA, 0, 2);
            this.tlpControlsTeamA.Controls.Add(this.nudTimerTeamA, 0, 1);
            this.tlpControlsTeamA.Controls.Add(this.btnStartTimerTeamA, 0, 0);
            this.tlpControlsTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlsTeamA.Location = new System.Drawing.Point(3, 143);
            this.tlpControlsTeamA.Name = "tlpControlsTeamA";
            this.tlpControlsTeamA.RowCount = 4;
            this.tlpControlsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControlsTeamA.Size = new System.Drawing.Size(275, 246);
            this.tlpControlsTeamA.TabIndex = 13;
            // 
            // nudTimeTeamA
            // 
            this.nudTimeTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimeTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeTeamA.Location = new System.Drawing.Point(3, 186);
            this.nudTimeTeamA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimeTeamA.Name = "nudTimeTeamA";
            this.nudTimeTeamA.Size = new System.Drawing.Size(269, 31);
            this.nudTimeTeamA.TabIndex = 16;
            this.nudTimeTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimeTeamA.ValueChanged += new System.EventHandler(this.nudTimeTeamA_ValueChanged);
            // 
            // btnJuistTeamA
            // 
            this.btnJuistTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJuistTeamA.Location = new System.Drawing.Point(3, 125);
            this.btnJuistTeamA.Name = "btnJuistTeamA";
            this.btnJuistTeamA.Size = new System.Drawing.Size(269, 55);
            this.btnJuistTeamA.TabIndex = 15;
            this.btnJuistTeamA.Text = "JUIST";
            this.btnJuistTeamA.UseVisualStyleBackColor = true;
            this.btnJuistTeamA.Click += new System.EventHandler(this.btnJuistTeamA_Click);
            // 
            // nudTimerTeamA
            // 
            this.nudTimerTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimerTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimerTeamA.Location = new System.Drawing.Point(3, 64);
            this.nudTimerTeamA.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamA.Name = "nudTimerTeamA";
            this.nudTimerTeamA.Size = new System.Drawing.Size(269, 31);
            this.nudTimerTeamA.TabIndex = 1;
            this.nudTimerTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimerTeamA.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTimerTeamA.ValueChanged += new System.EventHandler(this.nudTimerTeamA_ValueChanged);
            // 
            // btnStartTimerTeamA
            // 
            this.btnStartTimerTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartTimerTeamA.Location = new System.Drawing.Point(3, 3);
            this.btnStartTimerTeamA.Name = "btnStartTimerTeamA";
            this.btnStartTimerTeamA.Size = new System.Drawing.Size(269, 55);
            this.btnStartTimerTeamA.TabIndex = 14;
            this.btnStartTimerTeamA.Text = "START";
            this.btnStartTimerTeamA.UseVisualStyleBackColor = true;
            this.btnStartTimerTeamA.Click += new System.EventHandler(this.btnStartTimerTeamA_Click);
            // 
            // rbTeamC
            // 
            this.rbTeamC.AutoSize = true;
            this.rbTeamC.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTeamC.Location = new System.Drawing.Point(565, 395);
            this.rbTeamC.Name = "rbTeamC";
            this.rbTeamC.Size = new System.Drawing.Size(277, 34);
            this.rbTeamC.TabIndex = 16;
            this.rbTeamC.UseVisualStyleBackColor = true;
            this.rbTeamC.CheckedChanged += new System.EventHandler(this.rbTeam_CheckedChanged);
            // 
            // TimerTeamA
            // 
            this.TimerTeamA.CountDirection = Videohouse.Timing.countDirection.Down;
            this.TimerTeamA.Period = Videohouse.Timing.timerPeriod.Second;
            this.TimerTeamA.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.TimerTeamA_Elapsed);
            this.TimerTeamA.Stopped += new System.EventHandler(this.TimerTeamA_Stopped);
            // 
            // TimerTeamB
            // 
            this.TimerTeamB.CountDirection = Videohouse.Timing.countDirection.Down;
            this.TimerTeamB.Period = Videohouse.Timing.timerPeriod.Second;
            this.TimerTeamB.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.TimerTeamB_Elapsed);
            this.TimerTeamB.Stopped += new System.EventHandler(this.TimerTeamB_Stopped);
            // 
            // TimerTeamC
            // 
            this.TimerTeamC.CountDirection = Videohouse.Timing.countDirection.Down;
            this.TimerTeamC.Period = Videohouse.Timing.timerPeriod.Second;
            this.TimerTeamC.Elapsed += new System.EventHandler<Videohouse.Timing.elapsedEventArgs>(this.TimerTeamC_Elapsed);
            this.TimerTeamC.Stopped += new System.EventHandler(this.TimerTeamC_Stopped);
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
            this.tlpControlsTeamC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamC)).EndInit();
            this.tlpControlsTeamB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamA)).EndInit();
            this.tlpControlsTeamA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTeamA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerTeamA)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpControlsTeamA;
        private System.Windows.Forms.NumericUpDown nudTimerTeamA;
        private System.Windows.Forms.Button btnJuistTeamA;
        private System.Windows.Forms.Button btnStartTimerTeamA;
        private System.Windows.Forms.TableLayoutPanel tlpControlsTeamC;
        private System.Windows.Forms.Button btnJuistTeamC;
        private System.Windows.Forms.NumericUpDown nudTimerTeamC;
        private System.Windows.Forms.Button btnStartTimerTeamC;
        private System.Windows.Forms.TableLayoutPanel tlpControlsTeamB;
        private System.Windows.Forms.Button btnJuistTeamB;
        private System.Windows.Forms.NumericUpDown nudTimerTeamB;
        private System.Windows.Forms.Button btnStartTimerTeamB;
        private System.Windows.Forms.NumericUpDown nudTimeTeamC;
        private System.Windows.Forms.NumericUpDown nudTimeTeamB;
        private System.Windows.Forms.NumericUpDown nudTimeTeamA;
        private Videohouse.Timing.ReferenceClock TimerTeamA;
        private Videohouse.Timing.ReferenceClock TimerTeamB;
        private Videohouse.Timing.ReferenceClock TimerTeamC;
        private System.Windows.Forms.RadioButton rbTeamB;
        private System.Windows.Forms.RadioButton rbTeamA;
        private System.Windows.Forms.RadioButton rbTeamC;
    }
}