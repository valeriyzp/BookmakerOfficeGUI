namespace BookmakerOffice
{
    partial class AdminWindow
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
            this.tlp_Scene = new System.Windows.Forms.TableLayoutPanel();
            this.l_AdminName = new System.Windows.Forms.Label();
            this.l_SignOut = new System.Windows.Forms.LinkLabel();
            this.tc_AdminMenu = new System.Windows.Forms.TabControl();
            this.tp_NewMatch = new System.Windows.Forms.TabPage();
            this.tlp_NewMatch = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Team1 = new System.Windows.Forms.TextBox();
            this.tb_Team2 = new System.Windows.Forms.TextBox();
            this.l_Team1 = new System.Windows.Forms.Label();
            this.l_Team2 = new System.Windows.Forms.Label();
            this.l_W2 = new System.Windows.Forms.Label();
            this.l_D = new System.Windows.Forms.Label();
            this.l_W1 = new System.Windows.Forms.Label();
            this.nud_W1 = new System.Windows.Forms.NumericUpDown();
            this.nud_T0 = new System.Windows.Forms.NumericUpDown();
            this.nud_T1 = new System.Windows.Forms.NumericUpDown();
            this.nud_T2 = new System.Windows.Forms.NumericUpDown();
            this.nud_T4Plus = new System.Windows.Forms.NumericUpDown();
            this.l_T0 = new System.Windows.Forms.Label();
            this.l_T1 = new System.Windows.Forms.Label();
            this.l_T2 = new System.Windows.Forms.Label();
            this.l_T3 = new System.Windows.Forms.Label();
            this.l_T4Plus = new System.Windows.Forms.Label();
            this.b_AddMatch = new System.Windows.Forms.Button();
            this.nud_T3 = new System.Windows.Forms.NumericUpDown();
            this.nud_D = new System.Windows.Forms.NumericUpDown();
            this.nud_W2 = new System.Windows.Forms.NumericUpDown();
            this.l_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tp_UpdateMatchResult = new System.Windows.Forms.TabPage();
            this.tlp_UpdateMatches = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Matches = new System.Windows.Forms.DataGridView();
            this.MatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_FirstTeam = new System.Windows.Forms.Label();
            this.l_SecondTeam = new System.Windows.Forms.Label();
            this.nud_FirstTeamGoals = new System.Windows.Forms.NumericUpDown();
            this.nud_SecondTeamGoals = new System.Windows.Forms.NumericUpDown();
            this.b_Accept = new System.Windows.Forms.Button();
            this.tlp_Scene.SuspendLayout();
            this.tc_AdminMenu.SuspendLayout();
            this.tp_NewMatch.SuspendLayout();
            this.tlp_NewMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_W1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T4Plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_W2)).BeginInit();
            this.tp_UpdateMatchResult.SuspendLayout();
            this.tlp_UpdateMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FirstTeamGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SecondTeamGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Scene
            // 
            this.tlp_Scene.ColumnCount = 3;
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlp_Scene.Controls.Add(this.l_AdminName, 1, 0);
            this.tlp_Scene.Controls.Add(this.l_SignOut, 1, 1);
            this.tlp_Scene.Controls.Add(this.tc_AdminMenu, 1, 2);
            this.tlp_Scene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Scene.Location = new System.Drawing.Point(0, 0);
            this.tlp_Scene.Name = "tlp_Scene";
            this.tlp_Scene.RowCount = 3;
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_Scene.Size = new System.Drawing.Size(704, 441);
            this.tlp_Scene.TabIndex = 0;
            // 
            // l_AdminName
            // 
            this.l_AdminName.AutoSize = true;
            this.l_AdminName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_AdminName.Location = new System.Drawing.Point(10, 0);
            this.l_AdminName.Name = "l_AdminName";
            this.l_AdminName.Size = new System.Drawing.Size(683, 22);
            this.l_AdminName.TabIndex = 0;
            this.l_AdminName.Text = "admin";
            this.l_AdminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_SignOut
            // 
            this.l_SignOut.AutoSize = true;
            this.l_SignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_SignOut.Location = new System.Drawing.Point(10, 22);
            this.l_SignOut.Name = "l_SignOut";
            this.l_SignOut.Size = new System.Drawing.Size(683, 22);
            this.l_SignOut.TabIndex = 1;
            this.l_SignOut.TabStop = true;
            this.l_SignOut.Text = "Sign Out";
            this.l_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_SignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_SignOut_LinkClicked);
            // 
            // tc_AdminMenu
            // 
            this.tc_AdminMenu.Controls.Add(this.tp_NewMatch);
            this.tc_AdminMenu.Controls.Add(this.tp_UpdateMatchResult);
            this.tc_AdminMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_AdminMenu.Location = new System.Drawing.Point(10, 47);
            this.tc_AdminMenu.Name = "tc_AdminMenu";
            this.tc_AdminMenu.SelectedIndex = 0;
            this.tc_AdminMenu.Size = new System.Drawing.Size(683, 391);
            this.tc_AdminMenu.TabIndex = 2;
            // 
            // tp_NewMatch
            // 
            this.tp_NewMatch.Controls.Add(this.tlp_NewMatch);
            this.tp_NewMatch.Location = new System.Drawing.Point(4, 22);
            this.tp_NewMatch.Name = "tp_NewMatch";
            this.tp_NewMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tp_NewMatch.Size = new System.Drawing.Size(675, 365);
            this.tp_NewMatch.TabIndex = 0;
            this.tp_NewMatch.Text = "New match";
            this.tp_NewMatch.UseVisualStyleBackColor = true;
            // 
            // tlp_NewMatch
            // 
            this.tlp_NewMatch.ColumnCount = 16;
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691313F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.692236F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691313F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.692236F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691313F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.692236F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691313F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.692236F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691313F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.692236F));
            this.tlp_NewMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.847042F));
            this.tlp_NewMatch.Controls.Add(this.tb_Team1, 1, 2);
            this.tlp_NewMatch.Controls.Add(this.tb_Team2, 9, 2);
            this.tlp_NewMatch.Controls.Add(this.l_Team1, 1, 1);
            this.tlp_NewMatch.Controls.Add(this.l_Team2, 9, 1);
            this.tlp_NewMatch.Controls.Add(this.l_W2, 10, 7);
            this.tlp_NewMatch.Controls.Add(this.l_D, 7, 7);
            this.tlp_NewMatch.Controls.Add(this.l_W1, 4, 7);
            this.tlp_NewMatch.Controls.Add(this.nud_W1, 5, 7);
            this.tlp_NewMatch.Controls.Add(this.nud_T0, 2, 9);
            this.tlp_NewMatch.Controls.Add(this.nud_T1, 5, 9);
            this.tlp_NewMatch.Controls.Add(this.nud_T2, 8, 9);
            this.tlp_NewMatch.Controls.Add(this.nud_T4Plus, 14, 9);
            this.tlp_NewMatch.Controls.Add(this.l_T0, 1, 9);
            this.tlp_NewMatch.Controls.Add(this.l_T1, 4, 9);
            this.tlp_NewMatch.Controls.Add(this.l_T2, 7, 9);
            this.tlp_NewMatch.Controls.Add(this.l_T3, 10, 9);
            this.tlp_NewMatch.Controls.Add(this.l_T4Plus, 13, 9);
            this.tlp_NewMatch.Controls.Add(this.b_AddMatch, 6, 11);
            this.tlp_NewMatch.Controls.Add(this.nud_T3, 11, 9);
            this.tlp_NewMatch.Controls.Add(this.nud_D, 8, 7);
            this.tlp_NewMatch.Controls.Add(this.nud_W2, 11, 7);
            this.tlp_NewMatch.Controls.Add(this.l_Date, 6, 4);
            this.tlp_NewMatch.Controls.Add(this.dtp_Date, 6, 5);
            this.tlp_NewMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_NewMatch.Location = new System.Drawing.Point(3, 3);
            this.tlp_NewMatch.Name = "tlp_NewMatch";
            this.tlp_NewMatch.RowCount = 13;
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.631509F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894528F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894528F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263019F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894528F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894528F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.26565F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15755F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263019F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15755F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894528F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15755F));
            this.tlp_NewMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.631509F));
            this.tlp_NewMatch.Size = new System.Drawing.Size(669, 359);
            this.tlp_NewMatch.TabIndex = 0;
            // 
            // tb_Team1
            // 
            this.tlp_NewMatch.SetColumnSpan(this.tb_Team1, 6);
            this.tb_Team1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Team1.Location = new System.Drawing.Point(28, 40);
            this.tb_Team1.Name = "tb_Team1";
            this.tb_Team1.Size = new System.Drawing.Size(248, 26);
            this.tb_Team1.TabIndex = 0;
            this.tb_Team1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Team2
            // 
            this.tlp_NewMatch.SetColumnSpan(this.tb_Team2, 6);
            this.tb_Team2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Team2.Location = new System.Drawing.Point(384, 40);
            this.tb_Team2.Name = "tb_Team2";
            this.tb_Team2.Size = new System.Drawing.Size(248, 26);
            this.tb_Team2.TabIndex = 1;
            // 
            // l_Team1
            // 
            this.l_Team1.AutoSize = true;
            this.tlp_NewMatch.SetColumnSpan(this.l_Team1, 6);
            this.l_Team1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Team1.Location = new System.Drawing.Point(28, 9);
            this.l_Team1.Name = "l_Team1";
            this.l_Team1.Size = new System.Drawing.Size(248, 28);
            this.l_Team1.TabIndex = 2;
            this.l_Team1.Text = "Team 1:";
            this.l_Team1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // l_Team2
            // 
            this.l_Team2.AutoSize = true;
            this.tlp_NewMatch.SetColumnSpan(this.l_Team2, 6);
            this.l_Team2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Team2.Location = new System.Drawing.Point(384, 9);
            this.l_Team2.Name = "l_Team2";
            this.l_Team2.Size = new System.Drawing.Size(248, 28);
            this.l_Team2.TabIndex = 3;
            this.l_Team2.Text = "Team 2:";
            this.l_Team2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // l_W2
            // 
            this.l_W2.AutoSize = true;
            this.l_W2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_W2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_W2.Location = new System.Drawing.Point(409, 157);
            this.l_W2.Name = "l_W2";
            this.l_W2.Size = new System.Drawing.Size(32, 47);
            this.l_W2.TabIndex = 7;
            this.l_W2.Text = "W2";
            this.l_W2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_D
            // 
            this.l_D.AutoSize = true;
            this.l_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_D.Location = new System.Drawing.Point(282, 157);
            this.l_D.Name = "l_D";
            this.l_D.Size = new System.Drawing.Size(32, 47);
            this.l_D.TabIndex = 6;
            this.l_D.Text = "D";
            this.l_D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_W1
            // 
            this.l_W1.AutoSize = true;
            this.l_W1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_W1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_W1.Location = new System.Drawing.Point(155, 157);
            this.l_W1.Name = "l_W1";
            this.l_W1.Size = new System.Drawing.Size(32, 47);
            this.l_W1.TabIndex = 4;
            this.l_W1.Text = "W1";
            this.l_W1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_W1
            // 
            this.nud_W1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_W1.DecimalPlaces = 2;
            this.nud_W1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_W1.Location = new System.Drawing.Point(193, 170);
            this.nud_W1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_W1.Name = "nud_W1";
            this.nud_W1.Size = new System.Drawing.Size(58, 21);
            this.nud_W1.TabIndex = 5;
            this.nud_W1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_T0
            // 
            this.nud_T0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_T0.DecimalPlaces = 2;
            this.nud_T0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_T0.Location = new System.Drawing.Point(66, 235);
            this.nud_T0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_T0.Name = "nud_T0";
            this.nud_T0.Size = new System.Drawing.Size(58, 21);
            this.nud_T0.TabIndex = 8;
            this.nud_T0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_T1
            // 
            this.nud_T1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_T1.DecimalPlaces = 2;
            this.nud_T1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_T1.Location = new System.Drawing.Point(193, 235);
            this.nud_T1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_T1.Name = "nud_T1";
            this.nud_T1.Size = new System.Drawing.Size(58, 21);
            this.nud_T1.TabIndex = 9;
            this.nud_T1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_T2
            // 
            this.nud_T2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_T2.DecimalPlaces = 2;
            this.nud_T2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_T2.Location = new System.Drawing.Point(320, 235);
            this.nud_T2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_T2.Name = "nud_T2";
            this.nud_T2.Size = new System.Drawing.Size(58, 21);
            this.nud_T2.TabIndex = 10;
            this.nud_T2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_T4Plus
            // 
            this.nud_T4Plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_T4Plus.DecimalPlaces = 2;
            this.nud_T4Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_T4Plus.Location = new System.Drawing.Point(574, 235);
            this.nud_T4Plus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_T4Plus.Name = "nud_T4Plus";
            this.nud_T4Plus.Size = new System.Drawing.Size(58, 21);
            this.nud_T4Plus.TabIndex = 12;
            this.nud_T4Plus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // l_T0
            // 
            this.l_T0.AutoSize = true;
            this.l_T0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_T0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_T0.Location = new System.Drawing.Point(28, 222);
            this.l_T0.Name = "l_T0";
            this.l_T0.Size = new System.Drawing.Size(32, 47);
            this.l_T0.TabIndex = 13;
            this.l_T0.Text = "T0";
            this.l_T0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_T1
            // 
            this.l_T1.AutoSize = true;
            this.l_T1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_T1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_T1.Location = new System.Drawing.Point(155, 222);
            this.l_T1.Name = "l_T1";
            this.l_T1.Size = new System.Drawing.Size(32, 47);
            this.l_T1.TabIndex = 14;
            this.l_T1.Text = "T1";
            this.l_T1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_T2
            // 
            this.l_T2.AutoSize = true;
            this.l_T2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_T2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_T2.Location = new System.Drawing.Point(282, 222);
            this.l_T2.Name = "l_T2";
            this.l_T2.Size = new System.Drawing.Size(32, 47);
            this.l_T2.TabIndex = 15;
            this.l_T2.Text = "T2";
            this.l_T2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_T3
            // 
            this.l_T3.AutoSize = true;
            this.l_T3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_T3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_T3.Location = new System.Drawing.Point(409, 222);
            this.l_T3.Name = "l_T3";
            this.l_T3.Size = new System.Drawing.Size(32, 47);
            this.l_T3.TabIndex = 16;
            this.l_T3.Text = "T3";
            this.l_T3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_T4Plus
            // 
            this.l_T4Plus.AutoSize = true;
            this.l_T4Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_T4Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_T4Plus.Location = new System.Drawing.Point(536, 222);
            this.l_T4Plus.Name = "l_T4Plus";
            this.l_T4Plus.Size = new System.Drawing.Size(32, 47);
            this.l_T4Plus.TabIndex = 17;
            this.l_T4Plus.Text = "T4+";
            this.l_T4Plus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_AddMatch
            // 
            this.tlp_NewMatch.SetColumnSpan(this.b_AddMatch, 4);
            this.b_AddMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_AddMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddMatch.Location = new System.Drawing.Point(257, 300);
            this.b_AddMatch.Name = "b_AddMatch";
            this.b_AddMatch.Size = new System.Drawing.Size(146, 41);
            this.b_AddMatch.TabIndex = 18;
            this.b_AddMatch.Text = "Add match";
            this.b_AddMatch.UseVisualStyleBackColor = true;
            this.b_AddMatch.Click += new System.EventHandler(this.B_AddMatch_Click);
            // 
            // nud_T3
            // 
            this.nud_T3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_T3.DecimalPlaces = 2;
            this.nud_T3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_T3.Location = new System.Drawing.Point(447, 235);
            this.nud_T3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_T3.Name = "nud_T3";
            this.nud_T3.Size = new System.Drawing.Size(58, 21);
            this.nud_T3.TabIndex = 11;
            this.nud_T3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_D
            // 
            this.nud_D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_D.DecimalPlaces = 2;
            this.nud_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_D.Location = new System.Drawing.Point(320, 170);
            this.nud_D.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_D.Name = "nud_D";
            this.nud_D.Size = new System.Drawing.Size(58, 21);
            this.nud_D.TabIndex = 19;
            this.nud_D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_W2
            // 
            this.nud_W2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_W2.DecimalPlaces = 2;
            this.nud_W2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_W2.Location = new System.Drawing.Point(447, 170);
            this.nud_W2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_W2.Name = "nud_W2";
            this.nud_W2.Size = new System.Drawing.Size(58, 21);
            this.nud_W2.TabIndex = 20;
            this.nud_W2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.tlp_NewMatch.SetColumnSpan(this.l_Date, 4);
            this.l_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Date.Location = new System.Drawing.Point(257, 83);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(146, 28);
            this.l_Date.TabIndex = 21;
            this.l_Date.Text = "Date:";
            this.l_Date.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlp_NewMatch.SetColumnSpan(this.dtp_Date, 4);
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(257, 114);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(146, 20);
            this.dtp_Date.TabIndex = 22;
            // 
            // tp_UpdateMatchResult
            // 
            this.tp_UpdateMatchResult.Controls.Add(this.tlp_UpdateMatches);
            this.tp_UpdateMatchResult.Location = new System.Drawing.Point(4, 22);
            this.tp_UpdateMatchResult.Name = "tp_UpdateMatchResult";
            this.tp_UpdateMatchResult.Padding = new System.Windows.Forms.Padding(3);
            this.tp_UpdateMatchResult.Size = new System.Drawing.Size(675, 365);
            this.tp_UpdateMatchResult.TabIndex = 1;
            this.tp_UpdateMatchResult.Text = "Update match results";
            this.tp_UpdateMatchResult.UseVisualStyleBackColor = true;
            // 
            // tlp_UpdateMatches
            // 
            this.tlp_UpdateMatches.ColumnCount = 12;
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_UpdateMatches.Controls.Add(this.dgv_Matches, 0, 0);
            this.tlp_UpdateMatches.Controls.Add(this.l_FirstTeam, 2, 1);
            this.tlp_UpdateMatches.Controls.Add(this.l_SecondTeam, 7, 1);
            this.tlp_UpdateMatches.Controls.Add(this.nud_FirstTeamGoals, 3, 2);
            this.tlp_UpdateMatches.Controls.Add(this.nud_SecondTeamGoals, 8, 2);
            this.tlp_UpdateMatches.Controls.Add(this.b_Accept, 5, 4);
            this.tlp_UpdateMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UpdateMatches.Location = new System.Drawing.Point(3, 3);
            this.tlp_UpdateMatches.Name = "tlp_UpdateMatches";
            this.tlp_UpdateMatches.RowCount = 6;
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlp_UpdateMatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UpdateMatches.Size = new System.Drawing.Size(669, 359);
            this.tlp_UpdateMatches.TabIndex = 0;
            // 
            // dgv_Matches
            // 
            this.dgv_Matches.AllowUserToAddRows = false;
            this.dgv_Matches.AllowUserToDeleteRows = false;
            this.dgv_Matches.AllowUserToResizeRows = false;
            this.dgv_Matches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Matches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchNumber,
            this.Date,
            this.Match});
            this.dgv_Matches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Matches.Location = new System.Drawing.Point(3, 3);
            this.dgv_Matches.MultiSelect = false;
            this.dgv_Matches.Name = "dgv_Matches";
            this.tlp_UpdateMatches.SetRowSpan(this.dgv_Matches, 6);
            this.dgv_Matches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Matches.Size = new System.Drawing.Size(315, 353);
            this.dgv_Matches.TabIndex = 0;
            this.dgv_Matches.SelectionChanged += new System.EventHandler(this.Dgv_Matches_SelectionChanged);
            // 
            // MatchNumber
            // 
            this.MatchNumber.HeaderText = "№";
            this.MatchNumber.Name = "MatchNumber";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Match
            // 
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            // 
            // l_FirstTeam
            // 
            this.l_FirstTeam.AutoSize = true;
            this.tlp_UpdateMatches.SetColumnSpan(this.l_FirstTeam, 5);
            this.l_FirstTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_FirstTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_FirstTeam.Location = new System.Drawing.Point(337, 89);
            this.l_FirstTeam.Name = "l_FirstTeam";
            this.l_FirstTeam.Size = new System.Drawing.Size(159, 35);
            this.l_FirstTeam.TabIndex = 1;
            this.l_FirstTeam.Text = "Liverpool";
            this.l_FirstTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_SecondTeam
            // 
            this.l_SecondTeam.AutoSize = true;
            this.tlp_UpdateMatches.SetColumnSpan(this.l_SecondTeam, 5);
            this.l_SecondTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SecondTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_SecondTeam.Location = new System.Drawing.Point(502, 89);
            this.l_SecondTeam.Name = "l_SecondTeam";
            this.l_SecondTeam.Size = new System.Drawing.Size(164, 35);
            this.l_SecondTeam.TabIndex = 2;
            this.l_SecondTeam.Text = "Chelsea";
            this.l_SecondTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_FirstTeamGoals
            // 
            this.tlp_UpdateMatches.SetColumnSpan(this.nud_FirstTeamGoals, 3);
            this.nud_FirstTeamGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_FirstTeamGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_FirstTeamGoals.Location = new System.Drawing.Point(370, 127);
            this.nud_FirstTeamGoals.Name = "nud_FirstTeamGoals";
            this.nud_FirstTeamGoals.Size = new System.Drawing.Size(93, 31);
            this.nud_FirstTeamGoals.TabIndex = 3;
            this.nud_FirstTeamGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_SecondTeamGoals
            // 
            this.tlp_UpdateMatches.SetColumnSpan(this.nud_SecondTeamGoals, 3);
            this.nud_SecondTeamGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_SecondTeamGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_SecondTeamGoals.Location = new System.Drawing.Point(535, 127);
            this.nud_SecondTeamGoals.Name = "nud_SecondTeamGoals";
            this.nud_SecondTeamGoals.Size = new System.Drawing.Size(93, 31);
            this.nud_SecondTeamGoals.TabIndex = 4;
            this.nud_SecondTeamGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_Accept
            // 
            this.tlp_UpdateMatches.SetColumnSpan(this.b_Accept, 4);
            this.b_Accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Accept.Location = new System.Drawing.Point(436, 223);
            this.b_Accept.Name = "b_Accept";
            this.b_Accept.Size = new System.Drawing.Size(126, 40);
            this.b_Accept.TabIndex = 5;
            this.b_Accept.Text = "Accept";
            this.b_Accept.UseVisualStyleBackColor = true;
            this.b_Accept.Click += new System.EventHandler(this.B_Accept_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tlp_Scene);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "AdminWindow";
            this.Text = "2xbet administrator";
            this.tlp_Scene.ResumeLayout(false);
            this.tlp_Scene.PerformLayout();
            this.tc_AdminMenu.ResumeLayout(false);
            this.tp_NewMatch.ResumeLayout(false);
            this.tlp_NewMatch.ResumeLayout(false);
            this.tlp_NewMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_W1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T4Plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_T3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_W2)).EndInit();
            this.tp_UpdateMatchResult.ResumeLayout(false);
            this.tlp_UpdateMatches.ResumeLayout(false);
            this.tlp_UpdateMatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FirstTeamGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SecondTeamGoals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Scene;
        private System.Windows.Forms.Label l_AdminName;
        private System.Windows.Forms.LinkLabel l_SignOut;
        private System.Windows.Forms.TabControl tc_AdminMenu;
        private System.Windows.Forms.TabPage tp_NewMatch;
        private System.Windows.Forms.TabPage tp_UpdateMatchResult;
        private System.Windows.Forms.TableLayoutPanel tlp_NewMatch;
        private System.Windows.Forms.TextBox tb_Team1;
        private System.Windows.Forms.TextBox tb_Team2;
        private System.Windows.Forms.Label l_Team1;
        private System.Windows.Forms.Label l_Team2;
        private System.Windows.Forms.Label l_W2;
        private System.Windows.Forms.Label l_D;
        private System.Windows.Forms.Label l_W1;
        private System.Windows.Forms.NumericUpDown nud_W1;
        private System.Windows.Forms.NumericUpDown nud_T0;
        private System.Windows.Forms.NumericUpDown nud_T1;
        private System.Windows.Forms.NumericUpDown nud_T2;
        private System.Windows.Forms.NumericUpDown nud_T3;
        private System.Windows.Forms.NumericUpDown nud_T4Plus;
        private System.Windows.Forms.Label l_T0;
        private System.Windows.Forms.Label l_T1;
        private System.Windows.Forms.Label l_T2;
        private System.Windows.Forms.Label l_T3;
        private System.Windows.Forms.Label l_T4Plus;
        private System.Windows.Forms.Button b_AddMatch;
        private System.Windows.Forms.NumericUpDown nud_D;
        private System.Windows.Forms.NumericUpDown nud_W2;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TableLayoutPanel tlp_UpdateMatches;
        private System.Windows.Forms.DataGridView dgv_Matches;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Match;
        private System.Windows.Forms.Label l_FirstTeam;
        private System.Windows.Forms.Label l_SecondTeam;
        private System.Windows.Forms.NumericUpDown nud_FirstTeamGoals;
        private System.Windows.Forms.NumericUpDown nud_SecondTeamGoals;
        private System.Windows.Forms.Button b_Accept;
    }
}