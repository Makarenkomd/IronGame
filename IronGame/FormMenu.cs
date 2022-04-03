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
    public partial class FormMenu : Form
    {
        public string profile;
        public int score = 0;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMods_Click(object sender, EventArgs e)
        {
            FormMods form = new FormMods();
            form.Show();
            form.user = profile;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("current.txt");
            profile=file.ReadLine();
            file.Close(); 
            labelIdent.Text = profile;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormOpponent start = new FormOpponent();
            start.gamer1 = profile;
            start.Show();
        }
        
    }
}
