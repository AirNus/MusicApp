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
    public partial class Auth : Form
    {
        List<string> PssMdr = new List<string>();
        internal string QueryPass,QueryLogin,role;
        byte EnterTry = 3;
        int timer_dur = 10;        
        public string MyConn = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Music_po; Integrated Security = True";

        public Auth()
        {
            InitializeComponent();
            PasswordTextBox_Registration.Enter += new EventHandler(ShowInfoAboutPassword);
            PassText.PasswordChar = '*';
            PasswordOtherAdminTextBox_Registration.PasswordChar = '*';
            PasswordTextBox_Registration.PasswordChar = '*';
            RepeatPassTextBox_Registration.PasswordChar = '*';
        }       

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_dur = timer_dur - 1;
            label_timer.Text = Convert.ToString(timer_dur);                      
            if (timer_dur == 0)
            {
                timer1.Stop();
                btnEnter.Enabled = true;
                timer1.Enabled = false;
                EnterTry = 1;                               
                label_timer.Visible = false;
                label_timer_expl.Visible = false;                             
                timer_dur = 30;
                this.timer1.Tick -= new System.EventHandler(this.timer_Tick);
            }           
        }
       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LoginText.Focus();
            if (EnterTry == 1)
            {               
                btnEnter.Enabled = false;
                label_timer_expl.Visible = true;
                label_timer.Visible = true;
                timer1.Start();
                this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            }
            QueryLogin = LoginText.Text;
            QueryPass = PassText.Text;
            string MyQuery = $"select [role] from [user] where [name_user] = '" + QueryLogin + "'and [password] = '" + QueryPass + "'";
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = new SqlCommand(MyQuery, conn))
                {
                    try
                    {
                        conn.Open();
                    }                    
                    catch(System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                        return;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {                        
                        reader.Read();
                        role = reader[0].ToString();
                        BodyProgram form2 = new BodyProgram(this);
                        form2.Show();
                        LoginText.Clear();
                        PassText.Clear();
                        this.Hide();                       
                    }
                    else
                    {
                        LoginText.Clear();
                        PassText.Clear();
                        EnterTry--;
                        MessageBox.Show($"Проверьте правильность ввода логина/пароля\nРазрешено попыток: {EnterTry}");
                    }
                    conn.Close();
                }
            }
        }



        /// Регистрация нового пользователя
        /// 
        private void ShowInfoAboutPassword(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(PasswordTextBox_Registration, "Длина пароля должна составлять как минимум 8 символов");
        }
        private void lblNewUserRegistration_Click(object sender, EventArgs e)
        {
            LoginText.Clear();
            PassText.Clear();
            GroupBoxAuth.Visible = false;
            GroupBoxRegistration.Visible = true;

            string MyQuery = $"select [password] from [user] where role = 'Модератор'";
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
                        Application.Exit();
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PssMdr.Add(reader[0].ToString());
                    }
                    conn.Close();
                }
            }
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            PasswordTextBox_Registration.Clear();
            RepeatPassTextBox_Registration.Clear();
            PasswordOtherAdminTextBox_Registration.Clear();
            LoginTextBox_Registration.Clear();
            GroupBoxRegistration.Visible = false;
            GroupBoxAuth.Visible = true;
            NewAdmin_CheckBox.Checked = false;
        }

        private void NewAdmin_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(NewAdmin_CheckBox.Checked)
            {
                PasswordOtherAdminTextBox_Registration.Visible = true;
                lblPasswordOtherAdmin_NewUser.Visible = true;
            }
            else
            {
                PasswordOtherAdminTextBox_Registration.Visible = false;
                lblPasswordOtherAdmin_NewUser.Visible = false;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            role = "Слушатель";
            if (NewAdmin_CheckBox.Checked && PasswordOtherAdminTextBox_Registration.TextLength < 5)
            {
                PasswordOtherAdminTextBox_Registration.Clear();
                MessageBox.Show("Для регистрации в качестве модератора\nНужен пароль другого модератора");
                return;
            }
            else if (NewAdmin_CheckBox.Checked && !PssMdr.Contains(PasswordOtherAdminTextBox_Registration.Text))
            {
                PasswordOtherAdminTextBox_Registration.Clear();
                MessageBox.Show("Пароль от старого модератора введен неверно!");
                return;
            }
            else if (NewAdmin_CheckBox.Checked && PssMdr.Contains(PasswordOtherAdminTextBox_Registration.Text))
            {
                role = "Модератор";                
            }
            if (LoginTextBox_Registration.TextLength < 3 || PasswordTextBox_Registration.TextLength < 8)
            {
                MessageBox.Show("Проверьте данные\nВозможно какое то поле осталось незаполненным");
                return;
            }
            else
            {
                if (RepeatPassTextBox_Registration.TextLength < 8)
                {
                    MessageBox.Show("Заполните  форму - повторите пароль");
                    return;
                }
                else if (RepeatPassTextBox_Registration.Text != PasswordTextBox_Registration.Text)
                {
                    MessageBox.Show("Пароли не совпадают!\nПопробуйте еще раз");
                    return;
                }
            }
            string MyQuery = $"EXEC [CreateNewUser] '{LoginTextBox_Registration.Text}','{PasswordTextBox_Registration.Text}',{role}";
            StoredProcedureEXEC.ExecuteProcedure(MyQuery, "Новый пользователь успешно создан!", null);
            LoginText.Text = LoginTextBox_Registration.Text;
            PassText.Text = PasswordTextBox_Registration.Text;
            btnCancelRegistration_Click(sender, e);
        }    
       
    }
}
