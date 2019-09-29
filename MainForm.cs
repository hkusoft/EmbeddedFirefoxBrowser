using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonGoogle_Click(object sender, EventArgs e)
        {
            GotoUrl("https://Google.com");
        }

     
        private void ButtonFacebook_Click(object sender, EventArgs e)
        {
            GotoUrl("https://Facebook.com");
        }

        private void ButtonLinkedIn_Click(object sender, EventArgs e)
        {
            GotoUrl("https://LinkedIn.com");

        }

        private void ButtonGithub_Click(object sender, EventArgs e)
        {
            GotoUrl("https://Github.com");
        }

        private void GotoUrl(string url)
        {

        }

    }
}
