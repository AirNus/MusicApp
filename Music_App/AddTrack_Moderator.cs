using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Music_App
{    
    public partial class AddTrack_Moderator : Form
    {
        string DestPath = "C:\\Users\\Айнур\\Documents\\GitHub\\MusicApp\\Music_App\\bin\\x64\\Debug\\Music\\Alboms\\";
        string pathAlbomPicture;
        string MyConn,MyQuery;
        byte[] imageData;
        BodyProgram BodyPO;
        public AddTrack_Moderator(BodyProgram BodyPO,string MyConn)
        {
            this.BodyPO = BodyPO;
            this.MyConn = MyConn;
            InitializeComponent();
            AddAlbomGroupBox.Visible = false;
            AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AlbomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;            
            AuthorComboBox.Enter += new EventHandler(Select_InfoAuthor);
            AuthorComboBox.SelectedIndexChanged += new EventHandler(Select_InfoAlbom);
            AlbomComboBox.SelectedValueChanged += new EventHandler(Open_btnSelectFile_OR_formAddNewAlbom);
            GenreComboBox.Enter += new EventHandler(Select_InfoGenre);
            CountTrackTextBox.KeyPress += new KeyPressEventHandler(TextBoxEnterOnlyNumber_KeyPress);
            YearIssueTextBox.KeyPress += new KeyPressEventHandler(TextBoxEnterOnlyNumber_KeyPress);
            Country_TextBox_AddPerformer.KeyPress += new KeyPressEventHandler(TextBoxEnterOnlySymbol_KeyPress);
        }

        /// Запросы в ComboBox для его заполнения
        /// 
        private void SelectInfo(ComboBox SomeComboBox, string MyQuery)
        {
            SomeComboBox.Text = "";
            SomeComboBox.Items.Clear();
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = new SqlCommand(MyQuery, conn))
                {
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
                        SomeComboBox.Items.Add(reader[0].ToString());
                    }
                    conn.Close();
                }
            }
        }

        private void Select_InfoAuthor(object sender, EventArgs e)
        {
            btnSelectFile.Enabled = false;
            btnAddTrack.Enabled = false;
            MyQuery = $"select [Performer].[name_author] from [Performer]";
            SelectInfo(AuthorComboBox, MyQuery);
            AuthorComboBox.Items.Add("Добавить нового...");
        }

        private void Select_InfoAlbom(object sender, EventArgs e)
        {
            if (AuthorComboBox.SelectedItem == "Добавить нового...")
            {
                AddTrackGroupBox.Visible = false;
                AddAuthorGroupBox.Visible = true;
            }
            else
            {
                MyQuery = $"select [Albom].[name_albom] from [Albom]" +
                    $" where [name_author] = '{AuthorComboBox.SelectedItem}'";
                SelectInfo(AlbomComboBox, MyQuery);
                AlbomComboBox.Items.Add("Добавить новый...");
            }
        }

        private void Open_btnSelectFile_OR_formAddNewAlbom(object sender, EventArgs e)
        {
            btnSelectFile.Enabled = true;
            if (AlbomComboBox.SelectedItem == "Добавить новый...")
            {
                NameAuthorTextBox.Text = AuthorComboBox.SelectedItem.ToString();
                AddTrackGroupBox.Visible = false;
                AddAlbomGroupBox.Visible = true;
            }
        }

        private void Select_InfoGenre(object sender, EventArgs e)
        {
            MyQuery = $"select [name_collection] from [collection_track]";
            SelectInfo(GenreComboBox, MyQuery);            
        }
             
    
        /// Поиск файла в файловом менеджере 
        /// 
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string PathToSong = DestPath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.mp3)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PathToSong = PathToSong + AuthorComboBox.SelectedItem + "\\" + AlbomComboBox.SelectedItem;
                string TrackPath = System.IO.Path.GetDirectoryName(ofd.FileName);               
                string FileName = ofd.SafeFileName;
                ///////////"C:\\Users\\Айнур\\Documents\\GitHub\\Music_App\\Music_App\\bin\\x64\\Debug\\Music\\Alboms\\
                try
                {
                    System.IO.File.Copy(TrackPath + @"\" + FileName, PathToSong + @"\" + FileName);
                }
                catch(System.IO.IOException ioe)
                {
                    MessageBox.Show(ioe.Message);
                    return;
                }
               
                FileName = FileName.Remove(FileName.Length - 4, 4);
                TrackNameTextBox.Text = FileName;
                btnAddTrack.Enabled = true;
            }
            else
                return;
        }
        /// Добавление новой песни в БД
        /// 
        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            if(TrackNameTextBox.TextLength < 1 || AuthorComboBox.SelectedItem == null || AlbomComboBox.SelectedItem == null || GenreComboBox.SelectedItem == null)
            {
                MessageBox.Show("Проверьте вводимые данные!\nВозможно какое-то поле осталось незаполненным", "Ошибка!!!");
                return;
            }
           MyQuery = $"EXEC [AddTrack] " +
                $"'{TrackNameTextBox.Text}'," +
                $"'{AuthorComboBox.SelectedItem}'," +       
                $"'{GenreComboBox.SelectedItem}'";
            StoredProcedureEXEC.ExecuteProcedure(MyQuery, "Трек успешно добавлен!", this);
        }

        


        /// Отдельная формочка для добавления альбома
        /// 

        private void TextBoxEnterOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAddAlbom_Click(object sender, EventArgs e)
        {
            string Dest_path = DestPath;
            if (NameAlbomTextBox.TextLength < 1 || YearIssueTextBox.TextLength < 1 || CountTrackTextBox.TextLength < 1 || pathAlbomPicture == null)
            {
                MessageBox.Show("Проверьте вводимые данные!\nВозможно какое-то поле осталось незаполненным", "Ошибка!!!");
                return;
            }         
            if( Convert.ToInt32(CountTrackTextBox.Text) > 50)
            {
                MessageBox.Show("Слишком большое количество треков!\nПожалуйста, проверьте данные", "Превышено допустимое количество треков");
                return;
            }
            if (Convert.ToInt32(YearIssueTextBox.Text) > 2020 || Convert.ToInt32(YearIssueTextBox.Text) < 1900)
            {
                MessageBox.Show("Не добавляйте альбом из будущего!\nПожалуйста, проверьте данные", "Ошибка! Неккоректный год");
                return;
            }

            MyQuery = $"use [Music_po] EXECUTE [AddAlbom] " +
                 $"@Name_albom ," +
                 $"@Name_author ," +
                 $" @Count_track ," +
                 $" @Year_issue ," +
                 $" @image";
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = new SqlCommand(MyQuery, conn))
                {
                    command.Parameters.AddWithValue("@Name_albom", NameAlbomTextBox.Text);
                    command.Parameters.AddWithValue("@Name_author", NameAuthorTextBox.Text);
                    command.Parameters.AddWithValue("@Count_track", CountTrackTextBox.Text);
                    command.Parameters.AddWithValue("@Year_issue", YearIssueTextBox.Text);
                    command.Parameters.AddWithValue("@image", imageData);

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
                    catch (System.Data.SqlClient.SqlException errr)
                    {
                        MessageBox.Show(errr.Message);
                        return;
                    }

                    System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(Dest_path + AuthorComboBox.SelectedItem + @"\");
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }

                    dirInfo.CreateSubdirectory(NameAlbomTextBox.Text);

                    MessageBox.Show("Альбом успешно добавлен", "Успех!");
                    BodyPO.PaintPictureBox();
                    conn.Close();
                    btnCancelAddAlbom_Click(sender, e);

                }
            }

        }

        private void btnChosePicture_Click(object sender, EventArgs e)
        {
            string PathFile_picture = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg; *.png; *.BMP)|*.jpg; *.png; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Path = System.IO.Path.GetDirectoryName(ofd.FileName);
                string FileName = ofd.SafeFileName;
                PathFile_picture = ofd.FileName;
                pathAlbomPicture = Path + "\\" + FileName;                
                using (System.IO.FileStream fs = new System.IO.FileStream(PathFile_picture, System.IO.FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
            }
            else
                return;
        }
     
        private void btnCancelAddAlbom_Click(object sender, EventArgs e)
        {
            AddTrackGroupBox.Visible = true;
            AddAlbomGroupBox.Visible = false;
            NameAlbomTextBox.Clear();
            YearIssueTextBox.Clear();          
            CountTrackTextBox.Clear();
            AlbomComboBox.Items.Clear();
            AuthorComboBox.Items.Clear();
        }



        /// Добавление автора
        /// 

        private void TextBoxEnterOnlySymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!System.Text.RegularExpressions.Regex.Match(Symbol,@"[а-яА-Я]|[a-zA-Z]").Success)
                e.Handled = true;
        }

        private void btn_Add_Performer_Click(object sender, EventArgs e)
        {
            string Dest_path = DestPath;
            if (NameAuthorTextBox_AddPerformer.Text == "" || Country_TextBox_AddPerformer.Text == "")
            {
                if (AuthorComboBox.Items.Contains(NameAuthorTextBox_AddPerformer.Text))
                {
                    MessageBox.Show("Такой автор уже есть!\nВведите другого автора или выйдите из этой формы", "Уже существует!");
                    return;
                }
                else
                {
                    MessageBox.Show("Проверьте вводимые данные!\nВозможно одно из полей осталось незаполненным", "Не все данные заполнены!");
                    return;
                }
            }
            MyQuery = $"EXEC [AddPerformer] '{NameAuthorTextBox_AddPerformer.Text}','{Country_TextBox_AddPerformer.Text}'";
            StoredProcedureEXEC.ExecuteProcedure(MyQuery, "Автор успешно добавлен!", null);

            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(Dest_path + @"\");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            dirInfo.CreateSubdirectory(NameAuthorTextBox_AddPerformer.Text);

            btn_Cancel_AddPerformer_Click(sender, e);
        }

        private void btn_Cancel_AddPerformer_Click(object sender, EventArgs e)
        {
            AuthorComboBox.Items.Clear();
            AddTrackGroupBox.Visible = true;
            AddAuthorGroupBox.Visible = false;
            NameAuthorTextBox_AddPerformer.Clear();
            Country_TextBox_AddPerformer.Clear();
        }



    }
}
