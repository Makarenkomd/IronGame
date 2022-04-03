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

namespace IronGame2v
{
    public partial class FormSetOfGame : Form
    {
        public FormSetOfGame()
        {
            InitializeComponent();
        }

        private void buttonGraphicsMods_Click(object sender, EventArgs e)
        {
            string x=comboBoxColumns.Text;
            string y=comboBoxRows.Text;
            string t = comboBoxTime.Text;
            StreamWriter sw = new StreamWriter("SetOfGames.txt");
            sw.WriteLine(x);
            sw.WriteLine(y);
            sw.WriteLine(t);
            sw.Close();
            FormMods frm = new FormMods();
            frm.Show();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            FormMods frm = new FormMods();
            frm.Show();
        }

        private void FormSetOfGame_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("SetOfGames.txt");
            comboBoxColumns.Text = file.ReadLine();
            comboBoxRows.Text = file.ReadLine();
            comboBoxTime.Text = file.ReadLine();
        }
    }
}
