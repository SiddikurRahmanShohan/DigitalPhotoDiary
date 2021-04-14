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
        public CreateEventPanel()
        {
            InitializeComponent();
        }

        private void CreateEventPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HomePanel homePanel = new HomePanel();
            this.Hide();
            homePanel.Show();
        }
    }
}
