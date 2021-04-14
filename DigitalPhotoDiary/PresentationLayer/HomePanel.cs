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
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void HomePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            EventDisplayPanel eventDisplayPanel = new EventDisplayPanel();
            this.Hide();
            eventDisplayPanel.Show();
        }


        private void createEventButton_Click(object sender, EventArgs e)
        {
            CreateEventPanel createEventPanel = new CreateEventPanel();
            this.Hide();
            createEventPanel.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }
    }
}
