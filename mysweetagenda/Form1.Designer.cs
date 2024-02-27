
namespace mysweetagenda
{
    partial class login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginClose = new System.Windows.Forms.Button();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.loginMinus = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.White;
            this.loginpanel.Controls.Add(this.loginMinus);
            this.loginpanel.Controls.Add(this.loginClose);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(776, 22);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseDown);
            this.loginpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseMove);
            this.loginpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseUp);
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginClose.FlatAppearance.BorderSize = 0;
            this.loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose.Location = new System.Drawing.Point(752, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(24, 22);
            this.loginClose.TabIndex = 1;
            this.loginClose.Text = "X";
            this.loginClose.UseVisualStyleBackColor = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // loginIcon
            // 
            this.loginIcon.BackColor = System.Drawing.Color.Transparent;
            this.loginIcon.BackgroundImage = global::mysweetagenda.Properties.Resources.notepad;
            this.loginIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginIcon.Location = new System.Drawing.Point(0, 0);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(23, 22);
            this.loginIcon.TabIndex = 1;
            this.loginIcon.TabStop = false;
            // 
            // loginMinus
            // 
            this.loginMinus.BackColor = System.Drawing.Color.Transparent;
            this.loginMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginMinus.FlatAppearance.BorderSize = 0;
            this.loginMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMinus.Location = new System.Drawing.Point(731, 0);
            this.loginMinus.Name = "loginMinus";
            this.loginMinus.Size = new System.Drawing.Size(24, 22);
            this.loginMinus.TabIndex = 2;
            this.loginMinus.Text = "---";
            this.loginMinus.UseVisualStyleBackColor = false;
            this.loginMinus.Click += new System.EventHandler(this.loginMinus_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginLabel.Location = new System.Drawing.Point(248, 146);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(292, 39);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "My Sweet Agenda";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginTextBox.Location = new System.Drawing.Point(298, 256);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(192, 26);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginUsernameLabel
            // 
            this.LoginUsernameLabel.AutoSize = true;
            this.LoginUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginUsernameLabel.Location = new System.Drawing.Point(348, 224);
            this.LoginUsernameLabel.Name = "LoginUsernameLabel";
            this.LoginUsernameLabel.Size = new System.Drawing.Size(93, 20);
            this.LoginUsernameLabel.TabIndex = 4;
            this.LoginUsernameLabel.Text = "Kullanıcı Adı";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.Location = new System.Drawing.Point(352, 310);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(89, 29);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Giriş";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            this.loginBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseMove);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(776, 517);
            this.ControlBox = false;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.LoginUsernameLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Sweet Agenda";
            this.Load += new System.EventHandler(this.login_Load);
            this.loginpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginClose;
        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.Button loginMinus;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label LoginUsernameLabel;
        private System.Windows.Forms.Button loginBtn;
    }
}

