namespace Music_App
{
    partial class Auth
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label name_userLabel;
            System.Windows.Forms.Label PasswordLabelText;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.WelcomeLabelAuth = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_timer = new System.Windows.Forms.Label();
            this.label_timer_expl = new System.Windows.Forms.Label();
            this.lblQuestionNewUser = new System.Windows.Forms.Label();
            this.lblNewUserRegistration = new System.Windows.Forms.Label();
            this.GroupBoxAuth = new System.Windows.Forms.GroupBox();
            this.GroupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.btnCancelRegistration = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.PasswordOtherAdminTextBox_Registration = new System.Windows.Forms.TextBox();
            this.RepeatPassTextBox_Registration = new System.Windows.Forms.TextBox();
            this.PasswordTextBox_Registration = new System.Windows.Forms.TextBox();
            this.LoginTextBox_Registration = new System.Windows.Forms.TextBox();
            this.NewAdmin_CheckBox = new System.Windows.Forms.CheckBox();
            this.lblRepeatPassword_NewUser = new System.Windows.Forms.Label();
            this.lblPasswordOtherAdmin_NewUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassword_NewUser = new System.Windows.Forms.Label();
            this.lblNick_NewUser = new System.Windows.Forms.Label();
            name_userLabel = new System.Windows.Forms.Label();
            PasswordLabelText = new System.Windows.Forms.Label();
            this.GroupBoxAuth.SuspendLayout();
            this.GroupBoxRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_userLabel
            // 
            name_userLabel.AutoSize = true;
            name_userLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_userLabel.ForeColor = System.Drawing.Color.Black;
            name_userLabel.Location = new System.Drawing.Point(97, 62);
            name_userLabel.Name = "name_userLabel";
            name_userLabel.Size = new System.Drawing.Size(61, 21);
            name_userLabel.TabIndex = 1;
            name_userLabel.Text = "Логин";
            // 
            // PasswordLabelText
            // 
            PasswordLabelText.AutoSize = true;
            PasswordLabelText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PasswordLabelText.ForeColor = System.Drawing.Color.Black;
            PasswordLabelText.Location = new System.Drawing.Point(97, 120);
            PasswordLabelText.Name = "PasswordLabelText";
            PasswordLabelText.Size = new System.Drawing.Size(69, 21);
            PasswordLabelText.TabIndex = 7;
            PasswordLabelText.Text = "Пароль";
            // 
            // WelcomeLabelAuth
            // 
            this.WelcomeLabelAuth.AutoSize = true;
            this.WelcomeLabelAuth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabelAuth.ForeColor = System.Drawing.Color.Black;
            this.WelcomeLabelAuth.Location = new System.Drawing.Point(53, 22);
            this.WelcomeLabelAuth.Name = "WelcomeLabelAuth";
            this.WelcomeLabelAuth.Size = new System.Drawing.Size(158, 15);
            this.WelcomeLabelAuth.TabIndex = 3;
            this.WelcomeLabelAuth.Text = "Пожалуйста,авторизуйтесь";
            this.WelcomeLabelAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabelAuth.UseMnemonic = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.White;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(68, 195);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 37);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.White;
            this.LoginText.ForeColor = System.Drawing.Color.Black;
            this.LoginText.Location = new System.Drawing.Point(3, 86);
            this.LoginText.MaxLength = 30;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(264, 29);
            this.LoginText.TabIndex = 0;
            // 
            // PassText
            // 
            this.PassText.BackColor = System.Drawing.Color.White;
            this.PassText.ForeColor = System.Drawing.Color.Black;
            this.PassText.Location = new System.Drawing.Point(3, 144);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(264, 29);
            this.PassText.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.BackColor = System.Drawing.Color.White;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_timer.ForeColor = System.Drawing.Color.Black;
            this.label_timer.Location = new System.Drawing.Point(224, 178);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(19, 13);
            this.label_timer.TabIndex = 8;
            this.label_timer.Text = "30";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timer.Visible = false;
            // 
            // label_timer_expl
            // 
            this.label_timer_expl.AutoSize = true;
            this.label_timer_expl.BackColor = System.Drawing.Color.White;
            this.label_timer_expl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_timer_expl.ForeColor = System.Drawing.Color.Black;
            this.label_timer_expl.Location = new System.Drawing.Point(22, 177);
            this.label_timer_expl.Name = "label_timer_expl";
            this.label_timer_expl.Size = new System.Drawing.Size(205, 13);
            this.label_timer_expl.TabIndex = 9;
            this.label_timer_expl.Text = "Повторный вход будет доступен через:";
            this.label_timer_expl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timer_expl.Visible = false;
            // 
            // lblQuestionNewUser
            // 
            this.lblQuestionNewUser.AutoSize = true;
            this.lblQuestionNewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionNewUser.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionNewUser.Location = new System.Drawing.Point(2, 43);
            this.lblQuestionNewUser.Name = "lblQuestionNewUser";
            this.lblQuestionNewUser.Size = new System.Drawing.Size(145, 15);
            this.lblQuestionNewUser.TabIndex = 10;
            this.lblQuestionNewUser.Text = "Вы новый пользователь?";
            // 
            // lblNewUserRegistration
            // 
            this.lblNewUserRegistration.AutoSize = true;
            this.lblNewUserRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewUserRegistration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewUserRegistration.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNewUserRegistration.Location = new System.Drawing.Point(147, 43);
            this.lblNewUserRegistration.Name = "lblNewUserRegistration";
            this.lblNewUserRegistration.Size = new System.Drawing.Size(118, 15);
            this.lblNewUserRegistration.TabIndex = 11;
            this.lblNewUserRegistration.Text = "Зарегистрируйтесь!";
            this.lblNewUserRegistration.Click += new System.EventHandler(this.lblNewUserRegistration_Click);
            // 
            // GroupBoxAuth
            // 
            this.GroupBoxAuth.Controls.Add(this.PassText);
            this.GroupBoxAuth.Controls.Add(this.lblNewUserRegistration);
            this.GroupBoxAuth.Controls.Add(name_userLabel);
            this.GroupBoxAuth.Controls.Add(this.lblQuestionNewUser);
            this.GroupBoxAuth.Controls.Add(this.WelcomeLabelAuth);
            this.GroupBoxAuth.Controls.Add(this.label_timer_expl);
            this.GroupBoxAuth.Controls.Add(this.btnEnter);
            this.GroupBoxAuth.Controls.Add(this.label_timer);
            this.GroupBoxAuth.Controls.Add(this.LoginText);
            this.GroupBoxAuth.Controls.Add(PasswordLabelText);
            this.GroupBoxAuth.Location = new System.Drawing.Point(1, -8);
            this.GroupBoxAuth.Name = "GroupBoxAuth";
            this.GroupBoxAuth.Size = new System.Drawing.Size(267, 237);
            this.GroupBoxAuth.TabIndex = 12;
            this.GroupBoxAuth.TabStop = false;
            // 
            // GroupBoxRegistration
            // 
            this.GroupBoxRegistration.Controls.Add(this.btnCancelRegistration);
            this.GroupBoxRegistration.Controls.Add(this.btnAddNewUser);
            this.GroupBoxRegistration.Controls.Add(this.PasswordOtherAdminTextBox_Registration);
            this.GroupBoxRegistration.Controls.Add(this.RepeatPassTextBox_Registration);
            this.GroupBoxRegistration.Controls.Add(this.PasswordTextBox_Registration);
            this.GroupBoxRegistration.Controls.Add(this.LoginTextBox_Registration);
            this.GroupBoxRegistration.Controls.Add(this.NewAdmin_CheckBox);
            this.GroupBoxRegistration.Controls.Add(this.lblRepeatPassword_NewUser);
            this.GroupBoxRegistration.Controls.Add(this.lblPasswordOtherAdmin_NewUser);
            this.GroupBoxRegistration.Controls.Add(this.label4);
            this.GroupBoxRegistration.Controls.Add(this.lblPassword_NewUser);
            this.GroupBoxRegistration.Controls.Add(this.lblNick_NewUser);
            this.GroupBoxRegistration.Location = new System.Drawing.Point(1, -8);
            this.GroupBoxRegistration.Name = "GroupBoxRegistration";
            this.GroupBoxRegistration.Size = new System.Drawing.Size(267, 240);
            this.GroupBoxRegistration.TabIndex = 12;
            this.GroupBoxRegistration.TabStop = false;
            this.GroupBoxRegistration.Visible = false;
            // 
            // btnCancelRegistration
            // 
            this.btnCancelRegistration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnCancelRegistration.Location = new System.Drawing.Point(28, 203);
            this.btnCancelRegistration.Name = "btnCancelRegistration";
            this.btnCancelRegistration.Size = new System.Drawing.Size(94, 29);
            this.btnCancelRegistration.TabIndex = 23;
            this.btnCancelRegistration.Text = "Отмена";
            this.btnCancelRegistration.UseVisualStyleBackColor = true;
            this.btnCancelRegistration.Click += new System.EventHandler(this.btnCancelRegistration_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Location = new System.Drawing.Point(150, 203);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(94, 29);
            this.btnAddNewUser.TabIndex = 23;
            this.btnAddNewUser.Text = "Готово!";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // PasswordOtherAdminTextBox_Registration
            // 
            this.PasswordOtherAdminTextBox_Registration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordOtherAdminTextBox_Registration.Location = new System.Drawing.Point(128, 173);
            this.PasswordOtherAdminTextBox_Registration.Name = "PasswordOtherAdminTextBox_Registration";
            this.PasswordOtherAdminTextBox_Registration.Size = new System.Drawing.Size(130, 22);
            this.PasswordOtherAdminTextBox_Registration.TabIndex = 4;
            this.PasswordOtherAdminTextBox_Registration.TabStop = false;
            this.PasswordOtherAdminTextBox_Registration.Visible = false;
            // 
            // RepeatPassTextBox_Registration
            // 
            this.RepeatPassTextBox_Registration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassTextBox_Registration.Location = new System.Drawing.Point(123, 113);
            this.RepeatPassTextBox_Registration.Name = "RepeatPassTextBox_Registration";
            this.RepeatPassTextBox_Registration.Size = new System.Drawing.Size(130, 22);
            this.RepeatPassTextBox_Registration.TabIndex = 22;
            // 
            // PasswordTextBox_Registration
            // 
            this.PasswordTextBox_Registration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox_Registration.Location = new System.Drawing.Point(123, 87);
            this.PasswordTextBox_Registration.Name = "PasswordTextBox_Registration";
            this.PasswordTextBox_Registration.Size = new System.Drawing.Size(130, 22);
            this.PasswordTextBox_Registration.TabIndex = 21;
            // 
            // LoginTextBox_Registration
            // 
            this.LoginTextBox_Registration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox_Registration.Location = new System.Drawing.Point(123, 58);
            this.LoginTextBox_Registration.Name = "LoginTextBox_Registration";
            this.LoginTextBox_Registration.Size = new System.Drawing.Size(130, 22);
            this.LoginTextBox_Registration.TabIndex = 20;
            // 
            // NewAdmin_CheckBox
            // 
            this.NewAdmin_CheckBox.AutoSize = true;
            this.NewAdmin_CheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewAdmin_CheckBox.ForeColor = System.Drawing.Color.Black;
            this.NewAdmin_CheckBox.Location = new System.Drawing.Point(11, 138);
            this.NewAdmin_CheckBox.Name = "NewAdmin_CheckBox";
            this.NewAdmin_CheckBox.Size = new System.Drawing.Size(137, 19);
            this.NewAdmin_CheckBox.TabIndex = 3;
            this.NewAdmin_CheckBox.TabStop = false;
            this.NewAdmin_CheckBox.Text = "Я новый модератор";
            this.NewAdmin_CheckBox.UseVisualStyleBackColor = true;
            this.NewAdmin_CheckBox.CheckedChanged += new System.EventHandler(this.NewAdmin_CheckBox_CheckedChanged);
            // 
            // lblRepeatPassword_NewUser
            // 
            this.lblRepeatPassword_NewUser.AutoSize = true;
            this.lblRepeatPassword_NewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeatPassword_NewUser.ForeColor = System.Drawing.Color.Black;
            this.lblRepeatPassword_NewUser.Location = new System.Drawing.Point(10, 116);
            this.lblRepeatPassword_NewUser.Name = "lblRepeatPassword_NewUser";
            this.lblRepeatPassword_NewUser.Size = new System.Drawing.Size(108, 15);
            this.lblRepeatPassword_NewUser.TabIndex = 2;
            this.lblRepeatPassword_NewUser.Text = "Повторите пароль";
            // 
            // lblPasswordOtherAdmin_NewUser
            // 
            this.lblPasswordOtherAdmin_NewUser.AutoSize = true;
            this.lblPasswordOtherAdmin_NewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasswordOtherAdmin_NewUser.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordOtherAdmin_NewUser.Location = new System.Drawing.Point(8, 156);
            this.lblPasswordOtherAdmin_NewUser.Name = "lblPasswordOtherAdmin_NewUser";
            this.lblPasswordOtherAdmin_NewUser.Size = new System.Drawing.Size(164, 15);
            this.lblPasswordOtherAdmin_NewUser.TabIndex = 2;
            this.lblPasswordOtherAdmin_NewUser.Text = "Пароль другого модератора";
            this.lblPasswordOtherAdmin_NewUser.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Регистрация нового пользователя";
            // 
            // lblPassword_NewUser
            // 
            this.lblPassword_NewUser.AutoSize = true;
            this.lblPassword_NewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword_NewUser.ForeColor = System.Drawing.Color.Black;
            this.lblPassword_NewUser.Location = new System.Drawing.Point(25, 90);
            this.lblPassword_NewUser.Name = "lblPassword_NewUser";
            this.lblPassword_NewUser.Size = new System.Drawing.Size(93, 15);
            this.lblPassword_NewUser.TabIndex = 1;
            this.lblPassword_NewUser.Text = "Введите пароль";
            // 
            // lblNick_NewUser
            // 
            this.lblNick_NewUser.AutoSize = true;
            this.lblNick_NewUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNick_NewUser.ForeColor = System.Drawing.Color.Black;
            this.lblNick_NewUser.Location = new System.Drawing.Point(15, 62);
            this.lblNick_NewUser.Name = "lblNick_NewUser";
            this.lblNick_NewUser.Size = new System.Drawing.Size(103, 15);
            this.lblNick_NewUser.TabIndex = 0;
            this.lblNick_NewUser.Text = "Введите никнейм";
            // 
            // Auth
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(277, 241);
            this.Controls.Add(this.GroupBoxAuth);
            this.Controls.Add(this.GroupBoxRegistration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.TopMost = true;
            this.GroupBoxAuth.ResumeLayout(false);
            this.GroupBoxAuth.PerformLayout();
            this.GroupBoxRegistration.ResumeLayout(false);
            this.GroupBoxRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabelAuth;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_timer_expl;
        private System.Windows.Forms.Label lblQuestionNewUser;
        private System.Windows.Forms.Label lblNewUserRegistration;
        private System.Windows.Forms.GroupBox GroupBoxAuth;
        private System.Windows.Forms.GroupBox GroupBoxRegistration;
        private System.Windows.Forms.TextBox PasswordOtherAdminTextBox_Registration;
        private System.Windows.Forms.TextBox RepeatPassTextBox_Registration;
        private System.Windows.Forms.TextBox PasswordTextBox_Registration;
        private System.Windows.Forms.TextBox LoginTextBox_Registration;
        private System.Windows.Forms.CheckBox NewAdmin_CheckBox;
        private System.Windows.Forms.Label lblRepeatPassword_NewUser;
        private System.Windows.Forms.Label lblPasswordOtherAdmin_NewUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassword_NewUser;
        private System.Windows.Forms.Label lblNick_NewUser;
        private System.Windows.Forms.Button btnCancelRegistration;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}

