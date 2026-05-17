namespace demochka
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonGuest = new System.Windows.Forms.Button();
            this.buttoAuth = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelLog = new System.Windows.Forms.Label();
            this.MainNameLabel = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuest
            // 
            this.buttonGuest.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGuest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuest.Location = new System.Drawing.Point(421, 280);
            this.buttonGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(135, 46);
            this.buttonGuest.TabIndex = 15;
            this.buttonGuest.Text = "Гость";
            this.buttonGuest.UseVisualStyleBackColor = false;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // buttoAuth
            // 
            this.buttoAuth.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttoAuth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoAuth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttoAuth.Location = new System.Drawing.Point(225, 280);
            this.buttoAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoAuth.Name = "buttoAuth";
            this.buttoAuth.Size = new System.Drawing.Size(135, 46);
            this.buttoAuth.TabIndex = 14;
            this.buttoAuth.Text = "Войти";
            this.buttoAuth.UseVisualStyleBackColor = false;
            this.buttoAuth.Click += new System.EventHandler(this.buttoAuth_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(278, 204);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(221, 26);
            this.textBoxPassword.TabIndex = 13;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(278, 150);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(223, 26);
            this.textBoxLogin.TabIndex = 12;
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPass.Location = new System.Drawing.Point(129, 194);
            this.LabelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(115, 36);
            this.LabelPass.TabIndex = 11;
            this.LabelPass.Text = "Пароль";
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLog.Location = new System.Drawing.Point(129, 150);
            this.LabelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(99, 36);
            this.LabelLog.TabIndex = 10;
            this.LabelLog.Text = "Логин";
            // 
            // MainNameLabel
            // 
            this.MainNameLabel.AutoSize = true;
            this.MainNameLabel.Font = new System.Drawing.Font("Times New Roman", 25.25F);
            this.MainNameLabel.Location = new System.Drawing.Point(248, 30);
            this.MainNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainNameLabel.Name = "MainNameLabel";
            this.MainNameLabel.Size = new System.Drawing.Size(341, 57);
            this.MainNameLabel.TabIndex = 9;
            this.MainNameLabel.Text = "ООО «Обувь» ";
            // 
            // Picture
            // 
            this.Picture.Image = global::demochka.Properties.Resources.Icon;
            this.Picture.Location = new System.Drawing.Point(0, 2);
            this.Picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(144, 85);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 8;
            this.Picture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 427);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.buttoAuth);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.MainNameLabel);
            this.Controls.Add(this.Picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuest;
        private System.Windows.Forms.Button buttoAuth;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Label MainNameLabel;
        private System.Windows.Forms.PictureBox Picture;
    }
}

