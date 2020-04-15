using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Music_App
{   
    public partial class BodyProgram : Form
    {              
        string answer;
        string MyQuery;
        string SongName = "";
        Auth auth;       
        List<Songs> MusicName = new List<Songs>();        
        string role,login,password;      
        public string MyConn = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Music_po; Integrated Security = True";       
        public BodyProgram(Auth auth)
        {
            InitializeComponent();
            PaintPictureBox();
            this.role = auth.role;
            this.login = auth.QueryLogin;
            this.password = auth.QueryPass;
            UserStatus.Text = role;
            name_userTextBox.Text = login;
            new_passTextBox.PasswordChar = '*';
            old_passTextBox.PasswordChar = '*';
            if (role == "Модератор")
                btnAddTrack_Moderator.Visible = true;
            this.auth = auth;

            checkBoxFilterSearch.CheckedChanged += new EventHandler(checkBoxFilter_CheckedChanged);
        }

        /// Общее
        ///    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }            
        
        private void axMusic_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axMusic.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timerMusicPlayer.Enabled = true;                               
            }
        }

        private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SongName = MusicName[MusicListBox.SelectedIndex].Name;
                axMusic.URL = $"{MusicName[MusicListBox.SelectedIndex].Song_path}\\{MusicName[MusicListBox.SelectedIndex].Name}.mp3";               
                answer = StoredProcedureEXEC.ExecuteProcedureWithoutput("CheckStatusSong", login, MusicName[MusicListBox.SelectedIndex].Name);
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
            if (answer == "Err")
            {
                I_LikeIconPlayer.Visible = false;
                I_NoLikeIconPlayer.Visible = false;
                return;
            }
            else if (answer == "Like")
            {
                I_LikeIconPlayer.Visible = true;
                I_NoLikeIconPlayer.Visible = false;                       
            }
            else if (answer == "Not Like")
            {
                I_LikeIconPlayer.Visible = false;
                I_NoLikeIconPlayer.Visible = true;  
            }
        }

        private void timerMusicPlayer_Tick(object sender, EventArgs e)
        {
            if (MusicListBox.SelectedIndex < MusicListBox.Items.Count - 1)
            {
                MusicListBox.SelectedIndex++;
                timerMusicPlayer.Enabled = false;
            }
            else
            {
                MusicListBox.SelectedIndex = 0;
                timerMusicPlayer.Enabled = false;
            }
        }

        private void SelectSongs(string MyQuery)
        {           
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = new SqlCommand(MyQuery, conn))
                {
                    MusicListBox.Items.Clear();
                    MusicName.Clear();
                    try
                    {
                        conn.Open();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                        return;
                    }
                    SqlDataReader reader = command.ExecuteReader();                                              
                    while (reader.Read())
                    {
                        var row = new Songs()
                        {
                            Author = reader[0].ToString(),
                            Albom = reader[1].ToString(),
                            Name = reader[2].ToString(),         
                    };
                        MusicName.Add(row);
                    }
                    for( int i = 0; i < MusicName.Count; i++)
                    {
                        MusicName[i].Song_path = System.IO.Path.GetFullPath("Music\\Alboms\\" + MusicName[i].Author + "\\" + MusicName[i].Albom);
                    }
                    for (int i = 0; i < MusicName.Count; i++)
                    {
                        MusicListBox.Items.Add(MusicName[i].Name);
                    }                  
                    conn.Close();
                }
            }
        }


        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilterSearch.Checked)
            {
                MusicListBox.Items.Clear();
                groupBoxFilterSearch.Visible = true;
            }
            else
            {
                MusicListBox.Items.Clear();
                groupBoxFilterSearch.Visible = false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            groupBoxFilterSearch.Visible = false;           
            if(checkBoxFilterSearch.Checked)
            {                
                if (radioButtonFilterSearchTrack.Checked)
                {
                    MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                        $" where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                        $" [track].[id_track] = [albom_composition].[id_track] and" +
                        $" [track_name] like '%{Search_TextBox.Text}%'";
                }
                else if (radioButtonFilterSearchAlbom.Checked)
                {
                    MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                        $" where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                        $" [track].[id_track] = [albom_composition].[id_track] and" +
                        $" [Albom].[name_albom] like '%{Search_TextBox.Text}%'";
                }
                else if (radioButtonFilterSearchAuthor.Checked)
                {                   
                    MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                        $" where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                        $" [track].[id_track] = [albom_composition].[id_track] and " +
                        $"[Albom].[name_author] like '%{Search_TextBox.Text}%'";
                }
                else if(radioButtonFilterSearchGenre.Checked)
                {
                    MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                        $" where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                        $" [track].[id_track] = [albom_composition].[id_track] and" +
                        $" [genre] like '%{Search_TextBox.Text}%'";
                }
            }
            else
            {                
                MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                $" where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                $" [track].[id_track] = [albom_composition].[id_track] and" +
                $" ([track_name] like '%{Search_TextBox.Text}%' or [Albom].[name_author] like '%{Search_TextBox.Text}%' or" +
                $" [Albom].[name_albom] like '%{Search_TextBox.Text}%' or [genre] like '%{Search_TextBox.Text}%')";
            }
            if (Search_TextBox.TextLength > 0)
            {
                checkBoxFilterSearch.Checked = false;
                SelectSongs(MyQuery);
                if(MusicListBox.Items.Count == 0)
                {
                    MessageBox.Show("Поиск не дал результатов :(","Поиск");                   
                }
                Search_TextBox.Text = "";               
            }
            else
                MessageBox.Show("Введите трек, который хотите найти");
        }
    
        private void SearchTextBox_EnterKeyPress(object sender, KeyEventArgs e)
        {
            
            if( e.KeyCode == Keys.Enter )
            {
                btnSearch_Click(sender, e);
                MusicListBox.Focus();
            }
        }

        private void I_LikeIconPlayer_Click(object sender, EventArgs e)
        {
            MyQuery = $"EXEC [MusicChooseNotLike] '{login}', '{SongName}'";
            StoredProcedureEXEC.ExecuteProcedure(MyQuery, "", null);
            I_LikeIconPlayer.Visible = false;
            I_NoLikeIconPlayer.Visible = true;           
        }

        private void I_NoLikeIconPlayer_Click(object sender, EventArgs e)
        {           
             answer = StoredProcedureEXEC.ExecuteProcedureWithoutput("MusicChooseLike",login, SongName);
            if (answer == "Err" || answer == "NO")
            {
                MessageBox.Show("Произошла ошибка","Ошибка!");
                return;
            }
            else if (answer == "YES")
            {
                I_LikeIconPlayer.Visible = true;
                I_NoLikeIconPlayer.Visible = false;
            }            
        }

        /// Вкладка Альбом
        /// 

        public void PaintPictureBox()
        {
            int x = 6, y = 6;
            MyQuery = $"select [Albom].[name_albom],[Albom].[image] from [Albom]";

            List<string> Albom_DataBase_download = new List<string>();
            List<byte[]> image = new List<byte[]>();
            List<string> Playlists_DataBase_download = new List<string>();
            List<byte[]> image_collection = new List<byte[]>();
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                SqlCommand command = new SqlCommand(MyQuery, conn);
                try
                {
                    conn.Open();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                    return;
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Albom_DataBase_download.Add(reader[0].ToString());
                    image.Add((byte[])reader.GetValue(1));
                }
                conn.Close();
                conn.Open();
                MyQuery = $"select [name_collection],[image] from [collection_track]";
                command = new SqlCommand(MyQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Playlists_DataBase_download.Add(reader[0].ToString());
                    image_collection.Add((byte[])reader.GetValue(1));
                }
                conn.Close();

            }
            for (int i = 0; i < Albom_DataBase_download.Count; i++)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(image[i]);
                Image ImageOnDB = Image.FromStream(ms);
                var newAlbom = new System.Windows.Forms.PictureBox()
                {
                    Image = ImageOnDB,                                
                    Name = Albom_DataBase_download[i],
                    Size = new System.Drawing.Size(100, 101),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabStop = false,
                    Visible = true
                };
                if(x != 218 && i != 0)
                {
                    x = x + 106;
                }
                else if(i != 0)
                {
                    y = y + 107;
                    x = 6;
                }
                newAlbom.Location = new System.Drawing.Point(x, y);
                newAlbom.DoubleClick += new System.EventHandler(CreateAlbom);
                this.Albom.Controls.Add(newAlbom);
            }
            x = 112; y = 6;
            for (int i = 0; i < Playlists_DataBase_download.Count; i++)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(image_collection[i]);
                Image ImageOnDB = Image.FromStream(ms);
                var newPlaylist = new System.Windows.Forms.PictureBox()
                {
                    Image = ImageOnDB,
                    Name = Playlists_DataBase_download[i],
                    Size = new System.Drawing.Size(100, 101),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabStop = false,
                    Visible = true
                };
                if (x != 218 && i != 0)
                {
                    x = x + 106;
                }
                else if (i != 0)
                {
                    y = y + 107;
                    x = 6;
                }
                newPlaylist.Location = new System.Drawing.Point(x, y);
                newPlaylist.DoubleClick += new System.EventHandler(CreatePlaylist);
                this.Collections.Controls.Add(newPlaylist);
            }
        }

        private void CreateAlbom(object sender, EventArgs e)
        {

            PictureBox pB = sender as PictureBox;
            string nameAlbom = pB.Name;
            MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition] " +
                $"where [Albom].[id_albom] = [albom_composition].[id_albom] and" +
                $"[track].[id_track] = [albom_composition].[id_track] and" +
                $" [name_albom] = '{nameAlbom}'";
            SelectSongs(MyQuery);
        }

        /// Вкладка Подборки
        /// 

        private void CreatePlaylist(object sender, EventArgs e)
        {
            PictureBox pB = sender as PictureBox;
            string namePlaylist = pB.Name;
            MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition],[collection_track],[collection_composition] " +
                 $"where [Albom].[id_albom] = [albom_composition].[id_albom] and " +
                 $"[track].[id_track] = [albom_composition].[id_track] and " +
                 $"[track].[id_track] = [collection_composition].[id_track] and " +
                 $"[collection_track].[id_collection] = [collection_composition].[id_collection] and " +
                 $"[genre] = '{namePlaylist}'";
            SelectSongs(MyQuery);
        }

        private void I_LikePickureBox_DoubleClick(object sender, EventArgs e)
        {
            MyQuery = $"select [Albom].[name_author],[Albom].[name_albom],[track_name] from [Albom],[track],[albom_composition],[user],[i_liked] " +
                $"where [Albom].[id_albom] = [albom_composition].[id_albom] and " +
                $"[track].[id_track] = [albom_composition].[id_track] and " +
                $"[track].[id_track] = [i_liked].[id_track] and " +
                $"[user].[id_user] = [i_liked].[id_user] and " +
                $"[name_user] = '{login}'";
            SelectSongs(MyQuery);
        }

       

        /// Вкладка Пользователь
        /// 
        private void btnAddTrack_Moderator_Click(object sender, EventArgs e)
        {
            AddTrack_Moderator add = new AddTrack_Moderator(this,MyConn);
            add.Show();
        }

        private void lblExitAccount_Click(object sender, EventArgs e)
        {

            this.Dispose();
            this.Hide();
            auth.Show();
        }
      

        private void btnUpdate_pass_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    if (old_passTextBox.Text == password)
                    {
                        if (new_passTextBox.Text == "")
                        {
                            MessageBox.Show("Введите значение в поле 'Новый пароль'");
                        }
                        else if (new_passTextBox.Text == password)
                        {
                            MessageBox.Show("Новый пароль не должен повторять старый");
                        }
                        else
                        {
                            command.CommandText = "UPDATE [user] SET [password] = @NewPassword_User WHERE [name_user] = @Name_User";
                            command.Parameters.AddWithValue("@NewPassword_User", new_passTextBox.Text);
                            command.Parameters.AddWithValue("@Name_User", login);
                            try
                            {
                                conn.Open();
                            }
                            catch (System.Data.SqlClient.SqlException)
                            {
                                MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                                return;
                            }
                            command.ExecuteNonQuery();
                            conn.Close();
                            password = new_passTextBox.Text;
                            old_passTextBox.Clear();
                            new_passTextBox.Clear();
                            MessageBox.Show("Пароль успешно обновлен!");
                        }
                    }
                    else if(old_passTextBox.Text == "")
                    {
                        MessageBox.Show("Введите старый пароль");
                    }
                    else
                    {
                        old_passTextBox.Text = "";
                        new_passTextBox.Text = "";
                        MessageBox.Show("Проверьте правильность введенного пароля");
                    }
                }
            }
        }       

        private void btnUpdate_user_Click(object sender, EventArgs e)
        {            
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    if (name_userTextBox.Text == "")
                    {
                        MessageBox.Show("Введите значение в поле");
                    }
                    else if (name_userTextBox.Text == login)
                    {
                        MessageBox.Show("Новый никнейм не должен повторять старый");
                    }
                    else
                    {
                        command.CommandText = "UPDATE [user] SET [name_user] = @NewName_User WHERE [name_user] = @OldName_User";
                        command.Parameters.AddWithValue("@NewName_User", name_userTextBox.Text);
                        command.Parameters.AddWithValue("@OldName_User", login);
                        try
                        {
                            conn.Open();
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                            return;
                        }
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch(System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Такой никнейм уже существует\nПожалуйста введите другой никнейм", "Ошибка!");
                            name_userTextBox.Text = login;
                            return;
                        }                        
                        conn.Close();
                        login = name_userTextBox.Text;
                        MessageBox.Show("Никнейм успешно обновлен!");
                    }
                }
            }
        }
    }
}
