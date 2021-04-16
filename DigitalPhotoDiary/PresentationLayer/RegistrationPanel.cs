using DigitalPhotoDiary.BusinessLayer;
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
            registerButton.Enabled = false;
        }

       

       

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else {
                    UserService userService = new UserService();
                    int result =userService.AddNewUser(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("You have been Registerd!");
                        this.Hide();
                        LoginPanel loginPanel = new LoginPanel();
                        loginPanel.Show();
                    }
                    else { MessageBox.Show("Registration Error!"); }
                }
            }

        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                registerButton.Enabled = true;
            }
            else
                registerButton.Enabled = false;
        }

        private void RegistrationPanel_Load(object sender, EventArgs e)
        {

        }
        private void RegistrationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
