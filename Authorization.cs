using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_4
{
    public partial class Authorization : Form
    {
        Timer timer1 = new Timer();
        int a = 0;
        int i = 10;
        public Authorization()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void  timer_Tick(object sender, EventArgs e)
        {
            timer_label.Text = String.Format("Подождите {0} секунд", --i);
            if (i == 0)
            {
                login_button.Enabled = true;
                timer_label.Text = "";
                (sender as Timer).Stop();
                a = 0;
                i = 10;
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_text.Text) || string.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show("Write login or password!");
                a = a + 1;
                if (a == 3)
                {
                    timer_label.Text = String.Format("Подождите {0} секунд", i);
                    login_button.Enabled = false;
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                }
                else
                {
                    return;
                }
            }
            else
            {
                using(var db = new Session3_4Entities())
                {
                    var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Email == login_text.Text && u.Password == password_text.Text);
                    if (user == null)
                    {
                        a = a + 1;
                        MessageBox.Show("User not founded!");
                        if (a == 3)
                        {
                            timer_label.Text = String.Format("Подождите {0} секунд", i);
                            login_button.Enabled = false;
                            Timer timer = new Timer();
                            timer.Interval = 1000;
                            timer.Tick += new EventHandler(timer_Tick);
                            timer.Start();
                        }
                        return;
                    }
                    else
                    {
                        a = 0;
                        if (user.RoleID == 1)
                        {
                            AdminForm ad = new AdminForm();
                            login_text.Text = "";
                            password_text.Text = "";
                            ad.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
        }
    }
}
