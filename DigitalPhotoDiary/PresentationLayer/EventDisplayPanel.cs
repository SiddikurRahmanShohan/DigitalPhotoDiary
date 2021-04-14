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
    public partial class EventDisplayPanel : Form
    {
        public EventDisplayPanel()
        {
            InitializeComponent();
        }

        private void EventDisplayPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void homeBackButton_Click(object sender, EventArgs e)
        {
            HomePanel homePanel = new HomePanel();
            this.Hide();
            homePanel.Show();
        }
    }
}
