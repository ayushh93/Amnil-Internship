using SimpleDesktopForm.Data;
using SimpleDesktopForm.Migrations;
using SimpleDesktopForm.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimpleDesktopForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        int _id = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string ageStr = textBoxAge.Text;
            string address = comboBoxAddress.Text;
            string email = textBoxEmail.Text;
            // Validate name input
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            // Validate age input
            if (!int.TryParse(ageStr, out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAge.Focus();
                return;
            }

            // Validate name input
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter an address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxAddress.Focus();
                return;
            }

            // Validate email input
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();

                return;
            }
            try
            {
                using (var context = new FormContext())
                {
                    var user = new User
                    {
                        Name = name,
                        Age = age,
                        Address = address,
                        Email = email,
                    };
                    context.users.Add(user);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show($"{name} saved succesfully", "User saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception - {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }

        }

        private void LoadData()
        {
            try
            {
                using (var context = new FormContext())
                {
                    var users = context.users.ToList();
                    var bindingSource = new BindingSource { DataSource = users };
                    dgvUsers.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception - {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



        private void Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxEmail.Clear();
            comboBoxAddress.SelectedIndex = -1;
            _id = 0;
            textBoxName.Focus();

        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a row is actually selected
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _id = (int)row.Cells["ID"].Value;
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxAge.Text = row.Cells["Age"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                comboBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxName.Focus();

            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a row is actually selected
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _id = (int)row.Cells["ID"].Value;
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxAge.Text = row.Cells["Age"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                comboBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxName.Focus();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show($"No user selected!!", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = textBoxName.Text;
            string ageStr = textBoxAge.Text;
            string address = comboBoxAddress.Text;
            string email = textBoxEmail.Text;
            // Validate name input
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            // Validate age input
            if (!int.TryParse(ageStr, out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAge.Focus();
                return;
            }

            // Validate name input
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter an address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxAddress.Focus();
                return;
            }

            // Validate email input
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();

                return;
            }
            try
            {
                using (var context = new FormContext())
                {
                    var user = context.users.Find(_id);
                    if (user != null)
                    {
                        user.Name = name;
                        user.Age = age;
                        user.Email = email;
                        user.Address = address;
                        context.users.Update(user);
                        context.SaveChanges();
                    }
                    MessageBox.Show($"User with Id {_id} updated successfully !", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception = {ex.Message}", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ResetControls();
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show($"No user selected!!", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record?", "Simple Desktop Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                using (var context = new FormContext())
                {
                    var user = context.users.Find(_id);
                    if (user != null)
                    {
                        context.users.Remove(user);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show($"User with Id {_id} deleted successfully !", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception = {ex.Message}", "Simple Desktop Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ResetControls();
                LoadData();
            }
        }
    }
}