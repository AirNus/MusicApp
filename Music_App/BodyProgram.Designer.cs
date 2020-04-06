namespace Music_App
{
    partial class BodyProgram
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
            System.Windows.Forms.Label name_userLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyProgram));
            this.ExitButtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabelMusicApp = new System.Windows.Forms.Label();
            this.axMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicListBox = new System.Windows.Forms.ListBox();
            this.Main = new System.Windows.Forms.TabControl();
            this.Albom = new System.Windows.Forms.TabPage();
            this.Collections = new System.Windows.Forms.TabPage();
            this.I_LikePictureBox = new System.Windows.Forms.PictureBox();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.lblExitAccount = new System.Windows.Forms.Label();
            this.labelChangePass = new System.Windows.Forms.Label();
            this.btnUpdate_pass = new System.Windows.Forms.Button();
            this.btnUpdate_user = new System.Windows.Forms.Button();
            this.UserStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_passTextBox = new System.Windows.Forms.TextBox();
            this.old_passTextBox = new System.Windows.Forms.TextBox();
            this.name_userTextBox = new System.Windows.Forms.TextBox();
            this.btnAddTrack_Moderator = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.I_NoLikeIconPlayer = new System.Windows.Forms.PictureBox();
            this.I_LikeIconPlayer = new System.Windows.Forms.PictureBox();
            this.timerMusicPlayer = new System.Windows.Forms.Timer(this.components);
            this.labelChangeLogin = new System.Windows.Forms.Label();
            name_userLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMusic)).BeginInit();
            this.Main.SuspendLayout();
            this.Collections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_LikePictureBox)).BeginInit();
            this.UserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_NoLikeIconPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_LikeIconPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // name_userLabel
            // 
            name_userLabel.AutoSize = true;
            name_userLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_userLabel.Location = new System.Drawing.Point(34, 196);
            name_userLabel.Name = "name_userLabel";
            name_userLabel.Size = new System.Drawing.Size(71, 19);
            name_userLabel.TabIndex = 2;
            name_userLabel.Text = "Никнейм";
            // 
            // ExitButtn
            // 
            this.ExitButtn.BackColor = System.Drawing.Color.Red;
            this.ExitButtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtn.Location = new System.Drawing.Point(531, 0);
            this.ExitButtn.Name = "ExitButtn";
            this.ExitButtn.Size = new System.Drawing.Size(35, 30);
            this.ExitButtn.TabIndex = 6;
            this.ExitButtn.Text = "X";
            this.ExitButtn.UseVisualStyleBackColor = false;
            this.ExitButtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TopPanel.Controls.Add(this.TopLabelMusicApp);
            this.TopPanel.Controls.Add(this.ExitButtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(566, 30);
            this.TopPanel.TabIndex = 2;
            // 
            // TopLabelMusicApp
            // 
            this.TopLabelMusicApp.AutoSize = true;
            this.TopLabelMusicApp.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelMusicApp.Location = new System.Drawing.Point(10, 6);
            this.TopLabelMusicApp.Name = "TopLabelMusicApp";
            this.TopLabelMusicApp.Size = new System.Drawing.Size(71, 18);
            this.TopLabelMusicApp.TabIndex = 3;
            this.TopLabelMusicApp.Text = "Music App";
            // 
            // axMusic
            // 
            this.axMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axMusic.Enabled = true;
            this.axMusic.Location = new System.Drawing.Point(0, 371);
            this.axMusic.Name = "axMusic";
            this.axMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMusic.OcxState")));
            this.axMusic.Size = new System.Drawing.Size(566, 61);
            this.axMusic.TabIndex = 5;
            this.axMusic.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axMusic_PlayStateChange);
            // 
            // MusicListBox
            // 
            this.MusicListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicListBox.FormattingEnabled = true;
            this.MusicListBox.ItemHeight = 15;
            this.MusicListBox.Location = new System.Drawing.Point(375, 64);
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(191, 259);
            this.MusicListBox.TabIndex = 0;
            this.MusicListBox.SelectedIndexChanged += new System.EventHandler(this.MusicListBox_SelectedIndexChanged);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.Albom);
            this.Main.Controls.Add(this.Collections);
            this.Main.Controls.Add(this.UserPage);
            this.Main.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main.Location = new System.Drawing.Point(12, 64);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(357, 305);
            this.Main.TabIndex = 8;
            // 
            // Albom
            // 
            this.Albom.AutoScroll = true;
            this.Albom.Location = new System.Drawing.Point(4, 24);
            this.Albom.Name = "Albom";
            this.Albom.Padding = new System.Windows.Forms.Padding(3);
            this.Albom.Size = new System.Drawing.Size(349, 277);
            this.Albom.TabIndex = 0;
            this.Albom.Text = "Альбомы";
            this.Albom.UseVisualStyleBackColor = true;
            // 
            // Collections
            // 
            this.Collections.Controls.Add(this.I_LikePictureBox);
            this.Collections.Location = new System.Drawing.Point(4, 24);
            this.Collections.Name = "Collections";
            this.Collections.Padding = new System.Windows.Forms.Padding(3);
            this.Collections.Size = new System.Drawing.Size(349, 277);
            this.Collections.TabIndex = 1;
            this.Collections.Text = "Подборки и жанры";
            this.Collections.UseVisualStyleBackColor = true;
            // 
            // I_LikePictureBox
            // 
            this.I_LikePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("I_LikePictureBox.Image")));
            this.I_LikePictureBox.Location = new System.Drawing.Point(6, 6);
            this.I_LikePictureBox.Name = "I_LikePictureBox";
            this.I_LikePictureBox.Size = new System.Drawing.Size(100, 101);
            this.I_LikePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_LikePictureBox.TabIndex = 2;
            this.I_LikePictureBox.TabStop = false;
            this.I_LikePictureBox.DoubleClick += new System.EventHandler(this.I_LikePickureBox_DoubleClick);
            // 
            // UserPage
            // 
            this.UserPage.AutoScroll = true;
            this.UserPage.Controls.Add(this.lblExitAccount);
            this.UserPage.Controls.Add(this.labelChangeLogin);
            this.UserPage.Controls.Add(this.labelChangePass);
            this.UserPage.Controls.Add(this.btnUpdate_pass);
            this.UserPage.Controls.Add(this.btnUpdate_user);
            this.UserPage.Controls.Add(this.UserStatus);
            this.UserPage.Controls.Add(this.label2);
            this.UserPage.Controls.Add(this.label3);
            this.UserPage.Controls.Add(this.new_passTextBox);
            this.UserPage.Controls.Add(this.old_passTextBox);
            this.UserPage.Controls.Add(name_userLabel);
            this.UserPage.Controls.Add(this.name_userTextBox);
            this.UserPage.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPage.Location = new System.Drawing.Point(4, 24);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(349, 277);
            this.UserPage.TabIndex = 2;
            this.UserPage.Text = "Пользователь";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // lblExitAccount
            // 
            this.lblExitAccount.AutoSize = true;
            this.lblExitAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExitAccount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExitAccount.Location = new System.Drawing.Point(288, 7);
            this.lblExitAccount.Name = "lblExitAccount";
            this.lblExitAccount.Size = new System.Drawing.Size(55, 19);
            this.lblExitAccount.TabIndex = 10;
            this.lblExitAccount.Text = "Выйти";
            this.lblExitAccount.Click += new System.EventHandler(this.lblExitAccount_Click);
            // 
            // labelChangePass
            // 
            this.labelChangePass.AutoSize = true;
            this.labelChangePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangePass.Location = new System.Drawing.Point(24, 62);
            this.labelChangePass.Name = "labelChangePass";
            this.labelChangePass.Size = new System.Drawing.Size(104, 19);
            this.labelChangePass.TabIndex = 8;
            this.labelChangePass.Text = "Смена пароля";
            // 
            // btnUpdate_pass
            // 
            this.btnUpdate_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate_pass.Location = new System.Drawing.Point(243, 106);
            this.btnUpdate_pass.Name = "btnUpdate_pass";
            this.btnUpdate_pass.Size = new System.Drawing.Size(100, 27);
            this.btnUpdate_pass.TabIndex = 7;
            this.btnUpdate_pass.Text = "Сохранить";
            this.btnUpdate_pass.UseVisualStyleBackColor = true;
            this.btnUpdate_pass.Click += new System.EventHandler(this.btnUpdate_pass_Click);
            // 
            // btnUpdate_user
            // 
            this.btnUpdate_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate_user.Location = new System.Drawing.Point(243, 192);
            this.btnUpdate_user.Name = "btnUpdate_user";
            this.btnUpdate_user.Size = new System.Drawing.Size(100, 27);
            this.btnUpdate_user.TabIndex = 7;
            this.btnUpdate_user.Text = "Сохранить";
            this.btnUpdate_user.UseVisualStyleBackColor = true;
            this.btnUpdate_user.Click += new System.EventHandler(this.btnUpdate_user_Click);
            // 
            // UserStatus
            // 
            this.UserStatus.AutoSize = true;
            this.UserStatus.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserStatus.Location = new System.Drawing.Point(13, 15);
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.Size = new System.Drawing.Size(119, 33);
            this.UserStatus.TabIndex = 6;
            this.UserStatus.Text = "Слушатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Старый пароль";
            // 
            // new_passTextBox
            // 
            this.new_passTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_passTextBox.Location = new System.Drawing.Point(122, 124);
            this.new_passTextBox.Name = "new_passTextBox";
            this.new_passTextBox.Size = new System.Drawing.Size(100, 26);
            this.new_passTextBox.TabIndex = 4;
            // 
            // old_passTextBox
            // 
            this.old_passTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.old_passTextBox.Location = new System.Drawing.Point(122, 87);
            this.old_passTextBox.Name = "old_passTextBox";
            this.old_passTextBox.Size = new System.Drawing.Size(100, 26);
            this.old_passTextBox.TabIndex = 4;
            // 
            // name_userTextBox
            // 
            this.name_userTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_userTextBox.Location = new System.Drawing.Point(122, 193);
            this.name_userTextBox.Name = "name_userTextBox";
            this.name_userTextBox.Size = new System.Drawing.Size(100, 26);
            this.name_userTextBox.TabIndex = 3;
            // 
            // btnAddTrack_Moderator
            // 
            this.btnAddTrack_Moderator.Location = new System.Drawing.Point(375, 329);
            this.btnAddTrack_Moderator.Name = "btnAddTrack_Moderator";
            this.btnAddTrack_Moderator.Size = new System.Drawing.Size(179, 36);
            this.btnAddTrack_Moderator.TabIndex = 9;
            this.btnAddTrack_Moderator.Text = "Добавить трек";
            this.btnAddTrack_Moderator.UseVisualStyleBackColor = true;
            this.btnAddTrack_Moderator.Visible = false;
            this.btnAddTrack_Moderator.Click += new System.EventHandler(this.btnAddTrack_Moderator_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(12, 37);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(438, 20);
            this.Search_TextBox.TabIndex = 9;
            this.Search_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_EnterKeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(457, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // I_NoLikeIconPlayer
            // 
            this.I_NoLikeIconPlayer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.I_NoLikeIconPlayer.Image = ((System.Drawing.Image)(resources.GetObject("I_NoLikeIconPlayer.Image")));
            this.I_NoLikeIconPlayer.Location = new System.Drawing.Point(164, 404);
            this.I_NoLikeIconPlayer.Name = "I_NoLikeIconPlayer";
            this.I_NoLikeIconPlayer.Size = new System.Drawing.Size(21, 19);
            this.I_NoLikeIconPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_NoLikeIconPlayer.TabIndex = 11;
            this.I_NoLikeIconPlayer.TabStop = false;
            this.I_NoLikeIconPlayer.Visible = false;
            this.I_NoLikeIconPlayer.Click += new System.EventHandler(this.I_NoLikeIconPlayer_Click);
            // 
            // I_LikeIconPlayer
            // 
            this.I_LikeIconPlayer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.I_LikeIconPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.I_LikeIconPlayer.Image = ((System.Drawing.Image)(resources.GetObject("I_LikeIconPlayer.Image")));
            this.I_LikeIconPlayer.Location = new System.Drawing.Point(164, 404);
            this.I_LikeIconPlayer.Name = "I_LikeIconPlayer";
            this.I_LikeIconPlayer.Size = new System.Drawing.Size(21, 19);
            this.I_LikeIconPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_LikeIconPlayer.TabIndex = 11;
            this.I_LikeIconPlayer.TabStop = false;
            this.I_LikeIconPlayer.Visible = false;
            this.I_LikeIconPlayer.Click += new System.EventHandler(this.I_LikeIconPlayer_Click);
            // 
            // timerMusicPlayer
            // 
            this.timerMusicPlayer.Tick += new System.EventHandler(this.timerMusicPlayer_Tick);
            // 
            // labelChangeLogin
            // 
            this.labelChangeLogin.AutoSize = true;
            this.labelChangeLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeLogin.Location = new System.Drawing.Point(24, 166);
            this.labelChangeLogin.Name = "labelChangeLogin";
            this.labelChangeLogin.Size = new System.Drawing.Size(104, 19);
            this.labelChangeLogin.TabIndex = 8;
            this.labelChangeLogin.Text = "Смена логина";
            // 
            // BodyProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.ExitButtn;
            this.ClientSize = new System.Drawing.Size(566, 432);
            this.Controls.Add(this.I_LikeIconPlayer);
            this.Controls.Add(this.btnAddTrack_Moderator);
            this.Controls.Add(this.I_NoLikeIconPlayer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.MusicListBox);
            this.Controls.Add(this.axMusic);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BodyProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMu";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMusic)).EndInit();
            this.Main.ResumeLayout(false);
            this.Collections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.I_LikePictureBox)).EndInit();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_NoLikeIconPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_LikeIconPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TopLabelMusicApp;
        private AxWMPLib.AxWindowsMediaPlayer axMusic;
        private System.Windows.Forms.ListBox MusicListBox;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage Albom;
        private System.Windows.Forms.TabPage Collections;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_passTextBox;
        private System.Windows.Forms.TextBox old_passTextBox;
        private System.Windows.Forms.TextBox name_userTextBox;
        private System.Windows.Forms.Label UserStatus;
        private System.Windows.Forms.Label labelChangePass;
        private System.Windows.Forms.Button btnUpdate_pass;
        private System.Windows.Forms.Button btnUpdate_user;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddTrack_Moderator;
        private System.Windows.Forms.Label lblExitAccount;
        private System.Windows.Forms.PictureBox I_NoLikeIconPlayer;
        private System.Windows.Forms.PictureBox I_LikeIconPlayer;
        private System.Windows.Forms.PictureBox I_LikePictureBox;
        private System.Windows.Forms.Timer timerMusicPlayer;
        private System.Windows.Forms.Label labelChangeLogin;
    }
}