using System;
using System.Windows.Forms;
using WFA.Services;

namespace WFA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                this.ValidateNotEmptyTextBoxes();
                UsersService.Login(username, password);
                MessageBox.Show("Successfully Logged In");
                this.Close();
                new Home().Show();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ValidateNotEmptyTextBoxes()
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (username.Length == 0 || password.Length == 0) throw new Exception("No fields be empty");
        }

        private void checkRegisteresUsersButton_Click(object sender, EventArgs e)
        {
            String users = "";
            if(UsersService.users.Count == 0)
            {
                MessageBox.Show("There are not registered users");
                return;
            }
            foreach (var user in UsersService.users)
            {
                users += $"{user.name} - {user.username} \n";
            }
            MessageBox.Show(users);
        }
    }
}
