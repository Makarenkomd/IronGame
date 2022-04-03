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
    public partial class FormGraphics : Form
    {
        public int x = 0;
        public int y = 0;
        public int t = 0;
        public FormGraphics()
        {
            InitializeComponent();
        }
        
        private void buttonGraphicsMods_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("graphics.txt");
            file.Dispose();
            file = new StreamWriter("graphics.txt");
            file.WriteLine(Convert.ToString(comboBoxColumns.SelectedItem));
            file.WriteLine(Convert.ToString(comboBoxRows.SelectedItem));
            file.WriteLine(Convert.ToString(comboBoxTime.SelectedItem));
            file.Close();
            FormMods form = new FormMods();
            form.Show();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            FormMods form = new FormMods();
            form.Show();
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("graphics.txt");
            string temp_x = file.ReadLine();
            string temp_y = file.ReadLine();
            string temp_t = file.ReadLine();
            comboBoxColumns.Text = temp_x;
            comboBoxRows.Text = temp_y;
            comboBoxTime.Text = temp_t;
            file.Close();
        }
    }
}
