using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Session_4
{
    public partial class AdduserForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public AdduserForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=Class31000;Database=Session3_4;Trusted_Connection=True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
        }

        private void AdduserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session3_4DataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session3_4DataSet.Offices);

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(email_text.Text) || string.IsNullOrEmpty(firstname_text.Text) || string.IsNullOrEmpty(lastname_text.Text) || string.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }   
            else
            {
                connection.Open();
                command.CommandText = "INSERT INTO Users(RoleID, Email, Password, FirstName, LastName, OfficeID, Birthdate, Active) VALUES(2, '@email', '@password', '@firstname', @lastname, @office , @date, 'False')";
                command.Parameters.AddWithValue("@email", email_text.Text);
                command.Parameters.AddWithValue("password", password_text.Text);
                command.Parameters.AddWithValue("@firstname", firstname_text.Text);
                command.Parameters.AddWithValue("@lastname", lastname_text.Text);
                command.Parameters.AddWithValue("@office", officebox_text.SelectedValue);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                command.ExecuteReader();
                connection.Close();
            }
        }
    }
}
