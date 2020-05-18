using Music_AppML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Music_App
{
    public partial class Authorization : Form
    {
        const int durationLock = 10;
        int currTime = durationLock;
        int tryEnter = 0;
        public Authorization()
        {
            InitializeComponent();
        }

        private void CheckEnterTry()
        {           
            if(tryEnter == 3)
            {
                currTime = durationLock;
                btnEnterProgram.Enabled = false;
                label_timer.Visible = true;
                label_timer_expl.Visible = true;
                timer.Start();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label_timer.Text = currTime.ToString();
            currTime--;
            if (currTime < 0)
            {
                currTime = durationLock;
                btnEnterProgram.Enabled = true;
                label_timer.Visible = false;
                label_timer_expl.Visible = false;
                timer.Stop();
                tryEnter = 0;
            }
        }

        private void btnEnterProgram_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select [role] from [user]" +
                $"where [name_user] = '{textBoxLogin.Text}' and [password] = '{textBoxPassword.Text}'";
            var rezult =  SQL.Query(command);
            if(rezult.Count > 0)
            {
                MessageBox.Show("I'm fork!");                
            }
            else 
            {
                MessageBox.Show("Ошибка входа!\nПроверьте данные","Вход");
                tryEnter++;
                CheckEnterTry();
            }
        }

        private void lblNewUserRegistration_Click(object sender, EventArgs e)
        {
            GroupBoxAuth.Visible = false;
            GroupBoxRegistration.Visible = true;
            ClearAllTextBox(GroupBoxAuth);
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            GroupBoxAuth.Visible = true;
            GroupBoxRegistration.Visible = false;
            ClearAllTextBox(GroupBoxRegistration);
        }

        private void ClearAllTextBox(GroupBox groupBox)
        {
            foreach(Control txtbox in groupBox.Controls)
            {
                if(txtbox.GetType() == typeof(TextBox))
                {
                    txtbox.Text = "";
                }
            }
        }
        private void NewAdmin_checkBox_CheckedChange(object sender, EventArgs e)
        {
            if (NewAdmin_CheckBox.Checked)
            {
                lblPasswordOtherAdmin_NewUser.Visible = true;
                textBoxPasswordOtherAdminRegistration.Visible = true;
            }
            else 
            {
                lblPasswordOtherAdmin_NewUser.Visible = false;
                textBoxPasswordOtherAdminRegistration.Visible = false;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {            
            string role = "Слушатель";
            if (CheckOtherAdminPassword(textBoxPasswordOtherAdminRegistration.Text) == true)
                role = "Модератор";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CreateNewUser";

            command.Parameters.AddWithValue("login", textBoxLoginRegistration.Text);
            command.Parameters.AddWithValue("password", textBoxPasswordRegistration.Text);
            command.Parameters.AddWithValue("role", role);
            command = SQL.StoredProcedure(command);

            if(command != null)
            {
                MessageBox.Show("Регистрация прошла успешно!","Регистрация");
            }
            btnCancelRegistration_Click(sender, e);
        }
        private bool CheckOtherAdminPassword(string password)
        {
            var answer = SQL.Query(new SqlCommand() { CommandText = "SELECT * FROM [User]" +
                $" where [role] = 'Модератор' and password = '{password}'"});
            if (answer.Count > 0)
                return true;
            return false;
        }
    }
}
