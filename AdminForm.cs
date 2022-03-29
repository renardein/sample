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
    public partial class AdminForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            connection = new SqlConnection("Server=class31000;Database=Session3_4;Trusted_Connection=True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            dataGridView1.DataSource = table;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session3_4DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.session3_4DataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session3_4DataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session3_4DataSet.Offices);
            ShowTable("SELECT Users.ID, Users.FirstName AS Name, Users.LastName, DATEDIFF(YEAR, Users.Birthdate, GETDATE()) AS Age, Roles.Title AS[User Role], Users.Email AS[Email Address], Offices.Title AS Office, Users.Active FROM Users INNER JOIN Roles ON Roles.ID = Users.RoleID INNER JOIN Offices ON Users.OfficeID = Offices.ID");
            comboBox1.Text = "All Offices";
            dataGridView1.Columns[7].Visible = false;
            PaintRows();
        }
        public void ShowTable(string text)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            command.CommandText = text;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTable("SELECT Users.ID, Users.FirstName AS Name, Users.LastName, DATEDIFF(YEAR, Users.Birthdate, GETDATE()) AS Age, Roles.Title AS[User Role], Users.Email AS[Email Address], Offices.Title AS Office,  Users.Active FROM Users INNER JOIN Roles ON Roles.ID = Users.RoleID INNER JOIN Offices ON Users.OfficeID = Offices.ID WHERE Offices.Title = (\'" + comboBox1.Text + "\')");
            all_offices_button.Visible = true;
            dataGridView1.Columns[7].Visible = false;
            PaintRows();
        }

        private void all_offices_button_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT Users.ID, Users.FirstName AS Name, Users.LastName, DATEDIFF(YEAR, Users.Birthdate, GETDATE()) AS Age, Roles.Title AS[User Role], Users.Email AS[Email Address], Offices.Title AS Office,  Users.Active FROM Users INNER JOIN Roles ON Roles.ID = Users.RoleID INNER JOIN Offices ON Users.OfficeID = Offices.ID");
            all_offices_button.Visible = false;
            comboBox1.Text = "All Offices";
            dataGridView1.Columns[7].Visible = false;
            PaintRows();
        }

        private void enable_disable_button_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridView1.CurrentRow.Cells[7].Value == true)
            {
                dataGridView1.CurrentRow.Cells[7].Value = false;
                connection.Open();
                command.CommandText = "UPDATE Users SET Active='False' WHERE Users.ID = (\'" + dataGridView1.CurrentRow.Cells[0].Value + "\');";
                command.ExecuteReader();
                connection.Close();
                PaintRows();
            }
            else
            {
                dataGridView1.CurrentRow.Cells[7].Value = true;
                PaintRows();
                connection.Open();
                command.CommandText = "UPDATE Users SET Users.Active='True' WHERE Users.ID = (\'" + dataGridView1.CurrentRow.Cells[0].Value + "\');";
                command.ExecuteReader();
                connection.Close();
                PaintRows();
            }
        }
        private void PaintRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if ((bool)row.Cells[7].Value == true)
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else
                        row.DefaultCellStyle.BackColor = Color.Red;
                }
                catch
                {

                }
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AdduserForm adduser = new AdduserForm();
            adduser.ShowDialog();
        }

        private void change_role_button_Click(object sender, EventArgs e)
        {
            EditRoleForm edit = new EditRoleForm();
            edit.email_text.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            edit.firstname_text.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edit.lastname_text.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edit.officebox_text.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() =="User")
                edit.radioButton1.Checked = true;
            else
                edit.radioButton2.Checked = true;
            edit.ShowDialog();
        }
    }
}