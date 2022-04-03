using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IronGame
{
    public partial class FormMods : Form
    {
        public string user = string.Empty;
        public FormMods()
        {
            InitializeComponent();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            form.profile = user;
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            FormGraphics form = new FormGraphics();
            form.Show();
        }

        private void buttonThemes_Click(object sender, EventArgs e)
        {
            FormThemes form = new FormThemes();
            form.Show();
        }

        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            FormProfile form = new FormProfile();
            form.Show();
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            FormDeleteProfile form = new FormDeleteProfile();
            form.Show();
        }

    }
}
