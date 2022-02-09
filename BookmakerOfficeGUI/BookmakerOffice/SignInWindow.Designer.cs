namespace BookmakerOffice
{
    partial class SignInWindow
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
            this.l_Password = new System.Windows.Forms.Label();
            this.pb_StylizedLogo = new System.Windows.Forms.PictureBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.b_SignIn = new System.Windows.Forms.Button();
            this.l_Login = new System.Windows.Forms.Label();
            this.l_ToSignUp = new System.Windows.Forms.Label();
            this.ll_SignUp = new System.Windows.Forms.LinkLabel();
            this.tlp_Scene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StylizedLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Scene
            // 
            this.tlp_Scene.BackColor = System.Drawing.Color.White;
            this.tlp_Scene.ColumnCount = 4;
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlp_Scene.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Scene.Controls.Add(this.l_Password, 1, 5);
            this.tlp_Scene.Controls.Add(this.pb_StylizedLogo, 0, 0);
            this.tlp_Scene.Controls.Add(this.tb_Login, 1, 3);
            this.tlp_Scene.Controls.Add(this.tb_Password, 1, 6);
            this.tlp_Scene.Controls.Add(this.b_SignIn, 1, 9);
            this.tlp_Scene.Controls.Add(this.l_Login, 1, 2);
            this.tlp_Scene.Controls.Add(this.l_ToSignUp, 1, 7);
            this.tlp_Scene.Controls.Add(this.ll_SignUp, 2, 7);
            this.tlp_Scene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Scene.Location = new System.Drawing.Point(0, 0);
            this.tlp_Scene.Name = "tlp_Scene";
            this.tlp_Scene.RowCount = 11;
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlp_Scene.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlp_Scene.Size = new System.Drawing.Size(334, 361);
            this.tlp_Scene.TabIndex = 0;
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.tlp_Scene.SetColumnSpan(this.l_Password, 2);
            this.l_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Password.Location = new System.Drawing.Point(69, 214);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(193, 21);
            this.l_Password.TabIndex = 5;
            this.l_Password.Text = "Password:";
            this.l_Password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pb_StylizedLogo
            // 
            this.tlp_Scene.SetColumnSpan(this.pb_StylizedLogo, 4);
            this.pb_StylizedLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_StylizedLogo.Image = global::BookmakerOffice.Properties.Resources.StylizedLogo;
            this.pb_StylizedLogo.Location = new System.Drawing.Point(3, 3);
            this.pb_StylizedLogo.Name = "pb_StylizedLogo";
            this.pb_StylizedLogo.Size = new System.Drawing.Size(328, 142);
            this.pb_StylizedLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_StylizedLogo.TabIndex = 0;
            this.pb_StylizedLogo.TabStop = false;
            // 
            // tb_Login
            // 
            this.tlp_Scene.SetColumnSpan(this.tb_Login, 2);
            this.tb_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(69, 182);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(193, 22);
            this.tb_Login.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tlp_Scene.SetColumnSpan(this.tb_Password, 2);
            this.tb_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(69, 238);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(193, 22);
            this.tb_Password.TabIndex = 2;
            // 
            // b_SignIn
            // 
            this.tlp_Scene.SetColumnSpan(this.b_SignIn, 2);
            this.b_SignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_SignIn.Location = new System.Drawing.Point(69, 301);
            this.b_SignIn.Name = "b_SignIn";
            this.b_SignIn.Size = new System.Drawing.Size(193, 40);
            this.b_SignIn.TabIndex = 3;
            this.b_SignIn.Text = "Sign In";
            this.b_SignIn.UseVisualStyleBackColor = true;
            this.b_SignIn.Click += new System.EventHandler(this.b_SignIn_Click);
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.tlp_Scene.SetColumnSpan(this.l_Login, 2);
            this.l_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Login.Location = new System.Drawing.Point(69, 158);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(193, 21);
            this.l_Login.TabIndex = 4;
            this.l_Login.Text = "Login:";
            this.l_Login.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // l_ToSignUp
            // 
            this.l_ToSignUp.AutoSize = true;
            this.l_ToSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_ToSignUp.Location = new System.Drawing.Point(69, 267);
            this.l_ToSignUp.Name = "l_ToSignUp";
            this.l_ToSignUp.Size = new System.Drawing.Size(130, 21);
            this.l_ToSignUp.TabIndex = 6;
            this.l_ToSignUp.Text = "If you don\'t have account";
            this.l_ToSignUp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ll_SignUp
            // 
            this.ll_SignUp.AutoSize = true;
            this.ll_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ll_SignUp.Location = new System.Drawing.Point(205, 267);
            this.ll_SignUp.Name = "ll_SignUp";
            this.ll_SignUp.Size = new System.Drawing.Size(57, 21);
            this.ll_SignUp.TabIndex = 7;
            this.ll_SignUp.TabStop = true;
            this.ll_SignUp.Text = "Sign Up";
            this.ll_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_SignUp_LinkClicked);
            // 
            // SignInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(228)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.tlp_Scene);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "SignInWindow";
            this.Text = "2xbet Sign In";
            this.tlp_Scene.ResumeLayout(false);
            this.tlp_Scene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StylizedLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Scene;
        private System.Windows.Forms.PictureBox pb_StylizedLogo;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button b_SignIn;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Label l_Login;
        private System.Windows.Forms.Label l_ToSignUp;
        private System.Windows.Forms.LinkLabel ll_SignUp;
    }
}