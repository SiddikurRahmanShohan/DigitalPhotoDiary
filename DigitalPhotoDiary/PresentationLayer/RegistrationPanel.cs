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
    public partial class RegistrationPanel : Form
    {
        public RegistrationPanel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }
    }
}
