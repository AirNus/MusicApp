using Music_AppML;
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
    public partial class Authorization : Form
    {
        const int durationLock = 10;
        int currTime = 0;
        int tryEnter = 0;
        public Authorization()
        {
            InitializeComponent();
        }

        private void CheckEnterTry()
        {           
            if(tryEnter == 3)
            {
                currTime = 0;
                btnEnterProgram.Enabled = false;
                label_timer.Visible = true;
                label_timer_expl.Visible = true;
                timer.Start();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label_timer.Text = currTime.ToString();
            currTime++;
            if (currTime == durationLock)
            {
                currTime = 0;
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
            if(rezult.HasRows)
            {
                MessageBox.Show("I'm fork!");
            }
            else 
            {
                tryEnter++;
                CheckEnterTry();
            }
        }
    }
}
