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
    public partial class EditRoleForm : Form
    {
        public EditRoleForm()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        private void save_button_Click(object sender, EventArgs e)
        {
          
        }

        private void EditRoleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session3_4DataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session3_4DataSet.Offices);
            AdminForm admin = new AdminForm();
            officebox_text.SelectedItem = admin.dataGridView1.CurrentRow.Cells[6].Value;
        }
    }
}
