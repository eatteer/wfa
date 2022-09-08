using System;
using System.Windows.Forms;
using WFA.Services;

namespace WFA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;

            try
            {
                this.ValidateNotEmptyTextBoxes();
                UsersService.Register(name, username, password, email);
                MessageBox.Show("Sucessfully registered");
                this.CleanTextBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CleanTextBoxes()
        {
            nameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void ValidateNotEmptyTextBoxes()
        {
            string name = nameTextBox.Text.Trim();
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (
                name.Length == 0 ||
                username.Length == 0 ||
                password.Length == 0 ||
                email.Length == 0
            ) throw new Exception("No fields be empty");
        }
    }
}
