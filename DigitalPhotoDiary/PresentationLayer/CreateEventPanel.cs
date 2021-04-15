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
    public partial class CreateEventPanel : Form
    {
        public CreateEventPanel(int userId, string userName)
        {
            InitializeComponent();
        }

        private void CreateEventPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int importance = 0;
            if (eventNameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }

            else if (!highRadioButton.Checked || !lowRadioButton.Checked || !modRadioButton.Checked)
            {
                MessageBox.Show("Set Importance");
            }
            else
            {

                EventsService eventService = new EventsService();
                int result = userService.AddNewUser(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text);
                if (result > 1)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
