using System.Windows.Forms;
using WFA.Services;
using WFA.Forms;

namespace WFA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            string username = UsersService.loggedInUser.username;
            loggedInUserLabel.Text += $" {username}";
        }

        private void play_Click(object sender, System.EventArgs e)
        {
            GameManager.InitGame();
            new Questions().Show();
        }

        private void logoutButton_Click(object sender, System.EventArgs e)
        {
            Close();
            new Login().Show();
        }
    }
}
