using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPhotoDiary.PresentationLayer
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationPanel registrationPanel = new RegistrationPanel();
            this.Hide();
            registrationPanel.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            HomePanel homePanel = new HomePanel();
            this.Hide();
            homePanel.Show();
        }
    }
}
